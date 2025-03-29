namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Owner Mohamed = new Owner("Mohamed");
            Owner owner1 = new Owner("Sanyi");
  

            Bank otp = new Bank(4);
            BankAccount account1 = otp.NewAccount(Mohamed, 2000);
            BankAccount account3 = otp.NewAccount(Mohamed, 1000);
            BankAccount account2 = otp.NewAccount(owner1, 0);

            account1.Desposit(1000);
            account1.Desposit(300);
            account1.Withdraw(500);


            account2.Desposit(200);

            Console.WriteLine($" {Mohamed.Name} egyenleg : {otp.TotalBalance(Mohamed)}  ");
            Console.WriteLine($" {account1.Withdraw(500)}");
            Console.WriteLine($"  Maximalis egyenleg : {otp.MaximalBalanceAccount(Mohamed)}");
            Console.WriteLine($"  CreditLimit egyenleg : {otp.TotalCreditLimit()}");

            Console.WriteLine($" {owner1.Name} egyenleg : {otp.TotalBalance(owner1)}  ");




        }
    }
}
