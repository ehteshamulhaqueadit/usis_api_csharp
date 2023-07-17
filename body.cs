namespace Body
{
    public class Body
    {
        public Dictionary<string, string> data = new Dictionary<string, string> { };

        public void update_body(Dictionary<string, string> body)
        {
            data = body;
        }
    }
}
