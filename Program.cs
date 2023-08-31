
using Objects_Mills_Justyce;

internal class Program
{
    private static void Main(string[] args)
    {
        Computer myComputer = new Computer(true, "Razer", "Gaming");//Creates a new Computer object and pass through needed arguments
        IBootUp myBootUp = myComputer;//Creates a IBootUp object that is assigned to the computer object just created
        Console.WriteLine(myComputer.Equals(myBootUp));//Compares the two using the Equals built-in object method and prints the results to console

        Computer anotherComputer = new Computer(true, "Razer", "Gaming");//Creates another Computer object and assigns it to the same values passed through on the first computer object
        Console.WriteLine(myComputer.Equals(anotherComputer));//Compares the two Computer objects and prints the results to console

        string myString = myComputer.ToString();//Creates a new string variable and gave it the value of one of the Computer object's ToString method
        Console.WriteLine(myString == myComputer.ToString());//Compares the string variable to the object used to create it using ToString and prints the results to console
        Console.WriteLine(myString == anotherComputer.ToString());//Compares the string variable to another object and prints the results

        Console.WriteLine(myComputer.GetType());//Calls the GetType method on a computer object and prints the results to console
        Console.WriteLine(myBootUp.GetType());//Calls GetType on the IBootUp object and prints the results to console

        anotherComputer.PowerOnOff();//Turns on or off one of the computer objects by calling the PowerOnOff method

        Console.WriteLine(myString.Contains('i'));//Sees if the string variable contains the letter "i" and prints the results to console
        Console.WriteLine(myString.ToUpper());//Calls ToUpper on the string variable and print the results
    }
}