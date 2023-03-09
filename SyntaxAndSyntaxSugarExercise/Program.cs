namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //explicit typing
            //string response;//explicit typing
           
            //if (answer < 9)
            //{
                //response = answer + " is less than nine";
            //}
            //else
            //{
                //response = answer + " is greater than or equal to nine";
            //}
            int answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nice" : $" {answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
