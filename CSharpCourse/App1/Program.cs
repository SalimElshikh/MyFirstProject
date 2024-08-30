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

#region Static Constractor 
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
//int x = 60;
//Console.WriteLine(x.IsGreaterThan(30))  ;

//string text = "500";
//Console.WriteLine(text.IsNumberOrNot());
//string statment = "";
//Console.WriteLine($"The Length Of Stetment Is {statment.Length}");
//Console.WriteLine(statment.CountOfWords());


//static class ExtentionMethod
//{
//    public static bool IsGreaterThan(this int num1, int num2)
//    {
//        return num1 > num2;
//    }
//    public static bool IsNumberOrNot(this string text)
//    {
//        return int.TryParse(text, out int num);
//    }

//    public static int CountOfWords(this string statment)
//    {
//        if (!string.IsNullOrEmpty(statment))
//        {
//            string[] subStrings = statment.Split(' ');
//            return subStrings.Length;
//        }
//        else
//        {
//            Console.WriteLine("Input Is Null");
//            return 0;
//        }


//    }

//}

#endregion

#region Example of Extention Method
//int[] sums = { 2, 3, 5, 6 };
//int target = 5;
//Solution s1 = new Solution();
//s1.TwoSum(sums, target);
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int[] resultArrey = new int[2] ;
//        for (int i = 0; i < nums.Length; i++)
//        {

//            if (nums[i] + nums[i + 1] == target)
//            {
//                resultArrey[0] = nums[i];
//                resultArrey[1] = nums[i + 1];

//            }
//        }
//        return resultArrey;

//    }
//}
//
//int[] sums = { 2, 3, 5, 6 };
//int target = 5;
//Solution.TwoSum(sums, target);

//public class Solution
//{
//    public static int[] TwoSum(int[] nums, int target)
//    {
//        // Create a dictionary to store number and its index
//        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

//        for (int i = 0; i < nums.Length; i++)
//        {
//            int complement = target - nums[i];

//            // Check if the complement exists in the dictionary
//            if (numToIndex.ContainsKey(complement))
//            {
//                // If found, return the indices
//                return new int[] { numToIndex[complement], i };
//            }

//            // Otherwise, add the number and its index to the dictionary
//            numToIndex[nums[i]] = i;
//        }

//        // Return an empty array if no solution was found
//        return new int[] { -1, -1 };
//    }
//}
#endregion

#region Recursive Function 
//Factorial Function using Non Recursive Way  

//int number = 9 ;
//Console.WriteLine(FactorialRecursive(number));
//Console.WriteLine(FactorialOfNumber(number));
// static int FactorialOfNumber(int number )
//{
//    int valueResult = 1;
//    if (number == 0)
//        return 1;
//    for (int i = number; i > 0; i--)
//    {
//        valueResult *= i;
//        Console.WriteLine(i);
//    }


//    return valueResult;

//}


//Factorial Function Using Recursive Way 

//static int FactorialRecursive(int number )
//{
//    if (number == 0)
//        return 1;
//    return number * FactorialRecursive(number - 1);
//}

//Open Folder
//string path = string.Empty;
//path = @"C:\Projects";
//DisplayFolders(path, 0);
//static void DisplayFolders(string path , int indent)
//{

//    foreach (var folder in Directory.GetDirectories(path))
//    {
//        Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
//        DisplayFolders(folder, indent + 3);
//    }

//}
#endregion

#region Inheritance 
//inheret from class to anther class  oneclass : twoclass 
#endregion

#region Polymorphism 

//Compile Time (Static Type) Overloading                 اكتر من function بنفس الاسم ولكن بتختلف في السيجنتشر 



// RunTime (Dynamic) Overriding  
//دي بالضبط زي ان انا بعمل في الكلاس الاول دالة بتعمل حاجة معينة ولكن فيما بعد حبيت اني اذود عليها او اعدلها او اضيف علي نفس الدالة معلومات اكتر 
//فيما بستدعيها في الكلاسات التانية الي بتكون وارسة من الكلاس الام 
// بضيف في الام virtual ولكن بضيف في الابناء override 
//Shape shape1 = new Shape();
//Shape shape2 = new Circle();
//Shape shape3 = new Traiangle();
//Shape shape4 = new Line();

//shape1.Draw();
//shape2.Draw();
//shape3.Draw();
//shape4.Draw();

////ٍShape[] Shapes = new Shape[4];
////Shapes[0] = new Shape();
////Shapes[1] = new Circle  ();
////Shapes[2] = new Traiangle ();
////Shapes[3] = new Line ();


//// انا ممكن ابدل override واخليها new في الحالة دي اكني معملتش حاجة وهتتنفذ من الاب دائما 
//// مهمة ال new اني اضيع رسالة الخطا 
//public class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Basic Shepe Is Created " );
//    }
//}
//public class Circle: Shape 
//{
//    public override  void Draw()
//    {
//        Console.WriteLine("Cirecle Is Created " );
//    }
//}
//public class Traiangle : Shape  
//{
//    public  override void Draw()
//    {
//        Console.WriteLine("Traiangle Is Created "   );
//    }
//}

//public class Line() : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Line Is Created ");
//    }
//}



#endregion

#region Abstraction  فكرة مجردة 
//abstract class Shape
//{
//    abstract public void Draw();

//    public void SayHello()
//    {
//        Console.WriteLine("Hello Form the Abstract Class ");
//    }
//}

//class Lines : Shape
//{
//    public override void Draw()
//    {
//            Console.WriteLine("Hello In Abstract Class ");
//    }
//}


#endregion

#region Sealed Classed 
//بتمنع اي كلاسس من التوريث 
//Seadled Classed 

//sealed class Animal
//{
//    public string Name { get; set; }
//}

//class Gog //: Animal
//{
//    public string DogBreed { get; set; }

//}

#endregion

#region Static Class 
// في الكلاس دي لازم عشان اقدر اعرف خصائص لازم تكوم static وكمنا الخصائث نفس النظام 

// وكذالك الكلاس نفس الشي الدوال لازم تكون static 
// وعشان اخد الداتا بتصل مباشر زي 
// can't create an instance 
// By default Is Sealed Can't inherit From it 
// can't create an constractor 
// 
//Console.WriteLine(Campany.GetTotalEmployee());

//Console.WriteLine(TempretureConventer.FehrenheitClesius(90  ));
//Console.WriteLine(TempretureConventer.ClesiusFehrenheit(30  ));



//static class Campany
//{
//    static public string  CompanyName { get; set; } = string.Empty;
//    static public string CompanyAdd { get; set; } = string.Empty;
//     static public  int GetTotalEmployee()
//    {
//        return 44444;
//    }
//}
//public static class TempretureConventer
//{
//    public static double ClesiusFehrenheit(double fehrenheit)
//    {
//        return (fehrenheit * 9 / 5) + 32;
//    }

//    public static double FehrenheitClesius(double fehrenheit)
//    {
//        {
//            return (fehrenheit - 32) * 5  / 9;
//        }

//    }
//}




#endregion

#region partial Classes 
//using App1;
//// تقسيم الكلاس الي اكتر من ملف مثال الدوال في ملف مختلف عن الخصائص 
//// وبكدة انا اقدر ااكسس كل الدوال والخصائص عند ملف program.cs
//Employee Employee1 = new Employee();
//Employee1.

#endregion

#region  Convert RomanNumber To ENNumber 



//string romanNum = "MCDLXXVI";
//Solution number = new Solution();
//Console.WriteLine(number.RomanToInt(romanNum));
//class Solution
//{

//    public int RomanToInt(string s)
//    {
//        int enNumber = 0;
//        char[] word = s.ToCharArray();
//        for (int i = 0; i < word.Length; i++)
//        {
//            if (word[i] == 'I')
//                enNumber += 1;
//            else if (word[i] == 'V')
//                if (i == 0)
//                    enNumber += 5;
//                else
//                if (word[i - 1] == 'I')
//                    enNumber += 3;
//                else
//                    enNumber += 5;
//            else if (word[i] == 'X')
//                if (i == 0)
//                    enNumber += 10;
//                else
//                    if (word[i - 1 ] == 'I')
//                        enNumber += 8;
//                    else
//                        enNumber += 10;
//            else if (word[i] == 'L')
//                enNumber += 50;
//            else if (word[i] == 'C')
//                if (i == 0)
//                    enNumber += 100;
//                else
//                    if (word[i - 1] == 'X')
//                    enNumber += 80;
//                else
//                    enNumber += 100;
//            else if (word[i] == 'D')
//                enNumber += 500;
//            else if (word[i] == 'M')
//                if (i == 0)
//                    enNumber += 1000;
//                else
//                    if (word[i - 1] == 'C')
//                    enNumber += 800;
//                else
//                    enNumber += 1000;
//        }

//        return enNumber;

//    }

//}
#endregion

#region Nested Class 

//using System.Xml.Serialization;
////dog , and caot by defualt private 
//Animal name1 = new Animal();
//Animal.Dog Dog1 = new Animal.Dog();
//Animal.Caot Caot1 = new Animal.Caot();



//class Animal
//{
//    public string Name { get; set; } = String.Empty;

//    public string NameWeight { get; set; }


//    public Animal()
//    {

//        Caot.GetBour();

//    }
//    public class Dog 
//    {
//        public string Name { get; set; }
//        public void GetName() { }
//    }
//    public class Caot
//    {
//        public int Id { get; set; }
//        public static void GetBour() { }
//    }
//}
#endregion

#region One Dimention Array 
//string[] friends = new string[4];

//var friends = new string[5]
//{
//    "salem",
//    "Osama",
//    "Ebraheem",
//    "Elsayed",
//    "Nour",
//};

//friends[0] = "slame";
//friends[1] = "osama";
//friends[2] = "mahmoud";
//friends[3] = "ebrahem";
//friends[4] = "elsayed";

#endregion

#region Multidimetional Array 
//int[,] soduko =
//{
//    {2,3,4,5, 5},
//    {3,3,4,5,5 },
//    {2,3,45,6 ,5},
//};

#endregion

#region Jaged  Array 
//int[][] sodukoo = new int[][]
//{
//    new int[]{2,3,4,5, 5},
//    new int[] { 3, 3, 4, 5, 5 },
//    new int[] { 2, 3, 45, 6, 5 },
//};

#endregion

#region  Endices And Range 
//var friends = new string[5] { "Salem", "Osama", "Mohmoud", "Nada", "Ebraheam" };

//var slice1 = friends[1..^3];
//slice1.Print();



//public static class Extention 
//{
//    public static void Print(this string[] Names)
//    {
//        Console.Write("{ ");
//        for(int i = 0; i<Names.Length; i++)
//        {
//            Console.Write(Names[i]);
//            Console.Write(i < Names.Length-1 ? ", " : "");
//        }
//        Console.Write(" }");
//    }
//}
#endregion

#region Boudns Checking 
//Out Of Range 
#endregion

#region Expression Types And Binary Operatior 
////Primary Expretion start with type.Member in Type (method Call )
//var amount = Math.Cos(30)+1;
////Void Expreion Don't return Value 

//Console.WriteLine("Salem");

//// Assment Statment 
//int x=0;
//x = x + 1;
////Pressedent   الاولويات من الشمال الي اليمين 
//double z = (2.0 / 3 / 3 / 3);
//Console.WriteLine($"z = {z}");
//// الاولويات في || و && و ! من اليمين للشمال 


#endregion

#region Null(Coalescing, Conditional)

//// ?? check if string Is Null or Not
//// If string i snull return default Value  = "Salem"
//string s1 = null;
//s1 = s1 ?? "Salem";
//// if string is null return null with no exeption error else return ToUpper();
//string s2 = "apc";
//s2 = s2?.ToUpper();
//Console.WriteLine(s2);


//Console.ReadKey();

#endregion

#region CAsting
//long nl = 100;
//int nI = nl;
// not int to long ,,,, Int32 , int64 
//Implict Casting 
//(Type that i want to convert )

// Boxxing convert value type to refferance type 
//int x = 10;
//object obj;
//obj = x;
//// // Unbxing 
//int y = (int)obj;
//// Convert string to int 
//string val = "120";
////type.Parse() 
//int.Parse(val);
// string number = "200";
//if(int.TryParse(number , out int s))
//{
//    Console.WriteLine($"s = {s}");
//}
//else
//{
//    Console.WriteLine("Invalid Number format ");
//}

//Convert.ToInt32(number);
//var number = 225;
//var bytes = BitConverter.GetBytes(number);
//foreach (var b in bytes)
//{
//    var binary = Convert.ToString(b, 2).PadLeft(8,'0');
//    Console.WriteLine(binary);
//}

// Convert string to hexadecimal 
//var name = "Salem";
//char[] chars = name.ToCharArray();
//foreach (var c in chars)
//{
//    var asci = Convert.ToInt32(c);
//    var asciBinary = Convert.ToString(asci, 2).PadLeft(8, '0');
//    //var output = $"Asci Code is {asci} , Binary : {asciBinary} , Hexadecimal : {asciBinary}x";
//    var output = $"Asci Code is {asci} , Binary : {asciBinary} , Hexadecimal : {asci:x}";
//    Console.WriteLine(output);
//}

// Convert Hexadicimal to string 

//string[] hexVarlues = {"63","61" ,"6c" ,"65" ,"6d"};
//foreach (var num in hexVarlues)
//{
//    int s = Convert.ToInt32(num,16);
//    var intString = Char.ConvertFromUtf32(s);
//    var ch = (char)s;

//    Console.Write(ch);
//}
//Convert  form hex,Binary or eny Style NUmber to int 
//var hex = "1000";
//int number = Int32.Parse(hex, System.Globalization.NumberStyles.BinaryNumber);
//Console.WriteLine(number
//    );
#endregion
