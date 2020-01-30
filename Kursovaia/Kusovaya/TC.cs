using System;

namespace Kursovaia
{
    class TC
    {
        private string Number_TC;
        private string Brand_TC;
        private string Model_TC;
        private string Color_TC;

        public TC()
        {
            Console.WriteLine("Введите ГОС номер ТС: ");
            do
            {
                Number_TC = Console.ReadLine();
                if (String.IsNullOrEmpty(Number_TC))
                {
                    Console.WriteLine("ГОС номер ТС не указан, введите повторно:");
                }
            } while (String.IsNullOrEmpty(Number_TC));

            Console.WriteLine("Введите марку ТС: ");
            do
            {
                Brand_TC = Console.ReadLine();
                if (String.IsNullOrEmpty(Brand_TC))
                {
                    Console.WriteLine("Марка ТС не указана, повторите ввод:");
                }
            } while (String.IsNullOrEmpty(Brand_TC));

            Console.WriteLine("Введите модель ТС: ");
            do
            {
                Model_TC = Console.ReadLine();
                if (String.IsNullOrEmpty(Model_TC))
                {
                    Console.WriteLine("Модель ТС не указана, повторите ввод:");
                }
            } while (String.IsNullOrEmpty(Model_TC));

            Console.WriteLine("Введите цвет ТС: ");
            do
            {
                Color_TC = Console.ReadLine();
                if (String.IsNullOrEmpty(Color_TC))
                {
                    Console.WriteLine("Цвет ТС не указан, повторите ввод:");
                }
            } while (String.IsNullOrEmpty(Color_TC));
        }
        public void print_Info_TC()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"ГОС номер ТС: {Number_TC} \n Марка ТС: {Brand_TC} \n Модель ТС: {Model_TC} \n Цвет ТС: {Color_TC}");
            Console.WriteLine("===============================================");
        }

        public string getNumber_TC()
        {
            return Number_TC;
        }

        public string getBrand_TC()
        {
            return Brand_TC;
        }

        public string getModel_TC()
        {
            return Model_TC;
        }
        public string getColor_TC()
        {
            return Color_TC;
        }
    }
}
