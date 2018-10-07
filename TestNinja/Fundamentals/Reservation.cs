namespace TestNinja.TestNinja.UnitTests.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)
            {
                return true;
            }
            else if (MadeBy == user)
            {
                return true;
            }

            return false;
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}