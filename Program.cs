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

        Console.WriteLine("Enter a first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("PLease enter yout Last Name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Please enter the year you were born.");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your age is: {AgeCalculator(year)}");

        char gender;

        Console.WriteLine("Pease insert your gender as M/m , F/f or O/o:");
        gender = Convert.ToChar(Console.ReadLine());

        switch (gender)
        {
            case 'M':
            case 'm':
                Console.WriteLine($"{firstName} you are Male");
                break;
            case 'F':
            case 'f':
                Console.WriteLine($"{firstName} you are Female");
                break;
            case 'O':
            case 'o':
                Console.WriteLine($"{firstName} you are Other");
                break;

            default:
                Console.WriteLine($"{firstName}, please enter out of the choices selected");
                break;
        }
        string userInput = Console.ReadLine();
        List<string> my_list = new List<string>();

        my_list.Add("Are you enjoying your visit?");
        my_list.Add(userInput);
        my_list.Add("Are You currently feeling pain?");
        my_list.Add(userInput);
        my_list.Add("In the past few months have you been out of the country?");
        my_list.Add(userInput);
        my_list.Add("Have you been having fever like symptoms?");
        my_list.Add(userInput);
        my_list.Add("Have you tested for covid-19 in the past 2-4 weeks?");
        my_list.Add(userInput);
        my_list.Add("Are you physically active?");
        my_list.Add(userInput);
        my_list.Add("Do you smoke?");
        my_list.Add(userInput);
        my_list.Add("Do you drink alcohol?");
        my_list.Add(userInput);
        my_list.Add("Have you been consuming drugs?");
        my_list.Add(userInput);
        my_list.Add("Do you have any allergins?");
        my_list.Add(userInput);

        foreach (string a in my_list)
        {
            Console.WriteLine(a);
        }

    }// end of main code.
    /// <summary>
    /// Leaving title for the final
    /// </summary>
    /// <param name="section"></param>
    static void SectionSeparator(string section)
    {
        Console.WriteLine("".PadRight(110, '*') +
            $"\n\t\t{section} \n"
            + "".PadRight(110, '*'));
    }

    // grabbing patients Birth Year
    static int AgeCalculator(int year)
    {

        if (year <= 1900)
        {

            Console.WriteLine("Please choose a realistic year.");
        }
        if (year >= 2010)
        {

            Console.WriteLine("You know that's impossible.");
        }
        return DateTime.Now.Year - year;
    }


}
