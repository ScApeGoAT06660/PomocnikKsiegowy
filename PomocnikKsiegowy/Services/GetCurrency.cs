using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikKsiegowy
{
    internal class GetCurrency
    {
        public async Task<string> GetCurrencyRate(string currencyCode, string date)
        {
            string url = $"https://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}/{date}/?format=json";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("Brak danych dla podanej daty lub waluty.");
                    }
                    else
                    {
                        throw new Exception("Nie udało się pobrać danych. Sprawdź kod waluty lub datę.");
                    }
                }

                string responseData = await response.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(responseData);

                string rate = json["rates"][0]["mid"].ToString();

                return rate;
            }
        }
    }
}
