﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyGarage.Blazor.Config;
using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace MyGarage.Blazor.Pages
{
    public partial class InvoicePage : ComponentBase
    {
        protected enum UpdateFieldOn
        {
            Keystroke,
            LostFocus
        }
        protected event EventHandler<int> RaiseNewHashCode;

        protected UpdateFieldOn TextFieldInput { get; set; } = UpdateFieldOn.Keystroke; // defualt
        protected string UpdateOnText => TextFieldInput == UpdateFieldOn.Keystroke ? "oninput" : "onchange";

        protected void SetUpdateSettings(UpdateFieldOn newValue)
        {
            TextFieldInput = newValue;
        }

        [Inject] HttpClient httpClient { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }

        protected override void OnInitialized()
        {
            Observable.FromEventPattern<int>(h => RaiseNewHashCode += h, h => RaiseNewHashCode -= h)
                .Throttle(TimeSpan.FromMilliseconds(600))
                .Select(async (c) => new { response = await httpClient.PostAsJsonAsync("/pdfinvoice", pdfCommand) })
                    .Concat()
                 .Where(c => c.response.StatusCode == System.Net.HttpStatusCode.Created)
                 .Select(async (c) => new { content = await c.response.Content.ReadAsByteArrayAsync() })
                 .Concat()
                 .Select(c => c.content)
                .Subscribe(HandleIncomingPdf);


        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
        private void HandleIncomingPdf(byte[] pdfBody)
        {
            PdfBody = pdfBody;
            Console.WriteLine("array");
            _ = JSRuntime.InvokeVoidAsync("generatePdf", pdfBody);
            StateHasChanged();
        }

        string InvoiceHeader => Customer.IsNull() ? "Invoice" : $"Invoice for {Customer?.Name}";

        protected InvoiceModel Invoice { get; set; } = new();

        protected CustomerModel Customer = new CustomerModel();

        protected byte[] PdfBody = Array.Empty<byte>();
        protected GeneratePdfCommand pdfCommand = new GeneratePdfCommand();

        int previousCommand = -1;
        protected void RenderPdf()
        {
            pdfCommand = pdfCommand with
            {
                Invoice = Invoice,
                Customer = Customer
            };
            if (pdfCommand.GetHashCode() == previousCommand)
            {
                return;
            }
            previousCommand = pdfCommand.GetHashCode();
            RaiseNewHashCode?.Invoke(this, previousCommand);

            PdfBody = Array.Empty<byte>();
            _ = JSRuntime?.InvokeVoidAsync("window.clearCanvas");


        }



    }
}
