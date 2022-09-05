using BankHm;

namespace Class1
{

    namespace BankHm
    {
        internal class Users
        {
            public string _name { get; set; }
            public string _surname { get; set; }
            public Card bankcard { get; set; }


            public Users() { }

            public Users(string name, string surnname, Card bankcard)
            {
                _name = name;
                _surname = surnname;
                this.bankcard = bankcard;
            }

            public void show()
            {
                Console.WriteLine($"Name -- {_name}\nSurname -- {_surname}\nBankCard -- {bankcard}");
            }

        }
    }
}