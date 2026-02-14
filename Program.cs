class Account
{
  string _accountName;
  double _accountBalance;

  public Account(string accountName, double accountBalance)
    {
        this._accountName = accountName;
        this._accountBalance = accountBalance;
    }

    public void Balance()
    {
        Console.WriteLine();
        Console.WriteLine($"Account {_accountName} balance is {_accountBalance.ToString("F2")}");
    }
    public double Deposit(double depo)
    {

        _accountBalance += depo;
        return _accountBalance;
    }
    public double Withdrawal(double withd)
    {
        if(_accountBalance < 1 || withd > _accountBalance)
        {
            Console.WriteLine();
            Console.WriteLine("Not enough balance.");
        }
        else
        {
             _accountBalance -= withd;
        }
        
        return _accountBalance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool mainMenu = true;

        int menuChoice;

        Account nikitaAccount = new Account("Nikita account",100.7);

        do
        {
            Console.WriteLine();
            Console.Write("Type 1 to view your account balance, 2 to withdraw, 3 to deposit: ");
            string input = Console.ReadLine();

            if(int.TryParse(input,out menuChoice))
            {
                if(menuChoice == 1)
                {
                     nikitaAccount.Balance();
                }
            }
             if(int.TryParse(input,out menuChoice))
            {
                if(menuChoice == 3)
                {
                     nikitaAccount.Deposit(10);
                     nikitaAccount.Balance();
                }
            }
              if(int.TryParse(input,out menuChoice))
            {
                if(menuChoice == 2)
                {
                     nikitaAccount.Withdrawal(50);
                     nikitaAccount.Balance();
                }
            }
            
        }while(mainMenu); 

    }
}