using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Посмотри на календарь недели");
            Console.WriteLine("Введи какой сегодня день недели в цифрах");
            int number_of_elements;
            string input_value = Console.ReadLine();
            bool check = int.TryParse(input_value,out number_of_elements);
            if (check)
            {
                int day = number_of_elements;
                                if (day > 5 && day < 8)
                {
                    Console.WriteLine("Сегодня выходной");
                    Console.WriteLine("Тебе нужно одеться для похода в бар");
                    Console.WriteLine("Иди в бар");
                    Console.WriteLine("введи количество деньг, которые ты готов потратить на колу");

                    int money = Convert.ToInt32(Console.ReadLine());
                    for (int i = money; i >= 100; i = i - 100)
                    {
                        Console.WriteLine("Можно позволить купить себе колу, у тебя сейчас денег в кошельке =" + money);
                        money = money - 100;

                        Console.WriteLine("Осталось денег после токого как ты только что купил колу" + money);
                    }
                    Console.WriteLine("ты не можешь купить себе колу,денег<100");
                }
                else if (day > 0 && day <= 5)
                {
                    Console.WriteLine("Сегодня будний день");
                }
                else
                {
                    Console.WriteLine("Такого дня недели  в цифрах не бывает");
                }
            }
            else 
            {
                Console.WriteLine("вы ввели не число");
            }
            Console.WriteLine("Конец, нажми что-нибудь");
            Console.ReadKey();
        }
    }
}
