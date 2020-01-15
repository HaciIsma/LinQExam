using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExam.Model
{
    static class ExamMethods
    {
        public static void Foo1Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where user.Email.Contains("rhyta.com") || user.Email.Contains("dayrep.com")
                        select user;
            Console.WriteLine("rhyta.com ve ya dayrep.com domenlerinde emaili olan borclular: ");
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        public static void Foo2Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where (DateTime.Now.Year - user.BirthDay.Year) > 26 &&
                        (DateTime.Now.Year - user.BirthDay.Year) < 36
                        select user;
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        public static void Foo3Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where user.Debt > 5000
                        select user;
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        public static void Foo4Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where (user.FullName.Length > 18) && (user.Phone.Count(b => b == '7') >= 2)
                        select user;
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        public static void Foo5Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where user.BirthDay.Month == 12 || user.BirthDay.Month == 1 || user.BirthDay.Month == 2
                        select user;
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        ///
        public static void Foo6Q(List<Debtor> debtors)
        {
            int sum = 0, count = 0;
            foreach (var debt in debtors)
            {
                sum += debt.Debt;
                count++;
            }
            int avarage = sum / count;

            var users = from user in debtors
                        where (avarage < user.Debt)
                        select user;
            Console.WriteLine("Avarage big user debt: ");
            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
            Console.WriteLine();

            Console.WriteLine("Sort name");
            users = from user in debtors
                    orderby user.FullName.Split()[2]
                    select user;

            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }

            users = from user in debtors
                    orderby user.Debt descending
                    select user;
            Console.WriteLine();
            Console.WriteLine("Sort Debt");
            foreach (var user in users)
            {
                Console.WriteLine(user.Debt);
            }


        }

        public static void Foo7Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where user.Phone.Count(b => b == '8') >= 0
                        select user;
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine($"User FullName: {user.FullName.Split()[2]} \nUser Age: { DateTime.Now.Year - user.BirthDay.Year} \nUser Debet: {user.Debt}");
                Console.WriteLine();
            }
        }

        ///
        public static void Foo8Q(List<Debtor> debtors)
        {
           
        }

        ///
        public static void Foo9Q(List<Debtor> debtors)
        {

        }

        public static void Foo10Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        orderby user.Debt
                        select user;

            foreach (var user in users.Take(5))
            {
                Console.WriteLine(user.FullName);
            }

        }

        public static void Foo11Q(List<Debtor> debtors)
        {
            var total = (from user in debtors
                         select user.Debt).Sum();

            Console.WriteLine(total);
        }

        public static void Foo12Q(List<Debtor> debtors)
        {
            var users = from user in debtors
                        where user.BirthDay.Year < 1939
                        select user;

            foreach (var user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }

        ///
        public static void Foo13Q(List<Debtor> debtors)
        {

        }
        ///
        public static void Foo14Q(List<Debtor> debtors)
        {

        }
        ///
        public static void Foo15Q(List<Debtor> debtors)
        {

        }
    }
}
