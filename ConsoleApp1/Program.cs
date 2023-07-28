using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int targetNumber = random.Next(1, 101);

                Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Hadi tahmin et!");

                while (true)
                {
                    Console.Write("Tahmininizi girin: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int guess))
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                        continue;
                    }

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Lütfen 1 ile 100 arasında bir sayı girin.");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Daha düşük bir sayı tahmin edin.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler! Doğru sayıyı tahmin ettiniz.");
                        break; // Doğru cevabı bulduk, içteki döngüyü sonlandırın.
                    }
                }

                Console.Write("Yeniden oynamak istiyor musunuz? (E/H): ");
                string playAgainInput = Console.ReadLine().Trim().ToLower();

                if (playAgainInput != "e")
                {
                    break; // Dıştaki döngüyü sonlandırın ve oyunu kapatın.
                }
            }

            Console.WriteLine("Oyun bitti. İyi günler!");
        }
    }
}
