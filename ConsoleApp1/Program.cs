using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BANK 
    {

        public string HolderName { get; set; }
        public string HolderSurname { get; set; }
        public string CompanyName { get; set; }
        public string Code { get; set; }
        public string CVV { get; set; }
        
        public decimal Balance { get; set; }

        public void WithDraw(decimal amount) 
        {
            if (amount <= 0) return;
            if (amount >Balance) return;
            Balance -= amount;
            

           
        }


        public void Deposit (decimal amount) 
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            
            }


        static void Main(string[] args)

        {
            var card = new BANK();

            card.HolderName = "Senan";
            card.HolderSurname = "Orucov";
            card.CompanyName = "ABB";
            card.Code = "0987654321";
            card.CVV = "996";
            card.Balance = 0.8m;



            card.WithDraw(50);
            Console.WriteLine(card.Balance);

            card.Deposit(20);
            Console.WriteLine(card.Balance);



            //Console.WriteLine($"Holder Name -{card.HolderName}");
            //Console.WriteLine($"Holder Surname -{card.HolderSurname}");
            //Console.WriteLine($"Company Name - {card.CompanyName}");
            //Console.WriteLine(card.Code);
            //Console.WriteLine(card.CVV);
            //Console.WriteLine(card.Balance);



























            //int a = 5; 

            //var result  = Number(a);  // a nın yerine reqem de yazmaq olmar 
            //Console.WriteLine(result);



            //string name = "senan";
            //string surname = "Orujov";

            //Console.WriteLine($"{name} ve {surname} ");

            //Console.WriteLine(name + " " + surname); 100 den kicik dirse ustune 1 gel 

            //int a = 1;
            //int number = 106;
            //if (number < 100) 
            //{
            //    Console.WriteLine(number + a);

            //}
            //else
            //{

            //Console.WriteLine(number - a);  0 dan kicik hemen ozw boywkdwrse 

            //int number = 5;
            //if (number < 0)
            //{
            //    Console.WriteLine(number);
            //}
            //else if (number > 0 && number < 10)
            //{
            //    number++;
            //    Console.WriteLine(number);
            //}
            //else if (number > 10)
            //{
            //    number--;
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("SAĞOL");
            //}




            //Random randomnum = new Random();

            //int randomNumber = randomnum.Next(1, 101);

            //Console.WriteLine("random " + randomNumber);
            //Console.ReadLine();


            //int age = 15;

            //if  (10 < age < 15) {  
            //Console.WriteLine("as")};   olmurmuş 

            //int number = -7;
            //if (number < 0)

            //{
            //    number = -number;
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Number is even");
            //    }
            //    else { Console.WriteLine("Number is odd"); }


            //}

            //else
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine("Number is even");

            //    }

            //    else { Console.WriteLine("Number is odd"); }
            //}


            //int weekDays =0;

            //if (weekDays == 1) 
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (weekDays ==2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (weekDays == 3)
            //{
            //    Console.WriteLine("Wednesday");


            //}
            //else if (weekDays == 4)
            //{
            //    Console.WriteLine("Thursday");

            //}
            //else if (weekDays == 5)
            //{
            //    Console.WriteLine("Friday");

            //}
            //else if (weekDays == 6)
            //{
            //    Console.WriteLine("Saturday");

            //}
            //else if (weekDays == 7)
            //{
            //    Console.WriteLine("Sunday");

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            //}




            //int number = -13;
            //int levelCount = 0;

            //while (number != 0 )
            //{

            //    int lastDigit = number % 10;
            //       number = (number - lastDigit) / 10;
            //    levelCount++;
            //}

            //Console.WriteLine($"  reqem {levelCount} mertebelidir ");




            //string word = "abdulla";
            //char charToFind = 'a';
            //int count = 0;

            //for (int index =0; index < word.Length; index++)
            //{
            //    if (word[index] == charToFind)
            //    {
            //        count++;
            //    }

            //}

            //if (count == 0)
            //{
            //    Console.WriteLine( "bu herf yoxdur ");
            //}


            //Console.WriteLine("Output: count=" + count);











            //string word1 = "agba";
            //string word2 = "agca";

            //if (word1.Length == word2.Length)
            //{
            //    for (int i = 0; i < word1.Length; i++)
            //    {
            //        for (int j = 0; j <= i; j++)
            //        {
            //           if( i == j )
            //            {
            //                word2=word2.Remove(j);
            //            }

            //        }


            //    }


            //}



            //string word1 = "lamp";
            //string word2 = "palm";
            //string word3 = "";

            //if (word1.Length == word2.Length)
            //{
            //    for (int i = 0; i < word1.Length; i++)
            //    {
            //        for (int j = 0; j < word2.Length; j++)
            //        {
            //            if (word1[i] == word2[j])
            //            {
            //                word3 += word1[i];
            //                word2 = word2.Remove(j, 1);
            //                break;
            //            }


            //        }
            //    }
            //    if (word3 == word1)
            //    {
            //        Console.WriteLine("true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("false");
            //    }

            //}

            //else
            //{
            //    Console.WriteLine("false");
            //}


            //string word = "azasza";

            //  for (int i = 0; i < word.Length; i += 2)
                     
            //{
            //    int j = word.Length - i - 1;
            //    if (word[i] != word[j])
            //    {
            //        Console.WriteLine("notas pandirom");
            //        break;
            //    }


            //}
            //Console.WriteLine("'palendrom");












        }
    }


}

