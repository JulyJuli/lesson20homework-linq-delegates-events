namespace CarWash.Classes
{
    public class WashingCard
    {
        public WashingCard(int expirationYear, int balance)
        {
            ExpirationYear = expirationYear;
            Balance = balance;
        }

        public int ExpirationYear { get; set; }

        public int Balance { get; set; }
    }
}
