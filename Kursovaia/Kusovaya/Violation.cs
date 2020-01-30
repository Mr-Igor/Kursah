using System;

namespace Kursovaia
{
    class Violation
    {
        private DateTime Date_violation;
        private string Place_violation;
        private string Camera_number;
        private string Type_violation;
        private float Amount_penalty;

        public Violation()
        {
            int day = 0;
            int month = 0;
            int hour = 0;
            int min = 0;
            Console.WriteLine("Введите день нарушения: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц нарушения: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите час нарушения: ");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуту нарушения: ");
            min = int.Parse(Console.ReadLine());

            Date_violation = new DateTime(2019, month, day, hour, min, 00);

            Console.WriteLine("Введите место нарушения: ");
            do
            {
                Place_violation = Console.ReadLine();
                if (String.IsNullOrEmpty(Place_violation))
                {
                    Console.WriteLine("Место нарушения не указано, введите повторно:");
                }
            } while (String.IsNullOrEmpty(Place_violation));

            Console.WriteLine("Введите № камеры: ");
            do
            {
                Camera_number = Console.ReadLine();
                if (String.IsNullOrEmpty(Camera_number))
                {
                    Console.WriteLine("№ камеры не указан, введите повторно:");
                }
            } while (String.IsNullOrEmpty(Camera_number));

            Console.WriteLine("Введите вид нарушения: ");
            do
            {
                Type_violation = Console.ReadLine();
                if (String.IsNullOrEmpty(Type_violation))
                {
                    Console.WriteLine("Вид нарушения не указан, введите повторно:");
                }
            } while (String.IsNullOrEmpty(Type_violation));

            Console.WriteLine("Введите сумму штрафа: ");
            do
            {
                Amount_penalty = float.Parse(Console.ReadLine());
                if (Amount_penalty <= 0)
                {
                    Console.WriteLine("Сумма штрафа не может быть < 1, введите повторно:");
                }
            } while (Amount_penalty <= 0);
        }
        public void print_Info_Violation()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Дата нарушения: {Date_violation} \n Место нарушения: {Place_violation} \n Номер камеры: {Camera_number} \n Вид нарушения: {Type_violation} \n Сумма штрафа:{Amount_penalty}");
            Console.WriteLine("===============================================");
        }

        public DateTime getDate_violation()
        {
            return Date_violation;
        }

        public string getPlace_violation()
        {
            return Place_violation;
        }

        public string getCamera_number()
        {
            return Camera_number;
        }

        public string getType_violation()
        {
            return Type_violation;
        }
        public float getAmount_penalty()
        {
            return Amount_penalty;
        }
    }
}
