#region Methods In C# 
//string[] names = { "One", "Two" };
//Person One = new Person();
//One.FirstName = "John";
//One.LastName = "Doe";
//One.BirthDay = new DateOnly(1990, 12, 25);
//One.Country = "USA";
//One.MobileNum = "1234567890";

//Person Two = new Person();
//Two.FirstName = "Jane";
//Two.LastName = "Doe";
//Two.BirthDay = new DateOnly(1995, 5, 15);
//Two.Country = "USA";
//Two.MobileNum = "0987654321";

//PrintInfoPersonOne(One);
//PrintInfoPersonTwo(Two);
//static void PrintInfoPersonOne(Person One)
//{
//    Console.WriteLine(One.FirstName);
//    Console.WriteLine(One.LastName);
//    Console.WriteLine(One.BirthDay);
//    Console.WriteLine(One.Country);
//    Console.WriteLine(One.MobileNum);
//}
//static void PrintInfoPersonTwo(Person Two)
//{
//    Console.WriteLine(Two.FirstName);
//    Console.WriteLine(Two.LastName);
//    Console.WriteLine(Two.BirthDay);
//    Console.WriteLine(Two.Country);
//    Console.WriteLine(Two.MobileNum);
//}

#endregion

#region BankExample In C# 
//BankAccount usaAccount = new BankAccount("USA Bank", "Berlin Bransh", "2st Berlin", "123455445", 2000, "USD");
//BankAccount myAccount = new BankAccount("USA Bank", "Berlin Bransh", "9st Berlin", "12340000", 2500, "USE");
////myAccount.BankName = "Bank Of America";
////myAccount.BranchName = "Branch Of America";
////myAccount.BranchAddress = "1234 Main St";
////myAccount.AccountNumber = "1234567890";
////myAccount.Balance = 1000;
////myAccount.Currency = "USD";
//Console.WriteLine("==== My Bank Account ====");
//myAccount.Withdraw(1000);
//Console.WriteLine("==== My User Account ====");
//myAccount.Deposit(1000);
//class BankAccount
//{
//    public string BankName { get; set; }
//    public string BranchName { get; set; }
//    public string BranchAddress { get; set; }
//    public string AccountNumber { get; set; }
//    public decimal Balance { get; set; }
//    public string Currency { get; set; }
//    public BankAccount(string bankName, string branshName, string branchAdd, string accNumber, decimal balance, string currency)
//    {
//        BankName = bankName;
//        BranchName = branshName;
//        BranchAddress = branchAdd;
//        AccountNumber = accNumber;
//        Balance = balance;
//        Currency = currency;


//    }


//    public void Withdraw(decimal amount)
//    {
//        decimal newBalance = Balance - amount;
//        if (newBalance < 0)
//        {
//            Console.WriteLine("Invalid Transaction ");
//        }
//        else
//        {
//            Console.WriteLine($"Your Original Balance Is : {Balance}");
//            Console.WriteLine($" Your Balance Is After WithDrow : {newBalance}");
//            Console.WriteLine($" Your Balance For Account {AccountNumber} Is : {newBalance}");
//        }
//        Console.WriteLine($"Transaction Date Is {DateTime.Now}");
//    }
//    public void Deposit(decimal amount)
//    {
//        decimal newBalance = Balance + amount;
//        Console.WriteLine($" Your Deposit  Is {amount}");
//        Console.WriteLine($" Your Balance For Account {AccountNumber} After Deposit Is {newBalance}");
//        Console.WriteLine($"Transaction Date Is {DateTime.Now}");
//    }
//    public void Transfer() { }
//    public void PrintInfo() { }
//}

#endregion

#region Example Of Class
//class Person
//{
//    string firstName;
//    string lastName;
//    DateOnly birthDay;
//    string country;

//    // properties 
//    public string FirstName
//    {
//        get { return firstName; }
//        set { firstName = value; }
//    }
//    public string LastName
//    {
//        get { return lastName; }
//        set { lastName = value; }
//    }
//    public DateOnly BirthDay { get; set; }
//    public string Country { get; set; }
//    public string MobileNum { get; set; }

//}


#endregion

#region Default Constructor 
//Console.WriteLine("==== Default Constractor ==== ");
//Enemy Zombie = new Enemy();
//Console.WriteLine(Zombie.Health);

//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }
//    public Enemy()
//    {
//        Console.WriteLine("New Enemy Is Created. "  );
//        Health = 100;
//    }
//}
#endregion

#region Parameterized Constructor


//Enemy z1 = new Enemy("Gaint Zombie", 200);
//Console.WriteLine(z1.EnemyName);
//Console.WriteLine(z1.Health);


//class Enemy
//{
//    public int Id  { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }

//    public Enemy(string enemyName , double health)
//    {
//        Console.WriteLine("The New Enemy Is Created.");
//        Health = health;
//        EnemyName = enemyName;

//    }
//}

#endregion

#region Copy Constractor 
//Enemy z1 = new Enemy("Giant Worf", 120);
//Enemy z2 = new Enemy(z1);
//Console.WriteLine(z1.EnemyName );
//Console.WriteLine(z1.Health);
//Console.WriteLine("============================");
//Console.WriteLine(z2.EnemyName );
//Console.WriteLine(z2.Health );

//class Enemy
//{
//    public int Id { get; set; }
//    public string EnemyName { get; set; }
//    public double Health { get; set; }
//    public Enemy(string enemyName , double health)
//    {
//        Console.WriteLine("The New Enemy Is Created From Parameterized constructor");
//        EnemyName = enemyName;
//        Health = health;
//    }

//    public Enemy(Enemy enemy)
//    {
//        Console.WriteLine("The New Enemy Is Create From Copy Constractor ");
//        EnemyName = enemy.EnemyName;
//        Health = enemy.Health;
//    }
//}

#endregion

#region Private Constractor 


////Counter count1 = new Counter();
//Console.WriteLine($" Count Is {Counter.currentCount}");
//public class Counter
//{
//    public static int currentCount;


//    private Counter()
//    {
//        Console.WriteLine("The New Enemy ");
//        currentCount = 50;
//    }
//}


#endregion

# region Static Constractor 
////Static Constractor Can't Call More Than One 
//Console.WriteLine("This Is Static Constractor   In C# ");
//Enemy robot = new Enemy();
//Enemy robot2 = new Enemy();



//public class Enemy
//{
//    public static int staticCounter= 0;
//    public static int instancCounter = 0;


//    static Enemy()
//    {
//        staticCounter++;
//        Console.WriteLine($"The StaticCounter Is : {staticCounter}");
//    }
//    public Enemy()
//    {
//        instancCounter++;
//        Console.WriteLine($"The StaticCounter Is : {instancCounter}");

//    }

//}

#endregion

#region  static Method 

//Person.CreateNewMethodStatic();


//Person p1 = new Person();
//p1.CreateNewMethodNonStatic();

//public class Person
//{
//    public static void CreateNewMethodStatic()
//    {
//        Console.WriteLine("The New Method Has been Created Using Static Method ");

//    }
//    public void CreateNewMethodNonStatic()
//    {
//        Console.WriteLine("The New Method Has been Created Using Non Static Method ");
//    }
//}

#endregion

#region Extention Method 
 


#endregion 
