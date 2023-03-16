/*
 * Author: Jan Gomez
 * Purpose: Final Assignment
 * Course: Comp003A L01
 * 
 */
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace finalproject_from_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // theme would be for health patient.
            SectionSeparator("Welcome to Hanfords Clinic!" +
             " Here is a Registry for new Patients." +
             " Please Answer and Label the inquiery.");

            Console.WriteLine("Enter a first name");
            string firstName = Run(Console.ReadLine());

            Console.WriteLine("Please enter yout Last Name");
            string lastName = Run(Console.ReadLine());

            Console.WriteLine($"So you are {firstName} {lastName}");
            // now we are onto the age.
            bool isValid = false;
            int year = 0;
            do
            {
                Console.WriteLine("When were you born?");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual integer");
                    continue;
                }
                if (year <= 1900 || year >= 2010)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    Console.WriteLine(AgeCalculator(year));
                }

            } while (year <= 1900 || year >= 2010);
            // now we are onto the gender
            Console.WriteLine("Pease insert your gender as M , F or O:");
            char gender = Convert.ToChar(Console.ReadLine().ToLowerInvariant());
            retry:
                switch (gender)
                {
                    case 'm':
                        Console.WriteLine($"{firstName} {lastName} you are Male and are {AgeCalculator(year)} " +
                            $"years old");
                        break;
                    case 'f':
                    Console.WriteLine($"{firstName} {lastName} you are Female and are {AgeCalculator(year)} " +
                        $"years old");
                    break;
                    case 'o':
                    Console.WriteLine($"{firstName} {lastName} you are Other and are {AgeCalculator(year)} " +
                        $"years old");
                    break;
                    default:
                        Console.WriteLine($"{firstName}, please enter out of the choices selected");
                        gender = Convert.ToChar(Console.ReadLine().ToLowerInvariant());
                    goto retry;
                        break;
                }
            

            // Now we are onto the list and responses.
            List<string> responses = new List<string>();

            List<string> question = new List<string>();

            question.Add("Are you enjoying your visit?");

            question.Add("Are You currently feeling pain?");

            question.Add("In the past few months have you been out of the country?");

            question.Add("Have you been having fever like symptoms?");

            question.Add("Have you tested for covid-19 in the past 2-4 weeks?");

            question.Add("Are you physically active?");

            question.Add("Do you smoke?");

            question.Add("Do you drink alcohol?");

            question.Add("Have you been consuming drugs?");

            question.Add("Do you have any allergins?");

            // that way it wont allow empty or null responses.
            foreach (string a in question)
            {

                Console.WriteLine(a);
                string answer = Run(Console.ReadLine());
                responses.Add(answer);

            }
           // printing out question and responses
            for (int i =0;i<question.Count; i++)
            {
                Console.WriteLine("These were your questions.");
                Console.WriteLine(question[i]);
                Console.WriteLine(responses[i]);
            }


        }// end of main code.

        /// <summary>
        /// Leaving title for the final
        /// </summary>
        /// <param name="section"></param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(130, '*') +
                $"\n\t\t{section} \n"
                + "".PadRight(130, '*'));
        }
        /// <summary>
        /// Removing null or empty including special characters
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string Run(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid Input");
                name = Run(Console.ReadLine());
                return name;
            }
            // Make own character set
            Regex regex = new Regex("[@_!#$%^&*()<>?/|}{~: 0-9]");
            // Pass the string in regex.IsMatch
            // method
            if (!regex.IsMatch(name))
            {
                Console.WriteLine("Thank you for answering.");
                return name;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again.");
                name = Run(Console.ReadLine());
                return name;
            }
        }

        /// <summary>
        /// grabbing patients Birth Year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }

    }
}
