using System.Collections.Generic;

namespace Header
{
    public class Header
    {

        public System.Net.Http.HttpClient client;

        public Header(System.Net.Http.HttpClient client){
            this.client = client;
        }


        public Dictionary<string, string> cookie = new Dictionary<string, string>{};

        public async Task<Dictionary<string, string>> getcookie()
        {
            web.Web browser = new web.Web();
            System.Net.Http.HttpResponseMessage res = await browser.get_request(
                new Header(this.client),
                "https://usis.bracu.ac.bd/academia/",
                client);

            // create a dictionary to store the headers
            var headers = new Dictionary<string, string>();
            foreach (var header in res.Headers)
            {
                headers[header.Key] = string.Join(";", header.Value);
            }

            return headers;
        }

}

}
