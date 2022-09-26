using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringFullName = "ФИО:", stringAge = "Возраст:", stringEmail = "Email:",
                stringScores = "Баллы за экзамены:", stringProgramming = "- программирование:", stringMaths = "- математика:", stringPhysics = "- физика:";

            string fullName0 = "Федор Борисович Иванов", fullName1 = "Алла Сергеевна Рыбкина";
            byte age0 = 18, age1 = 17;
            string email0 = "FBI@rambler.ru", email1 = "best_alla@list.ru";
            double programming0 = 87, programming1 = 95;
            double maths0 = 75 , maths1 = 83;
            double physics0 = 56, physics1 = 43;

            Console.WriteLine($"{stringFullName, 20}{fullName0, 25}{fullName1,25}");
            Console.WriteLine($"{stringAge,20}{age0,25}{age1,25}");
            Console.WriteLine($"{stringEmail,20}{email0,25}{email1,25}");
            Console.WriteLine($"{stringScores,20}");
            Console.WriteLine($"{stringProgramming,19}{programming0,26}{programming1,25}");
            Console.WriteLine($"{stringMaths,13}{maths0,32}{maths1,25}");
            Console.WriteLine($"{stringPhysics,9}{physics0,36}{physics1,25}");

            //\nВозраст: {age, 5} \nEmail: {email, 5} \nБаллы по программированию: {programming, 5} \nБаллы по математике {maths, 5} \nБаллы по физике {physics, 5}");
            Console.ReadKey(true);




        }
    }
}
