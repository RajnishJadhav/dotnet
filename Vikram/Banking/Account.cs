using jj;

namespace DD;

public class Account{

    public event Notification Nevent;
    public int Balance{get;set;}

    public void Deposit(int amount)
    {
        Balance+=amount;
        Console.WriteLine(amount+" credited to your account.Total balance is "+Balance);
    }

    public void Withdraw(int amount)
    {
        Balance-=amount;
        // if(Balance>100){
        // System.Console.WriteLine("calling event");
        // Nevent("dfk");
        // }
        Console.WriteLine(amount+" debited from your account.Total balance is "+Balance);
    }


}