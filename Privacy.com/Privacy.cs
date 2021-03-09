using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrivacyCom.Models;

namespace PrivacyCom
{
    public class Privacy
    {
        private string SANDBOX_BASE_URL = "https://sandbox.privacy.com/v1";
        private string PRODUCTION_BASE_URL = "https://api.privacy.com/v1";
        public string BASE_URL = "";

        public Boolean IsProduction { get; set; }
        public String ApiKey { get; set; }

        public Privacy(string API_KEY, Boolean IsProduction)
        {
            this.IsProduction = IsProduction;
            this.ApiKey = API_KEY;

            if (IsProduction)
            {
                this.BASE_URL = this.PRODUCTION_BASE_URL;
            }
            else
            {
                this.BASE_URL = this.SANDBOX_BASE_URL;
            }
        }


        /// <summary>
        /// Adds a bank account as a funding source using routing and account numbers.
        /// Returns a FundingAccount object containing the bank information.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<object> AddBank(AddBank model)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"api-key {this.ApiKey}");


            var body = new
            {
                account_name = model.AccountName,
                account_number = model.AccountNumber,
                routing_number = model.RoutingNumber
            };
            var json = JsonConvert.SerializeObject(body);

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(BASE_URL + "/fundingsource/bank", stringContent);

            var result =  response.Content.ReadAsStringAsync().Result;

            var bank = result;

            return bank;

        }


        public async Task<object> UpdateBank(UpdateBank model)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"api-key {this.ApiKey}");


            var body = new
            {
                token = model.Token,
                state = model.State
            };

            var json = JsonConvert.SerializeObject(body);

            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync(BASE_URL + "/fundingsource/bank", stringContent);

            var result = response.Content.ReadAsStringAsync().Result;

            var bank = result;

            return bank;

        }



    }

}
