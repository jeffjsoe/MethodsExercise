
using System.Drawing;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

           

            Story();

            //Here we called the add num method 
            var sum = addNum(2, 4);
            //Now since we called it, it is now passed into the variable suma nd all we gave to do to print it 
            Console.WriteLine(sum);

            //Make sure to declate rhte variable
            var product = multiply(10, 2);
            Console.WriteLine(product);

            var difference = diff(10, 2);
            Console.Write(difference);

            var division = div(10, 2);
            Console.WriteLine(division);
        }
        //Create the method-tell it what it willl do 
        //Be specific for the type of paramter we will be creating.
         public static int addNum(int Sum1,int Sum2)
        {
            //Here it received the call and stores it in the parameters and then performed the function and now returned it to where it got called
            return Sum1+Sum2;


        }


        public static int multiply(int num1, int num2)
        {
            //Here once this method is caleld it will perofrm the function inside this method

            return num1 * num2;


        }

        public static int diff(int number1, int number2)
        {


            return number1 - number2;

        }
                                public static int div(int nume1, int nume2)
        {
            //THIS is where we will tell what we would do in the code.
            return nume1 / nume2;



        }
        public static void Story()
        {
            Console.WriteLine("What is your name");
            //What happens here is that console asks the name. THen it lets the user input that answer into Console.ReadLine, Then it stores that in the name variable. 
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            String Animal = Console.ReadLine();
            Console.WriteLine("What is your favorite Band");
            String Band = Console.ReadLine();
            Console.WriteLine($"Hey guys!, my name is {name} and my favorite color is {color}. One day I took my {Animal} out and I realized he was in this band called {Band} lolll");

        }
    }
}