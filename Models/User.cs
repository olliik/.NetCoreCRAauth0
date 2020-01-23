namespace myapp.Models
{
    public class User
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Organization organization { get; set; }
    }
}