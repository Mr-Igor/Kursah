using System;

namespace Kursovaia
{
    class ChangeInfo
    {
        static public int changeInfo(Owner[] owner)
        {
            int answer = 0;
            int answerOwner = 0;
            int answerTC = 0;
            int answerViolation = 0;
            Console.WriteLine("Хотите изменить информацию о владельцах, ТС и нарушениях? 1 - владелец  2 - ТС  3 - нарушения  4 - продолжить  0 - выход");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("Введите какого владельца изменить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;
                    owner[answerOwner] = new Owner();
                    break;

                case 2:
                    Console.WriteLine("Введите какого владельца изменить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое тс изменить?");
                    answerTC = int.Parse(Console.ReadLine()) - 1;
                    owner[answerOwner].tcs[answerTC] = new TC();
                    break;

                case 3:
                    Console.WriteLine("Введите какого владельца изменить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое нарушение изменить?");
                    answerViolation = int.Parse(Console.ReadLine()) - 1;
                    owner[answerOwner].violations[answerViolation] = new Violation();
                    break;

                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int AddInfo(Owner[] owner)
        {
            int answer = 0;
            int answerOwner = 0;
            Console.WriteLine("Вы хотите добавить информацию? 1 - владелец, 2 - тс, 3 - нарушение, 4 - продолжить, 0 - выход ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Добавление владелецев:");
                    Array.Resize(ref owner, owner.Length + 1);
                    owner[owner.Length] = new Owner();
                    break;
                case 2:
                    Console.WriteLine("Введите к какому владельцу добавить тс?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Добавление тс:");
                    owner[answerOwner].tcs.Add(new TC());
                    break;
                case 3:
                    Console.WriteLine("Введите к какому владельцу добавить нарушение?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine("Введите какие нарушения удалить?");
                    owner[answerOwner].violations.Add(new Violation());
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
        static public int DeleteInfo(Owner[] owner)
        {

            int answer = 0;
            int answerOwner = 0;
            int answerTC = 0;
            int answerViolation = 0;
            Console.WriteLine("Вы хотите удалить информацию? 1 - владелец, 2 - тс, 3 - нарушение, 4 - продолжить, 0 - выход  ");
            answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите какого владельца удалить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;
                    Array.Clear(owner, answerOwner, 1);
                    break;
                case 2:
                    Console.WriteLine("Введите какого владельца удалить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое тс удалить?");
                    answerTC = int.Parse(Console.ReadLine()) - 1;
                    owner[answerOwner].tcs.RemoveAt(answerTC);
                    break;
                case 3:
                    Console.WriteLine("Введите какого владельца удалить?");
                    answerOwner = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите какое нарушение удалить?");
                    answerViolation = int.Parse(Console.ReadLine()) - 1;
                    owner[answerOwner].violations.RemoveAt(answerViolation);
                    break;
                default:
                    Console.WriteLine("Применение изменений....");
                    break;
            }
            return answer;
        }
    }
}
