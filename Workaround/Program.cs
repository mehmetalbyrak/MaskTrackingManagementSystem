using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");


        //Variables();
        Citizen citizen1 = new Citizen();
        citizen1.FirstName = "MEHMET";
        citizen1.LastName = "ALBAYRAK";
        citizen1.DateOfBirthYear = 1789;
        citizen1.NationalIdentity = 12345678910;
        
        
        
        SayHello(" Mehmet");
        SayHello(" Emma");
        SayHello();
        int result = Add(5,5);
        
        Console.WriteLine(result);
        
        // arrays

        string student1 = "Mehmet";
        string student2 = "Jasmin";
        string student3 = "Emma";

        /*Console.WriteLine(student1);
        Console.WriteLine(student2);
        Console.WriteLine(student3);*/

        string[] students = new string[3];
        students[0] = "Mehmet";
        students[1] = "Jasmin";
        students[2] = "Emma";

        students = new string[4];
        students[3] = "Henry";
        

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }

        string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] cities2 = new[] { "Bursa", "Antalya", "Gaziantep" };

        cities2 = cities1;
        cities1[0] = "Adana";
        Console.WriteLine(cities2[0]); // --> Adana
        // class, interface, arrays are reference types

        int num1 = 10;
        int num2 = 20;
        num2 = num1;
        num1 = 30;
        Console.WriteLine(num2); // --> 10
        // int, double, bool are value types

        foreach (string city in cities1)
        {
            Console.WriteLine("--> " + city);
        }
        
        
        // MyList --> Homework Challenge 
        List<string> newCities1 = new List<string>{"London", "Berlin", "Madrid"};
        newCities1.Add("New York");

        foreach (var city in newCities1)
        {
            Console.WriteLine(city);
        }

        PttManager pttManager = new PttManager(new CitizenManager());
        pttManager.GiveMask(citizen1);
    }

    static void SayHello(string name = " Noname")
    {
        Console.WriteLine("Hello" + name);
    }

    static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        Console.WriteLine("adding : " + result);
        return result;
    }

    
    
    private static void Variables()
    {
        string message = "Hello";
        double price = 100000;
        int number = 100;
        bool isLoggedin = false;

        string firstName = "Mehmet";
        string lastName = "ALBAYRAK";
        int birthYear = 1789;
        long identityNumber = 12345678910;


        Console.WriteLine(price * 1.18);
        Console.WriteLine(message);
    }
}

