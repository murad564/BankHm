using BankHm;

namespace Class1.BankHm;
class Program
{

    static void Main()
    {
        Console.WriteLine("Bank");

        Users[] users =
            {
            new Users("Murad", "Meherremli" ,new Card("1232","1248944856", "453", "12/3/22" ,200)),
            new Users("Saleh", "Reshidov" ,new Card("3222","3215633213211", "432",  "11/4/27",500))
            };


        bool flag = true;
        bool accses = true;

        while (flag)
        {
            Console.WriteLine("PIN:");
            string enterpin = Console.ReadLine();
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].bankcard._pin==enterpin)
                {
                    Console.WriteLine($"{users[i]._name} {users[i]._surname} xos gelmisiz");
                    accses=true;
                    while (accses)
                    {
                        Console.WriteLine("1 -- Balance\n2 -- Cash out\n3 -- Operation List\n4 -- Transfer\n5 -- Exit\n");
                        int enter = Convert.ToInt32(Console.ReadLine());
                        if (enter == 1)
                            Console.WriteLine($"your balance : {users[i].bankcard._balance}");

                        else if (enter == 2)
                        {
                            Console.WriteLine("\n1 -- 10\n2 -- 20\n3 --50\n4 --100\n5--choose hown many you want take :");
                            int cashout = Convert.ToInt32(Console.ReadLine());
                            if (cashout == 1)
                            {
                                if (users[i].bankcard._balance >= 10)
                                    users[i].bankcard._balance -= 10;
                                else
                                    throw new Exception("dont enought money");
                            }
                            else if (cashout == 2)
                            {
                                if (users[i].bankcard._balance >= 20)
                                    users[i].bankcard._balance -= 20;
                                else
                                    throw new Exception("dont enought money");
                            }
                            else if (cashout == 3)
                            {
                                if (users[i].bankcard._balance >= 50)
                                    users[i].bankcard._balance -= 50;
                                else
                                    throw new Exception("dont enought money");
                            }
                            else if (cashout == 4)
                            {
                                if (users[i].bankcard._balance >= 100)
                                    users[i].bankcard._balance -= 100;
                                else
                                    throw new Exception("dont enought money");
                            }
                            else if (cashout == 5)
                            {
                                int moneyout = Convert.ToInt32(Console.ReadLine());
                                if (users[i].bankcard._balance >= moneyout)
                                    users[i].bankcard._balance -= moneyout;
                                else
                                    throw new Exception("dont enought money");
                            }
                            else if (cashout == 6)
                                break;
                        }

                        else if (enter == 3)
                        {
                            Console.WriteLine("12/02/2022");
                        }
                        else if (enter == 4)
                        {
                            Console.WriteLine("istediyviz kartin pin in daxil edin:");
                            string en = Console.ReadLine();
                            for (int j = 0; j < users.Length; j++)
                            {
                                if (users[j].bankcard._pin == en)
                                {
                                    Console.WriteLine("kocrmey istedyviz pulu yazin:");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    if (users[i].bankcard._balance >= a)
                                    {
                                        users[i].bankcard._balance -= a;
                                        users[j].bankcard._balance += a;
                                    }
                                    if (users[i].bankcard._balance < a)
                                        Console.WriteLine("kifayet qeder balansviz yoxdur");
                                }
                            }
                        }
                        else if (enter == 5)
                            accses = false;
                    }
                }


            }
        }
    }
}