using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region string format
            //string format
            //int x = 4, y = 5;

            //1.string concatination
            //string message = "Equation : " + x + " + " + y + " = " + (x + y);
            //Console.WriteLine(message);
            //string datatype
            //Immutable datatype: can't change it's value after creating
            //  create new object

            //2.string format
            //string message = string.Format("Equation: {0} + {1} = {2} ", x, y, (x + y));
            //Console.WriteLine(message);

            //3.string Interpolution
            //$ :manipulation operator
            //string message = $"Equation: {x} + {y} = {x + y}";
            //Console.WriteLine(message); 
            #endregion

            #region Control Statement
            //Control Statement
            //1. Conitional Control Statement (if statement, switch case)
            //2. loop Control Statement (for, foreach, while, do while) 
            #endregion

            #region Conitional Control Statement


            //1. Conitional Control Statement (if statement, switch case)
            //using if statement
            //if (/*Expression*/)
            //{
            //    //body
            //    //code
            //    //this code that will be execute when expression is true
            //}

            //using switch case
            //switch (/*Expression*/)
            //{
            //    case /*Value*/:
            //        //code
            //        break;
            //    default:
            //        //code
            //        break;
            //} 

            //Console.Write("Enter youjr age: ");
            //int age = int.Parse(Console.ReadLine());

            ///1.using if statement
            //if (age > 18)
            //{
            //    Console.WriteLine("Welcome");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("Bye Bye");
            //}
            //else
            //{
            //    Console.WriteLine("Equal");
            //}


            ///1.using switch case
            //switch (age)
            //{
            //    case > 18:
            //        Console.WriteLine("welcome");
            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye Bye");
            //        break;
            //    default:
            //        Console.WriteLine("Equal");
            //        break;
            // }


            #endregion

            #region switch c# 7.0
            //object obj = new object();
            //obj = "Abdelrahman";
            //obj = 6;

            //switch (obj)
            //{
            //    case int x when x > 5:
            //        Console.WriteLine("Int Value");
            //        break;
            //    case string x when x.Length > 6:
            //        Console.WriteLine("String value");
            //        break;
            //    default:
            //        break;
            //} 
            #endregion

            #region switch c# 8.0
            //Console.Write("Enter numbrt: ");
            //string input = Console.ReadLine();
            //string output = input switch
            //{
            //    "1" => "one",
            //    "2" => "two",
            //    "3" => "three",
            //    _ => "Invalid"
            //};
            //Console.WriteLine(output);
            //Console.WriteLine(input switch
            //{
            //    "1" => "one",
            //    "2" => "two",
            //    "3" => "three",
            //    _ => "Invalid"
            //});
            #endregion

            #region switch c# 9.0
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //string message = age switch
            //{
            //    int x when x > 18 => "Welcome",
            //    < 18 and > 0 => "bye bye",
            //    < 0 => "Invalid",
            //    _ => "Equal"
            //};
            //Console.WriteLine(message);
            #endregion

            #region loop Control Statement
            //2. loop Control Statement (for, foreach, while, do while)
            //for(/*statement*/ ; /*expression*/; /*statement*/ )
            //{
            //    //body
            //    //this code will be execute while expression is true
            //}

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //foreach (int i in arr) 
            //{
            //    Console.WriteLine(i);
            //}

            //do
            //{
            //    //body
            //    //this code will be execute while expression is true
            //    //note:
            //} while (/*Expression*/); 
            #endregion

            #region string
            //string : reference type
            //immmutable datatype: can't change value after creation
            string s01;
            // Declare Refernce From Type ' Point '
            // s01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will Be Allocated At Stack For The poinrer
            // 0 Bytes Will Be Allocated At Heap

            s01 = new string("Abdelrahman");
            s01 = "Abdelrahman";

            // new
            // 1. A1 locate The Number Of Required Bytes For The Object at Heap
            // 2. Initialized The Allocated Byte With The Defaul Value of The Datatype
            // 3. Call user-define Constructor if Exsits
            // 4. Assign The Object Address To The Reference 's01' 

            //string message = "Hello";
            //Console.WriteLine($"message: {message}");
            //Console.WriteLine($"message Hashcode: {message.GetHashCode()}");

            //message += "Abdelrahman";
            //Console.WriteLine($"message: {message}");
            //Console.WriteLine($"message Hashcode: {message.GetHashCode()}");

            #endregion

            #region string builder 

            //string builder : reference type
            //mutable datatype: can change value after cration

            // StringBuilder message;
            // Declare Refernce From Type ' Point '
            // s01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will Be Allocated At Stack For The poinrer
            // 0 Bytes Will Be Allocated At Heap
            // message = new StringBuilder("Hello");
            // new
            // 1. A1 locate The Number Of Required Bytes For The Object at Heap
            // 2. Initialized The Allocated Byte With The Defaul Value of The Datatype
            // 3. Call user-define Constructor if Exsits
            // 4. Assign The Object Address To The Reference 'message' 

            //Console.WriteLine($"message: {message}");
            //Console.WriteLine($"message Hashcode: {message.GetHashCode()}");

            //message.Append("Abdelrahman");
            //Console.WriteLine($"message: {message}");
            //Console.WriteLine($"message Hashcode: {message.GetHashCode()}"); 
            #endregion


        }
    }
}
