using System;
using System.IO;
namespace Kursovaia
{
    class Program
    {
        static void Main(string[] args)
        {

            int count;
            int answer;
            int globalAnswer = 0;
            bool returnWhile = true;
            Files file = new Files();
            Console.WriteLine("---------------------------------------------------------------------------");
            while (returnWhile)
            {
                Console.WriteLine("Выбирете дальнейшее действие \n 1 - Считать данные из файла \n 2 - Записать новые данные ");
                globalAnswer = int.Parse(Console.ReadLine());
                switch (globalAnswer)
                {
                    case 1:

                        file.createDirectory();
                        readFile(file);
                        break;

                    case 2:
                        Console.WriteLine("Введите кол - во владельцев: ");
                        do
                        {
                            count = int.Parse(Console.ReadLine());
                            if (count <= 0)
                            {
                                Console.WriteLine("Введено неверное число, повторите ввод");
                            }
                        } while (count <= 0);

                        Owner[] owner = new Owner[count];
                        for (int i = 0; i < count; i++)
                        {
                            owner[i] = new Owner();
                            Console.WriteLine("----------------------------------------");
                        }
                        Console.WriteLine("Выберете дальнейшие действия \n 1 - Изменить введённые данные \n 2 - Добавить данные \n 3 - Удалить данные \n 4 - ПРОДОЛЖИТЬ ");
                        answer = int.Parse(Console.ReadLine());
                        do
                        {
                            switch (answer)
                            {

                                case 1:
                                    do
                                    {
                                        answer = ChangeInfo.changeInfo(owner);
                                    } while (answer != 0);
                                    break;

                                case 2:
                                    do
                                    {
                                        answer = ChangeInfo.AddInfo(owner);
                                    } while (answer != 0);
                                    break;

                                case 3:
                                    do
                                    {
                                        answer = ChangeInfo.DeleteInfo(owner);
                                    } while (answer != 0);
                                    break;
                            }
                        } while (answer == 0);

                        writeInFileOwner(count, owner, file);
                        break;
                    default:
                        returnWhile = false;
                        break;
                }
            }
        }
        static public void writeInFileOwner(int count, Owner[] owner, Files file)
        {
            file.createDirectory();
            file.cleanDirectory();
            for (int i = 0; i < count; i++)
            {
                DirectoryInfo dir;
                dir = Directory.CreateDirectory($@"{file.dir}\DIRECTORY\Owner{i}");
                file.fileWriterOwner($"owner{i}\\owner{i}", owner[i]);
                for (int j = 0; j < owner[i].tcs.Count; j++)
                {
                    file.fileWriterTC($"owner{i}\\owner{i}tc{j}", owner[i].tcs[j]);
                }
                for (int j = 0; j < owner[i].violations.Count; j++)
                {
                    file.fileWriterViolation($"owner{i}\\owner{i}violation{j}", owner[i].violations[j]);
                }
            }
            Console.WriteLine("Запись завершена!");
        }
        static public void readFile(Files file)
        {
            int i = 0;
            foreach (DirectoryInfo d in file.directory.GetDirectories())
            {
                Console.WriteLine($"Владелец № {i}");
                Console.WriteLine("========================");
                file.fileReaderOwner($"owner{i}\\owner{i}");
                Console.WriteLine("========================");
                string[] searchTC = Directory.GetFiles($@"{file.dir}\DIRECTORY\owner{i}\", $"owner{i}tc{i}*");
                string[] searchViolation = Directory.GetFiles($@"{file.dir}\DIRECTORY\owner{i}\", $"owner{i}violation{i}*");
                int j = 0;
                foreach (string f in searchTC)
                {
                    Console.WriteLine($"ТС № {j}");
                    file.fileReaderOwner($"owner{i}\\owner{i}tc{j}");
                    Console.WriteLine("========================");
                    j++;
                }
                j = 0;
                foreach (string f in searchViolation)
                {
                    Console.WriteLine($"Нарушения № {j}");
                    file.fileReaderViolation($"owner{i}\\owner{i}violation{j}");
                    Console.WriteLine("========================");
                    j++;
                }
                i++;
            }
            Console.WriteLine("Чтение завершено");
        }
    }
}
