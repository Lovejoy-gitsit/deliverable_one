using System;


namespace mathchallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            var n1 = 0;
            var n2 = 0;
            var sum = 0;

            //keeps program returning to the beginning w/o closing
            while (true)
            {
                //asking for user input
                Console.WriteLine("Enter a number:  ");
                //printing user input and converting user input from string to int
                n1 = Convert.ToInt32(Console.ReadLine());

                //asking for user input
                Console.WriteLine("Enter a number: ");
                //printing user input and converting user input from string to int
                n2 = Convert.ToInt32(Console.ReadLine());

                //getting the sum of user input
                sum = n1 + n2;
                //printing the sum
                Console.WriteLine("sum: " + sum);

                //making the sum a string and setting index to 0
                var first = sum.ToString()[0];
                //declaring variable allMatching
                var allMatching = true;
                //tells program to continue getting sum of digits by going to next digit in line
                for (int anything = 0; anything < sum.ToString().Length; anything++)
                {
                    //when the sum of the numbers are not equal break from loop
                    if (sum.ToString()[anything] != first)
                    {
                        allMatching = false;
                        break;
                    }
                }
                    //if sum of all digits match print true
                    if (allMatching)
                    {
                    Console.WriteLine("True");
                    }

                else
                {
                    //if sum of all digits does not match print false
                    Console.WriteLine("False");
                    Console.ReadLine();
                }
               

                
            }
                



           

           



         

            
            

        }
    }
}
