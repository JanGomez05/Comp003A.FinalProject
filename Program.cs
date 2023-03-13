/*
 * Author: Jan Gomez
 * Purpose: Final Assignment
 * Course: Comp003A L01
 * 
 */
using System.Reflection;

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

        Console.WriteLine($" So you are {firstName} {lastName}");

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


        List<string> response = new List<string>();

        List<string> my_list = new List<string>();

        my_list.Add("Are you enjoying your visit?");

        my_list.Add("Are You currently feeling pain?");

        my_list.Add("In the past few months have you been out of the country?");

        my_list.Add("Have you been having fever like symptoms?");

        my_list.Add("Have you tested for covid-19 in the past 2-4 weeks?");

        my_list.Add("Are you physically active?");

        my_list.Add("Do you smoke?");

        my_list.Add("Do you drink alcohol?");

        my_list.Add("Have you been consuming drugs?");

        my_list.Add("Do you have any allergins?");


        foreach (string a in my_list)
        {

            Console.WriteLine(a);
            string answer = Console.ReadLine();
            response.Add(answer);

        }


    }// end of main code.
    /// <summary>
    /// Leaving title for the final
    /// </summary>
    /// <param name="section"></param>
    static void SectionSeparator(string section)
    {
        Console.WriteLine("".PadRight(120, '*') +
            $"\n\t\t{section} \n"
            + "".PadRight(120, '*'));
    }

    // grabbing patients Birth Year
    static int AgeCalculator(int year)
    {
       
        if (year !<= 1900)
        {

            Console.WriteLine("Please choose a realistic year.");
        }
        else if (year !>= 2010)
        {
            Console.WriteLine("You know that's impossible.");
        }
        else
        {

        }
        return DateTime.Now.Year - year;
    }

}
