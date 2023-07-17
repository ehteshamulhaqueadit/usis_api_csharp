namespace ID
{
    public class ID
    {
        public async Task<dynamic> login(string username, string password)
        {
            // login logic goes here

            //cycle 1
            System.Net.Http.HttpClient client = new HttpClient();
            Header.Header header = new Header.Header(client);
            Dictionary<string,string> cookie = await header.getcookie();
            header.cookie = cookie;

            //cycle 2
            header.cookie["appkey"] = "AX32WOHH231FDS2158N14L8N";
            Body.Body body = new Body.Body();
            body.data["j_username"] = username;
            body.data["j_password"] = password;
            web.Web browser = new web.Web();
            System.Net.Http.HttpResponseMessage res = await browser.post_request(
                header,
                body,
                "https://usis.bracu.ac.bd/academia/j_spring_security_check",
                client);

            //cycle 3
            foreach (var item in res.Headers)
            {
                header.cookie[item.Key] = string.Join(";", item.Value);
            }
            res = await browser.post_request(
                header,
                body,
                "https://usis.bracu.ac.bd/academia/dashBoard/successHandler",
                client);
            return res;




        }
    }
}
