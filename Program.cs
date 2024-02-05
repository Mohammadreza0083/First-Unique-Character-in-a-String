namespace First_Unique_Character_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solutioncs solutioncs = new();
            Console.WriteLine("Enter your string : ");
            string input = Console.ReadLine();
            Console.WriteLine(solutioncs.FirstUniqChar(input));
        }
    }
}
