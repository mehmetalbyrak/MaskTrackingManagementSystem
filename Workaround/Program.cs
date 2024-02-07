internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");


        //Variables();
        Citizen citizen1 = new Citizen();
        citizen1.firstName = "Mehmet";
        citizen1.lastName = "Albayrak";
        citizen1.birthYear = 1995;
        citizen1.identityNumber = 12345678910;
        
        
        SayHello(" Mehmet");
        SayHello(" Halise");
        SayHello();
        int result = Add(5,5);
        
        Console.WriteLine(result);
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
        int birthYear = 1995;
        long identityNumber = 1234567890;


        Console.WriteLine(price * 1.18);
        Console.WriteLine(message);
    }
}

public class Citizen
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int birthYear { get; set; }
    public long identityNumber { get; set; }
}