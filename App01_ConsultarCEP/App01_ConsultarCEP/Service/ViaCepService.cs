using App01_ConsultarCEP.Model;
using Newtonsoft.Json;
using System.Net;

namespace App01_ConsultarCEP.Service
{
    public class ViaCepService
    {
        private static readonly string urlAddress = "https://viacep.com.br/ws/{0}/json/";

        public static Address FindAddressByCep(string cep)
        {
            string newUrlAddress = string.Format(urlAddress, cep);

            WebClient wc = new WebClient();
            string content = wc.DownloadString(newUrlAddress);

            Address a = JsonConvert.DeserializeObject<Address>(content);

            if (a.cep == null)
                return null;

            return a;
        }
    }
}