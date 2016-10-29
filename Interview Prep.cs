
//InterviewPrep.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace InterviewPrep
{
    public class Program
    {
        public static void Main(string[] args)
      {
	//Random password generator 1.0 using ascii values of a-z

             var random = new Random();
             const int passwordLength = 10;
             var buffer = new char[passwordLength];

             for (var i = 0; i < passwordLength; i++)
             {
                buffer[i] = (char)('a' + random.Next(0,26));
             }

             var password = new string(buffer);
             Console.WriteLine(password);

//—————————————————————————————————————————————————————————————————————————————————————————————————————————
	//password builder 2.0 version with a character bank to choose from a-z, A-Z, 0-9

            var passwordLength2 = 10;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder password2 = new StringBuilder();
            Random rand = new Random();
            while (0 < passwordLength2--)
            {
                password2.Append(valid[rand.Next(valid.Length)]);
            }
            Console.WriteLine(password2.ToString());





//—————————————————————————————————————————————————————————————————————————————————————————————————————————


         string myString = "Derek Allred";
         string reversed = reverse(myString);
         Console.WriteLine(reversed);
         string temp2 = "";
         foreach (string s in reversed.Split(' '))
         {
            temp2 += reverse(s) + ' ';
         }
         Console.WriteLine(temp2);


//—————————————————————————————————————————————————————————————————————————————————————————————————————————


         for(int i = 1; i <= 100;i++)
         {
             bool fizz = i%3==0;
             bool buzz = i%5==0;
             if(fizz && buzz)
             {
                 Console.WriteLine("FizzBuzz");
             }
             else if(fizz)
             {
                 Console.WriteLine("Fizz");
             }
             else if(buzz)
             {
                 Console.WriteLine("Buzz");
             }
             else
             {
                 Console.WriteLine(i);
             }
         }
      }


//—————————————————————————————————————————————————————————————————————————————————————————————————————————


        private static string reverse(string myString)
        {

         char[] chars = myString.ToCharArray();
         int j = chars.Length -1;
         for(int i = 0;i<j; i++)
         {
             char temp = chars[i];
             chars[i] = chars[j];
             chars[j] = temp;
             j--;
         }
         return new String(chars);
        }
    }
}
