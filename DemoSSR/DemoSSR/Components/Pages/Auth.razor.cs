using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Text;

namespace DemoSSR.Components.Pages
{
    public partial class Auth
    {
        [Inject]
        public IJSRuntime _js { get; set; }

        private HttpClient _httpClient;
        private string _username;
        private string _password;

        protected override void OnInitialized()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://partners-api-acceptance.charleroi-airport.com");
            _username = Convert.ToBase64String(Encoding.UTF8.GetBytes("bstorm-lorents"));
            _password = Convert.ToBase64String(Encoding.UTF8.GetBytes("-sRX(S*0`CzCS'<L,:)j>5d)[+/Ym6&=§v?!"));

        }

        public void Connect()
        {
            var auth = new
            {
                Username = _username,
                Password = _password,
                SearchDate = DateTime.Now.ToString("yyyy-MM-dd")
            };

            string json = JsonConvert.SerializeObject(auth);
            HttpContent content = new StringContent(json,Encoding.UTF8,"application/json");

            using (HttpResponseMessage m = _httpClient.PostAsync("/api/Aodb/GetFlightsByDate", content).Result)
            {
                if (m.IsSuccessStatusCode)
                {
                    _js.InvokeVoidAsync("console.log", m.Content.ReadAsStringAsync());
                }
                else
                {
                    _js.InvokeVoidAsync("console.log", m);
                }
            }
        }
    }
}
