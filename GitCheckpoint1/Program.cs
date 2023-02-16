using System.Security.Cryptography.X509Certificates;

namespace GitCheckpoint1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            
            var CheckTest = new CheckTest();
            CheckTest.testMessage("Task 2 checked");
            Console.WriteLine();

            var Calculate = new Calculate();
            Calculate.CalculateName(5, 20);
            
        }
        
    }
}
//Call this method from Main method in Program.cs and provide the text "Task 2 checked". Compile and run the program.