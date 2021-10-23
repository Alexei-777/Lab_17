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
            Write();
            Main(args);
        }
        static void Read1<T>()
        {
            Account<int> account1 = new Account<int>();
            Console.WriteLine("Ведите номер счета ");
            account1.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите баланс ");
            account1.Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите ФИО владельца ");
            account1.FIO = Convert.ToString(Console.ReadLine());
        }
        static void Write()
        {
            Account<int> account2 = new Account<int>();
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", "Номер", "Баланс", "ФИО");
            Console.WriteLine("{0,-11} | {1,-11} | {2,-34}", account2.Number, account2.Balance, account2.FIO);
        }
    }
    public class Account<T>
    {
        private T number;
        private int balance;
        private string fio;
        public T Number { get { return number; } set { number = value; } }
        public int Balance { get { return balance; } set { balance = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
        public Account()
        {
            this.number = Number;
            this.balance = Balance;
            this.fio = FIO;
            
        }
    }
}
