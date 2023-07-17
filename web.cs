namespace web{
public class Web{
   public async Task<HttpResponseMessage> post_request(Header.Header header, Body.Body body, string url, dynamic client)
    {
        // creating a request
        var request = new HttpRequestMessage(HttpMethod.Post, url);

        // adding headers to the request
        foreach (KeyValuePair<string, string> item in header.cookie)
        {
            request.Headers.Add(item.Key, item.Value);
        }

        // adding body to the request
        if (body.data != null && body.data.Count > 0)
        {
            request.Content = new FormUrlEncodedContent(body.data);
        }

        // sending request
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return response;
    }


    public async Task<HttpResponseMessage> get_request(Header.Header header, string url, dynamic client)
    {
        // creating a request
        var request = new HttpRequestMessage(HttpMethod.Get, url);

        // adding headers to the request
        foreach (KeyValuePair<string, string> item in header.cookie)
        {
            request.Headers.Add(item.Key, item.Value);
        }

        // sending request
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();

        return response;
    }



}

}
