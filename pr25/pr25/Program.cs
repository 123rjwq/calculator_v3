using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace NumberConversionProgram
{
    class Program
    {
        // Функция для перевода числа в указанную систему счисления
        static string ToBase(int num, int baseValue)
        {
            if (num == 0)
                return "0";

            string result = "";
            while (num > 0)
            {
                int remainder = num % baseValue;  // Определяем остаток от деления
                result = remainder.ToString() + result;  // Добавляем остаток в начало результата
                num = num / baseValue;  // Делаем целочисленное деление для получения следующей цифры
            }

            return result;
        }

        // Функция для перевода числа из указанной системы счисления в десятичную систему счисления
        static int FromBase(string num, int baseValue)
        {
            int result = 0;
            int power = 0;

            // Перебираем цифры в строке num справа налево
            for (int i = num.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(num[i].ToString());  // Преобразуем символ в цифру
                result += digit * (int)Math.Pow(baseValue, power);  // Добавляем вклад данной цифры в результат
                power++;  // Увеличиваем степень
            }

            return result;
        }

        // Функция для генерации случайного числа в указанной системе счисления
        static int GenerateRandomNumber(int baseValue)
        {
            int maxValue = (int)Math.Pow(baseValue, 4) - 1;  // генерируем 4-ух значное число
            Random random = new Random();
            return random.Next(0, maxValue + 1);  // Генерируем случайное число в диапазоне от 0 до maxValue
        }

        // Функция для формирования формулы перевода числа из одной системы счисления в другую
        static string ConversionFormula(int num, int base1, int base2)
        {
            return $"{num} в системе счисления {base1} равно {ToBase(num, base2)} в системе счисления {base2}";
        }

        static void Main(string[] args)
        {
            bool isValid  = false;
            int baseValue = 0;
            while (!isValid) {
                // Запрашиваем у пользователя число, которое означает систему счисления
                Console.Write("Введите число - систему счисления: ");


                
                isValid = int.TryParse(Console.ReadLine(), out baseValue);

                if (isValid)
                {
                    isValid = true;
                }
                else
                {
                    // Выводим сообщение об ошибке неверного ввода
                    Console.WriteLine("Неверный ввод, пожалуйста, введите число.");
                }
            }
            // Генерируем случайное число в указанной системе счисления
            int randomNum = GenerateRandomNumber(baseValue);
            Console.WriteLine($"Случайное число в системе счисления {baseValue}: {ToBase(randomNum, baseValue)}");

            // Запрашиваем у пользователя список систем счисления, в которые нужно перевести число
            Console.Write("Введите системы счисления через пробел, в которые нужно перевести число: ");
            string[] convertBases = Console.ReadLine().Split(' ');
            foreach (string convertBase in convertBases)
            {
                int convertBaseValue = int.Parse(convertBase);

                // Запрашиваем у пользователя перевод числа
                Console.Write($"Введите число {ToBase(randomNum, baseValue)} в системе счисления {convertBaseValue}: ");
                int userNum = int.Parse(Console.ReadLine());
                
                if (userNum == int.Parse(ToBase(randomNum, baseValue)))
                {
                    Console.WriteLine("Поздравляю! Вы верно перевели число.");
                    continue;
                }

                if (userNum != FromBase(ToBase(randomNum, baseValue), convertBaseValue))
                {

                    // Выводим формулу перевода числа и просим ввести число снова
                    Console.WriteLine($"Неверный ответ. Формула перевода: Переводим 1235 в десятичную систему счисления:\r\n\r\n1235 = 1·52 + 2·51 + 3·50 = 3810\r\nПереводим целую часть 3810 в 7-ую систему последовательным делением на 7:\r\n\r\n1) 38/7 = 5, целое число 35, остаток: 3\r\n2) 5/7 = 0, целое число 0, остаток: 5\r\n3810 = 537 ");
                   
                }

                Console.WriteLine("Попробуйте еще раз.");

                // Запрашиваем перевод числа еще раз
                Console.Write($"Введите число {ToBase(randomNum, baseValue)} в системе счисления {convertBaseValue}: ");
                userNum = int.Parse(Console.ReadLine());

                if (userNum != randomNum)
                {
                    // Выводим формулу перевода числа, правильный ответ и сообщение о неверном переводе
                    Console.WriteLine($"Неверно второй раз.");
                    Console.WriteLine($"Верный ответ: {ToBase(randomNum, baseValue)}");
                }
                else
                {
                    Console.WriteLine("Поздравляю! Вы верно перевели число.");
                }
            }
        }
    }
}

