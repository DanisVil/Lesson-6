using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_manual
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(-9999, Type.Current);
            bankAccount.WithdrawMoney(-100);
            Console.WriteLine(bankAccount.Info);

            BankAccount leatherwallet = new BankAccount(0, Type.Saving);
            leatherwallet.PutMoney(100);
            Console.WriteLine(leatherwallet.Info);

            BankAccount gosdolgSSHA = new BankAccount(2367014523, Type.Saving);
            Console.WriteLine(gosdolgSSHA.Info);
            Console.WriteLine(bankAccount.Info);

            Building burjuiHalifa = new Building(249567, 100, 1000, 10);
            Console.WriteLine(burjuiHalifa.AverageNumberOfApartmentsPerFloor);

            Console.ReadKey();
        }
    }
    enum Type { Current = 1, Saving = 2 };
    class BankAccount
    {
        private static ushort counter = 1;
        private ushort number = counter;
        private double balance = 0;
        private Type type;
        public void PutMoney(double shekeli)
        {
            if (shekeli < 0)
            {
                Console.WriteLine("пользуйтесь специальным методом \"WithdrawMoney\"");
            }
            balance += shekeli;
        }
        public double WithdrawMoney(double grivni)
        {
            if (grivni < 0)
            {
                Console.WriteLine("пользуйтесь специальным методом \"PutMoney\"");
                return 0;
            }
            else if (grivni < balance)
            {
                balance -= grivni;
                return grivni;
            }
            else
            {
                Console.WriteLine("-Какими деньгами?");
                return 0;
            }
        }
        public Type AccountType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public BankAccount(double balance, Type type)
        {
            this.balance = balance;
            this.type = type;
            counter++;
        }

        public string Info
        {
            get
            {
                string str_type = ((int)type).Equals(1) ? "текущий" : "сберегательный";
                if ((int)type == 1) { }
                return $"Номер счёта: {number}\nБаланс: {balance}\nТип: {str_type}";
            }
        }
    }


    class Building
    {
        private static ushort counter = 1;
        private ushort number = counter;
        private double height;
        private byte number_of_storeys;
        private uint number_of_apartments;
        private ushort entrances;
        public Building(double height, byte nos, uint noa, ushort entrances)
        {
            this.height = height;
            number_of_storeys = nos;
            number_of_apartments = noa;
            this.entrances = entrances;
            counter++;
        }
        public ushort Number
        {
            get
            {
                return number;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public byte NumberOfStoreys
        {
            get
            {
                return number_of_storeys;
            }
            set
            {
                number_of_storeys = value;
            }
        }
        public uint NumberOfApartments
        {
            get
            {
                return number_of_apartments;
            }
            set
            {
                number_of_apartments = value;
            }
        }
        public ushort Entrances
        {
            get
            {
                return entrances;
            }
            set
            {
                entrances = value;
            }
        }
        public float FloorHeight
        {
            get
            {
                return (float)height / number_of_storeys;
            }
        }
        public float AverageNumberOfApartmentsInTheEntrance
        {
            get
            {
                return number_of_apartments / entrances;
            }
        }
        public float AverageNumberOfApartmentsPerFloor
        {
            get
            {
                return number_of_apartments / number_of_storeys;
            }
        }
    }
}
