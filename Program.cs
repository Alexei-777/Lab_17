using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
//Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
//Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
//Создать  несколько экземпляров класса, параметризированного различными типам.
//Заполнить его поля и вывести информацию об экземпляре класса на печать.


namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Read1<int>();
            Read2<string, int>();
            Read3<int, int, string>();
            Console.ReadKey();
        }
        static void Read1<T>()
        {
            Account1<int> account1 = new Account1<int>();
            Console.WriteLine("Ведите номер счета ");
            account1.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите баланс ");
            account1.Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите ФИО владельца ");
            account1.FIO = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", "Номер", "Баланс", "ФИО");
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", account1.Number, account1.Balance, account1.FIO);
        }
        static void Read2<T, U>()
        {
            Account2<string, int> account2 = new Account2<string, int>();
            Console.WriteLine("Ведите номер счета ");
            account2.Number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ведите баланс ");
            account2.Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите ФИО владельца ");
            account2.FIO = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", "Номер", "Баланс", "ФИО");
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", account2.Number, account2.Balance, account2.FIO);
        }
        static void Read3<T, U, V>()
        {
            Account3<int, int, string> account3 = new Account3<int, int, string>();
            Console.WriteLine("Ведите номер счета ");
            account3.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите баланс ");
            account3.Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите ФИО владельца ");
            account3.FIO = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", "Номер", "Баланс", "ФИО");
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", account3.Number, account3.Balance, account3.FIO);
        }

    }
    public class Account1<T>
    {
        private T number;
        private int balance;
        private string fio;
        public T Number { get { return number; } set { number = value; } }
        public int Balance { get { return balance; } set { balance = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
        public Account1()
        {
            this.number = Number;
            this.balance = Balance;
            this.fio = FIO;
        }
    }
    public class Account2<T, U>
    {
        private T number;
        private U balance;
        private string fio;
        public T Number { get { return number; } set { number = value; } }
        public U Balance { get { return balance; } set { balance = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
        public Account2()
        {
            this.number = Number;
            this.balance = Balance;
            this.fio = FIO;
        }
    }
    public class Account3<T, U, V>
    {
        private T number;
        private U balance;
        private V fio;
        public T Number { get { return number; } set { number = value; } }
        public U Balance { get { return balance; } set { balance = value; } }
        public V FIO
        { get { return fio; } set { fio = value; } }
        public Account3()
        {
            this.number = Number;
            this.balance = Balance;
            this.fio = FIO;
        }
    }
}