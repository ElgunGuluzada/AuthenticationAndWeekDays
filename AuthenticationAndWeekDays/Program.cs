using System;

namespace AuthenticationAndWeekDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();


          HomePage:  Console.WriteLine(" Heftenin gunleri ucun 1 , Qeydiyyatin yoxlanilmasi tapsirigi ucun 2 yazin.");
            bool choose = int.TryParse(Console.ReadLine(), out int val);
            if (choose)
            {
                switch (val)
                {
                    case 1:
                        goto t1;
                        break;
                    case 2:
                        goto t2;
                        break;
                }
            }


        t1:  Console.WriteLine("Zehmet olmasa 1-7 araliginda bir reqem secin ve heftenin hansi gunune aid oldugunu oyrenin.");
            bool d = int.TryParse(Console.ReadLine(), out int day);
            if (d)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Bazar ertesi, Is gunudur");
                        break;
                    case 2:
                        Console.WriteLine("Cersenbe axsami, Is gunudur");
                        break;
                    case 3:
                        Console.WriteLine("Cersenbe, Is gunudur");
                        break;
                    case 4:
                        Console.WriteLine("Cume axsami, Is gunudur");
                        break;
                    case 5:
                        Console.WriteLine("Cume, Is gunudur");
                        break;
                    case 6:
                        Console.WriteLine("Senbe, Qeyri Is gunudur");
                        break;
                    case 7:
                        Console.WriteLine("Bazar, Qeyri Is gunudur");
                        break;
                    default:
                        Console.WriteLine("Yanlis Secim !");
                        goto t1;
                }
            }
            goto HomePage;

       t2: Console.WriteLine("Qeydiyyatdan kecmek ucun 1 Giris etmek ucun 2ye click edin.");

            bool sign = int.TryParse(Console.ReadLine(), out int numb);
            User oldUser = newUser;
            if (sign)
            {
                switch (numb)
                {
                    case 1:
                        Console.WriteLine("Zehmet olmasa Adinizi Daxil Edin");
                        newUser.Name = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa Soyadinizi Daxil Edin");
                        newUser.Surname = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa Cinsinizi K ve ya Q olaraq Daxil Edin");
                        newUser.Gender = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa Istifadeci adinizi Daxil Edin");
                        newUser.userName = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa Sifre Teyin Edin");
                        newUser.password = Console.ReadLine();
                        newUser.Date = DateTime.Now;
                        Console.WriteLine($"Qeydiyyat {newUser.Date} tarixinde ugurla basa catdi.");
                        newUser.UserData(newUser.userName, newUser.password);
                        Console.WriteLine("Artiq sehifeye giris ede bilersiniz..");
                        break;

                    case 2:
                        if (oldUser.userName != null)
                        {
                        un: Console.WriteLine("Zehmet olmasa istifadeci adinizi daxil edin");
                            string username = Console.ReadLine();
                            if (username == newUser.userName)
                            {
                                Console.WriteLine("Zehmet olmasa sifrenizi daxil edin.");
                            pw: string password = Console.ReadLine();
                                if (password == newUser.password)
                                {
                                    switch (oldUser.Gender)
                                    {
                                        case "K":
                                            Console.WriteLine($"{newUser.Name} bey xos gelmisiniz..");
                                            break;
                                        case "Q":
                                            Console.WriteLine($"{newUser.Name} xanim xos gelmisiniz..");
                                            break;
                                        default:
                                            Console.WriteLine($"Cinsinizi duzgun secmediyiniz ucun size sadece adinizla muraciet etmeli olduq {newUser.Name}");
                                            break;
                                    }
                                    goto HomePage;
                                }
                                else
                                {
                                    Console.WriteLine("Sifre uygun deyil zehmet olmasa sifrenizi yeniden daxil edin.");
                                    goto pw;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Istifadeci adiniz yanlisdir.");
                                goto un;
                            }
                        }
                        else
                            Console.WriteLine("Zehmet olmasa once qeydiyyatdan kecin.");
                        goto t2;
                }
                goto t2;
            }
            else
            {
                goto t2;
            }

            goto HomePage;

        }
        public struct User
        {
            public string Name;
            public string Surname;
            public string Gender;
            public DateTime Date;
            public string userName;
            public string password;

            public void UserData(string userName, string password)
            {
                User user1 = new User();
                user1.Name = userName;
                user1.Surname = password;
                user1.Date = DateTime.Now;
                user1.password = password;
                Console.WriteLine($"Istifadeci Adiniz: {userName} \n" +
                    $"   Sifreniz: {password}");
            }
        }
    }

}
