using System;
namespace HelloDotnet{
    class EcommerceShop{
        public string UserName { get; set; }
        public double WalletBalance{ get; set; }
        public double TotalPurchaseAmount{ get; set;}
    }

    class InsufficientWalletBalanceException : Exception{
        public InsufficientWalletBalanceException(string message): base(message)
        {

        }
    }
    class Program{
        public static EcommerceShop MakePayment(string name, double balance,double amount){
            if(balance < amount){
                throw new InsufficientWalletBalanceException("Insufficient balance");
            }

            return new EcommerceShop{
                UserName = name,
                WalletBalance = balance - amount,
                TotalPurchaseAmount = amount
            };
        }
        public static void Main(string [] args){
            try{
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter wallet balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter purchase Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                EcommerceShop shop = MakePayment(name , balance, amount);
                Conole.WriteLine("Payment successfull!!");
            }

            catch(InsufficientWalletBalanceException ex){

                Console.WriteLine(ex.Message);

            }
        }
    }
}