namespace HttpClientTest.Models
{
    public class Paging
    {
        public int current { get; set; }
        public int total { get; set; }
    }

    public class TimezoneResponse
    {
        public string get { get; set; }
        public List<object> parameters { get; set; }
        public List<object> errors { get; set; }
        public int results { get; set; }
        public Paging paging { get; set; }
        public List<string> response { get; set; }
    }
}