using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int number;
            //do 
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(),out  number));
            //if (number%3==0&& number % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No"); 
            #endregion

            #region Q2
            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //if (number >= 0)
            //    Console.WriteLine("Positive");
            //else
            //    Console.WriteLine("Negative"); 
            #endregion

            #region Q3
            //int[] numbers = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter the number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int max = 0, min = numbers[0];
            //for (int i = 0;i < numbers.Length;i++)
            //{
            //    if (numbers[i] > max) max = numbers[i];
            //    if (numbers[i] < min) min = numbers[i];
            //}
            //////int max = numbers.Max();
            //////int min = numbers.Min();

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);
            #endregion

            #region Q4
            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //if (number % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd"); 
            #endregion

            #region Q5
            //Console.Write("Enter the character: ");
            //char character = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //switch (character)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'o':
            //    case 'u':
            //    case 'i':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //} 
            #endregion

            #region Q6
            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region Q7
            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{number * i} ");
            //} 
            #endregion

            #region Q8
            //int number;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //} 
            #endregion

            #region Q9

            //int number, power;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //do
            //{
            //    Console.Write("Enter the power: ");
            //} while (!int.TryParse(Console.ReadLine(), out power));

            //int result = 1;
            //for (int i = 0; i < power; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine($"Result = {result}"); 
            #endregion

            #region Q10
            //int[] numbers = new int[5];
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter the Mark {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Total Marks = {sum}");
            //Console.WriteLine($"Average Marks = {sum / numbers.Length}");
            //Console.WriteLine($"Percentage = {sum / 500}"); 
            #endregion

            #region Q11
            //int month;
            //do
            //{
            //    Console.Write("Enter the number: ");
            //} while (!int.TryParse(Console.ReadLine(), out month));

            //switch (month)
            //{
            //    case 2:
            //        Console.WriteLine(29);
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine(30);
            //        break;
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 12:
            //        Console.WriteLine(31);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //} 
            #endregion

            #region Q12

            //int number1, number2;
            //do
            //{
            //    Console.Write("Enter the number1: ");
            //} while (!int.TryParse(Console.ReadLine(), out number1));

            //Console.Write("Enter the oprator(+ , - , * , /): ");
            //char ope = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //do
            //{
            //    Console.Write("Enter the number2: ");
            //} while (!int.TryParse(Console.ReadLine(), out number2));

            //switch (ope)
            //{
            //    case '+':
            //        Console.WriteLine(number1 + number2);
            //        break;
            //    case '-':
            //        Console.WriteLine(number1 - number2);
            //        break;
            //    case '*':
            //        Console.WriteLine(number1 * number2);
            //        break;
            //    case '/':
            //        Console.WriteLine(number1 / number2);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //} 
            #endregion

            #region Q13
            //Console.Write("Enter String: ");
            //string result = Console.ReadLine();

            //StringBuilder reverse = new StringBuilder();

            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    reverse.Append(result[i]);
            //}
            //Console.WriteLine(reverse);
            #endregion

            #region Q14
            //Console.Write("Enter String: ");
            //string result = Console.ReadLine();

            //StringBuilder reverse = new StringBuilder();

            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    reverse.Append(result[i]);
            //}
            //Console.WriteLine(reverse); 
            #endregion

            //Q15

            #region Q16
            //int number;
            //do
            //{
            //    Console.Write("Enter ending number of range: ");
            //} while (!int.TryParse(Console.ReadLine(), out number) && number < 0);

            //string binary = "";
            //while(number != 0)
            //{
            //    binary = (number % 2) + binary;
            //    number /= 2;
            //}
            //Console.WriteLine(binary); 
            #endregion

            #region Q17
            //Console.WriteLine("Enter the First point(x1,y1):");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the First point(x2,y2):");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the First point(x3,y3):");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //bool checkArea = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2 == 0;
            //if (checkArea)
            //    Console.WriteLine("On a single line");
            //else
            //    Console.WriteLine("not on a single line"); 
            #endregion

            #region Q18

            //Console.Write("Enter the time: ");
            //int time = int.Parse(Console.ReadLine());

            //if (time >= 2 && time <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (time > 3 && time <= 4)
            //{
            //    Console.WriteLine("The worker should increase their speed.");
            //}
            //else if (time > 4 && time <= 5)
            //{
            //    Console.WriteLine("The worker needs training to improve speed.");
            //}
            //else if (time > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
            //} 
            #endregion
        }
    }
}
