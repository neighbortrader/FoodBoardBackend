namespace FoodBoard.Features.Users.Representation
{
    public class UserWriteViewModel
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ZIPNumber { get; set; }
        public string Place { get; set; }
        public string Street { get; set; }
        public int AddressNumber { get; set; }
    }
}
