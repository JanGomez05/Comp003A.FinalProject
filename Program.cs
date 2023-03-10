/*
 * Author: Jan Gomez
 * Purpose: Final Assignment
 * Course: Comp003A L01
 * 
 */
namespace Conp003A.FinalProject;
class Program
{
    static void Main(string[] args)
    {
        // theme would be for health patient.
        SectionSeparator("Welcome to Hanfords Clinic!" +
         " Here is a Registry for new Patients." +
         "Please Answer and Label the inquiery.");

        List<string> names = new List<string>();
        char userInput = default;
        do
        {
            Console.WriteLine("Please write your legal First Name:");
            names.Add(Console.ReadLine());
            if (!char.IsLetter(Console.ReadKey().KeyChar))
            {
                Console.WriteLine("Please write a valid name!");
            }
            Console.WriteLine("Please enter your legal Last Name:");
            names.Add(Console.ReadLine());
            if (!char.IsLetter(Console.ReadKey().KeyChar))
            {
                Console.WriteLine("Please write a valid name!");
            }
            
        } while (userInput != 123456789);

        Console.WriteLine("Please enter the year you were born.");
        int year = Convert.ToInt32(Console.ReadLine());
        AgeCalculator(year);

    }// end of main code.
    /// <summary>
    /// Leaving title for the final
    /// </summary>
    /// <param name="section"></param>
    static void SectionSeparator(string section)
    {
        Console.WriteLine("".PadRight(100, '*') +
            $"\n\t\t{section} Section\n"
            + "".PadRight(100, '*'));
    }

    // grabbing patients Birth Year
    static int AgeCalculator(int year)
    {
        int MinYear = 1900;
        int MaxYear = 2022;
        return DateTime.Now.Year - year;
    }
}
