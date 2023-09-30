using System;

namespace hmw3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Відгадай загадку:");
            Console.Write($"Яке слово може бути прочитане як зверху вниз, так і знизу вгору?");
            Console.Write($"Варіанти відповіді: 1.Кіт 2. Шлях 3. Рівень 4. Мама");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Рівень":
                case "рівень":
                    Console.WriteLine($"Правильно");
                    break;

                case "Мама":
                case "Мама":
                    Console.WriteLine($"Ні.Правильна відповідь: Рівень ");
                    break;

                case "Шлях":
                case "шлях":
                    Console.WriteLine($"Ні.Правильна відповідь: Рівень ");
                    break;

                case "Кіт":
                case "кіт":
                    Console.WriteLine($"Ні.Правильна відповідь: Рівень ");
                    break;

                default:

                    Console.WriteLine("Варіанти відповіді для кого ?");

                    break;

            }
            Console.Write($"Відгадай загадку:");
            Console.Write($"Що завжди збільшується, коли його зменшують?");
            Console.Write($"Варіанти відповіді: 1.Час 2. Солнце 3. Апетит 4. Задача");
            string answer2 = Console.ReadLine();

            switch (answer2)
            {
                case "Апетит":
                case "апетит":
                    Console.WriteLine($"Правильно");
                    break;

                case "Солнце":
                case "солнце":
                    Console.WriteLine($"Ні.Правильна відповідь: Апетит");
                    break;

                case "Час":
                case "Час":
                    Console.WriteLine($"Ні.Правильна відповідь: Апетит ");
                    break;

                case "Задача":
                case "Задача":
                    Console.WriteLine($"Ні.Правильна відповідь: Апетит ");
                    break;

                default:

                    Console.WriteLine("Варіанти відповіді для кого ?");

                    break;
            }
            Console.Write($"Відгадай загадку:");
            Console.Write($"Що має ключ, але не відчиняє жодних дверей?");
            Console.Write($"Варіанти відповіді: 1.Час 2. Комп'ютер 3. Книга 4. Автомобіль");
            string answer3 = Console.ReadLine();

            switch (answer3)
            {
                case "Час":
                case "час":
                    Console.WriteLine($"Правильно");
                    break;

                case "Комп'ютер":
                case "комп'ютер":
                    Console.WriteLine($"Ні.Правильна відповідь:Час ");
                    break;

                case "Книга":
                case "книга":
                    Console.WriteLine($"Ні.Правильна відповідь: Час ");
                    break;

                case "Автомобіль":
                case "Автомобіль":
                    Console.WriteLine($"Ні.Правильна відповідь: Час ");
                    break;

                default:

                    Console.WriteLine("Варіанти відповіді для кого ?");

                    break;
            }
            Console.Write($"Відгадай загадку:");
            Console.Write($"Яка річ має завжди дно, але ніколи не має вершини?");
            Console.Write($"Варіанти відповіді: 1.Скриня 2. Річка 3. Картка 4. Відро");
            string answer4 = Console.ReadLine();

            switch (answer4)
            {
                case "Відро":
                case "час":
                    Console.WriteLine($"Правильно");
                    break;

                case "Комп'ютер":
                case "комп'ютер":
                    Console.WriteLine($"Ні.Правильна відповідь:Час ");
                    break;

                case "Книга":
                case "книга":
                    Console.WriteLine($"Ні.Правильна відповідь: Час ");
                    break;

                case "Автомобіль":
                case "Автомобіль":
                    Console.WriteLine($"Ні.Правильна відповідь: Час ");
                    break;

                default:

                    Console.WriteLine("Варіанти відповіді для кого ?");

                    break;
            }

        }
