using System;
using System.Collections.Generic;
namespace Kursovaia
{
    class Owner
    {

        public string FIO;
        public string address_of_registration;
        public string Owners_phone;
        public string Passport_details_of_owner;
        public string Drivers_license;
        public DateTime Date_of_issue_DL;
        public string Driver_category;
        public List<TC> tcs;
        public List<Violation> violations;

        public Owner()
        {
            Input_Data();
            print_Info_Owner();
            Console.WriteLine("информация о ТС :");
            sozd_TC();
            print_TC();
            Console.WriteLine("информация о нарушениях :");
            sozd_Violation();
            print_Info_Owner();
            print_TC();
            print_Violation();
        }
        void Input_Data()
        {
            Console.WriteLine("Введите ФИО владельца: ");
            do
            {
                FIO = Console.ReadLine();
                if (String.IsNullOrEmpty(FIO))
                {
                    Console.WriteLine("ФИО не указано, введите повторно:");
                }
            } while (String.IsNullOrEmpty(FIO));

            Console.WriteLine("Введите адресс регистрации владельца: ");
            do
            {
                address_of_registration = Console.ReadLine();
                if (String.IsNullOrEmpty(address_of_registration))
                {
                    Console.WriteLine("Адресс регистрации владельца не указан, введите повторно:");
                }
            } while (String.IsNullOrEmpty(address_of_registration));

            Console.WriteLine("Введите телефон владельца: ");
            do
            {
                Owners_phone = Console.ReadLine();
                if (String.IsNullOrEmpty(Owners_phone))
                {
                    Console.WriteLine("Адресс телефон владельца не указан, введите повторно:");
                }
            } while (String.IsNullOrEmpty(Owners_phone));

            Console.WriteLine("Введите паспортные данные владельца: ");
            do
            {
                Passport_details_of_owner = Console.ReadLine();
                if (String.IsNullOrEmpty(Passport_details_of_owner))
                {
                    Console.WriteLine("Паспортные данные владельца не указаны, ведите повторно:");
                }
            } while (String.IsNullOrEmpty(Passport_details_of_owner));

            Console.WriteLine("Введите № водительского удостоверения: ");
            do
            {
                Drivers_license = Console.ReadLine();
                if (String.IsNullOrEmpty(Drivers_license))
                {
                    Console.WriteLine("№ водительского удостоверения не указан, ведите повторно:");
                }
            } while (String.IsNullOrEmpty(Drivers_license));



            int day = 0;
            int month = 0;
            int year = 0;
            Console.WriteLine("Введите день выдачи ВУ: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц выдачи ВУ: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выдачи ВУ");
            year = int.Parse(Console.ReadLine());
            Date_of_issue_DL = new DateTime(year, month, day);

            Console.WriteLine("Введите категорию водителя: ");
            do
            {
                Driver_category = Console.ReadLine();
                if (String.IsNullOrEmpty(Driver_category))
                {
                    Console.WriteLine("Категорию водителя не указана, ведите повторно:");
                }
            } while (String.IsNullOrEmpty(Driver_category));
        }

        public void sozd_TC()
        { 

        tcs = new List<TC>();
                tcs.Add(new TC());
         }

        public void sozd_Violation()
        {
            int answer = 0;
            violations = new List<Violation>();
            do
            {
                violations.Add(new Violation());
                Console.WriteLine("Ввести еще одну информацию о нарушении? 1 - да   2 - нет");
                answer = int.Parse(Console.ReadLine());
            } while (answer == 1);
        }
        public void print_TC()
        {
            int i = 0;
            foreach (var val in tcs)
            {
                tcs[i].print_Info_TC();
                i++;
            }
        }
        public void print_Violation()
        {
            int i = 0;
            foreach (var val in tcs)
            {
                violations[i].print_Info_Violation();
                i++;
            }
        }
        public void print_Info_Owner()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"ФИО владельца: {FIO} \n Адрес регистрации владельца: {address_of_registration} \n Телефон владельца: {Owners_phone} \n Паспортные данные владельца: {Passport_details_of_owner} \n Номер водительского удостоверения:{Drivers_license} \n Дата выдачи водительского удостоверения: {Date_of_issue_DL.ToShortDateString()} \n Категория водителя: {Driver_category}");
            Console.WriteLine("===============================================");
        }
    }
}