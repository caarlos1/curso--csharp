namespace heranca.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }
        
    }
}