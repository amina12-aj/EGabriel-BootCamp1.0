namespace BookApp.Models
{
    public class AuthorListingViewModel
    {
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        public double MobileNo { get; set; }

        public int TotalBooks { get; set; }
        
    }
}
