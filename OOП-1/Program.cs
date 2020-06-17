using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOП_1
{
    class Program
    {
        public class buyer
        {
            public string lastname;
            public string firstname;
            internal string middlename;
            internal string cardnum;
            protected internal string bunknum;
        }
        public class subscriber
        {
            protected internal string id;
            public string lastname;
            public string firstname;
            internal string middlename;
            public string address;
            internal string cardnum;
            protected internal string ldnegotiations;
            protected internal string fcnegotiations;
        }
        public class petshop
        {
            public string pet;
            public string sex;
            public string name;
            public string price;
            public string quntity;

            static void Main(string[] args)
            {
                buyer newBuyer = new buyer();
                newBuyer.lastname = "Агафонов";
                newBuyer.firstname = "Данил";
                newBuyer.middlename = "Алексеевич";
                newBuyer.cardnum = "4875 4712 4545 6875";
                newBuyer.bunknum = "6546545645212187898";
                Console.WriteLine(newBuyer.lastname);
                Console.WriteLine(newBuyer.firstname);
                Console.WriteLine(newBuyer.middlename);
                Console.WriteLine(newBuyer.cardnum);
                Console.WriteLine(newBuyer.bunknum);
                Console.WriteLine("");
                

                subscriber newSubscriber = new subscriber();
                Console.WriteLine("Введите id");
                newSubscriber.id = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                newSubscriber.lastname = Console.ReadLine();
                Console.WriteLine("Введите имя");
                newSubscriber.firstname = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                newSubscriber.middlename = Console.ReadLine();
                Console.WriteLine("Введите адрес");
                newSubscriber.address = Console.ReadLine();
                Console.WriteLine("Введите номер кредитной карточки");
                newSubscriber.cardnum = Console.ReadLine();
                Console.WriteLine("Введите время междугородных перговоров");
                newSubscriber.ldnegotiations = Console.ReadLine();
                Console.WriteLine("Введите время городских переговоров");
                newSubscriber.fcnegotiations = Console.ReadLine();

                Console.WriteLine(newSubscriber.lastname);
                Console.WriteLine(newSubscriber.firstname);
                Console.WriteLine(newSubscriber.middlename);
                Console.WriteLine(newSubscriber.address);
                Console.WriteLine(newSubscriber.cardnum);
                Console.WriteLine(newSubscriber.ldnegotiations);
                Console.WriteLine(newSubscriber.fcnegotiations);
                Console.WriteLine("");
               



                petshop newZoo = new petshop();
                Console.WriteLine("Введите животное");
                newZoo.pet = Console.ReadLine();
                Console.WriteLine("Введите пол животного");
                newZoo.sex = Console.ReadLine();
                Console.WriteLine("Введите имя животного");
                newZoo.name = Console.ReadLine();
                Console.WriteLine("Введите цену животного");
                newZoo.price = Console.ReadLine();
                Console.WriteLine("Введите количествово животных");
                newZoo.quntity = Console.ReadLine();

                Console.WriteLine(newZoo.pet);
                Console.WriteLine(newZoo.sex);
                Console.WriteLine(newZoo.name);
                Console.WriteLine(newZoo.price);
                Console.WriteLine(newZoo.quntity);
                Console.ReadKey();
            }
        }
    }
}
