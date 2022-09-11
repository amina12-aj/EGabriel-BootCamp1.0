namespace hub.Data
{
    public class Repository : IRepository
    {
        private readonly Api _api;

        public Repository(Api api)
        {
            _api = api;
        }
        public Dictionary<string, object> GetHubs(string state)
        {
            Dictionary<string, object> Dict = new Dictionary<string, object>();
            var data = _api.GetHubs(state).Result;
            
            if(data!["status"].ToString() == "success")
            {
                Dict.Add("success", data["data"]);
            }
            else
            {
                Dict.Add("error", data["message"].ToString()!);
            }
            return Dict;
        }
    }
}
