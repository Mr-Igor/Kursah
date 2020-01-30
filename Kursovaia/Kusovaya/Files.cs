using System;
using System.IO;
namespace Kursovaia
{
    class Files
    {
        public string dir;
        public DirectoryInfo directory;
        public void createDirectory()
        {
            dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            directory = Directory.CreateDirectory("DIRECTORY");
        }
        public void cleanDirectory()
        {
            foreach (DirectoryInfo d in directory.GetDirectories())
            {
                cleanFiles(d);
                d.Delete();
            }
        }
        public void cleanFiles(DirectoryInfo dir)
        {
            foreach (FileInfo f in dir.GetFiles())
            {
                f.Delete();
            }
        }
        public void fileWriterOwner(string filePath, Owner Owner)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"ФИО владельца: {Owner.FIO}");
            sw.WriteLine($"Адрес регистрации владельца: {Owner.address_of_registration}");
            sw.WriteLine($"Телефон владельца: {Owner.Owners_phone}");
            sw.WriteLine($"Паспортные данные владельца: {Owner.Passport_details_of_owner}");
            sw.WriteLine($"Номер водительского удостоверения: {Owner.Drivers_license}");
            sw.WriteLine($"Дата выдачи водительского удостоверения: {Owner.Date_of_issue_DL}");
            sw.WriteLine($"Категория водителя: {Owner.Driver_category}");
            sw.Close();
        }
        public void fileWriterTC(string filePath, TC TC)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"ГОС номер тс: {TC.getNumber_TC()}");
            sw.WriteLine($"Марка тс: {TC.getBrand_TC()}");
            sw.WriteLine($"Модель тс: {TC.getModel_TC()}");
            sw.WriteLine($"Цвет тс: {TC.getColor_TC()}");
            sw.Close();
        }
        public void fileWriterViolation(string filePath, Violation Violation)
        {
            StreamWriter sw = new StreamWriter("DIRECTORY\\" + filePath + ".txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine($"Дата нарушения: {Violation.getDate_violation()}");
            sw.WriteLine($"Место нарушения: {Violation.getPlace_violation()}");
            sw.WriteLine($"Номер камеры: {Violation.getCamera_number()}");
            sw.WriteLine($"Вид нарушения: {Violation.getType_violation()}");
            sw.WriteLine($"Сумма штрафа: {Violation.getAmount_penalty()}");
            sw.Close();
        }

        public void fileReaderOwner(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        public void fileReaderTC(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        public void fileReaderViolation(string filePath)
        {
            StreamReader sr = new StreamReader("DIRECTORY\\" + filePath + ".txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
