class Program
{
    static void Main(string[] args){
        Logger l1 = Logger.GetInstance();
        Logger l2 = Logger.GetInstance();
        // Logger l3 = new Logger(); // This will cause a compilation error due to private constructor
        l1.Log("First Message");
        l1.Log("Second Message for checking singleton behavior");
        // l3.Log("Third Message for personal learning"); // This will also cause a compilation error
        Console.WriteLine(l1 == l2);
    }
}