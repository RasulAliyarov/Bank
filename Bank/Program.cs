Console.WriteLine("\t\t----------- Welcome to Abb ------------\n");


string user = "admin";
string password = "admin";

string person = "Rasul";

int mebleg = 0;
int ay = 0;
int faiz = 12;
int umumOdenilecekMebleg = 0;
int sum = 0;
int pay = 0;
int qaliq = umumOdenilecekMebleg;
bool flaq = true;

up2:
Console.Write("Username: ");
string User = Console.ReadLine();
Console.Write("Password: ");
string Password = Console.ReadLine();

if (User == user && Password == password)
{
    Console.WriteLine($"\t\t----------- Welcome {person} ------------\n");
    up:

    while (flaq)
    {
        Console.WriteLine("\nNe etmek isteyirsiniz?");
        Console.WriteLine("\n1.Kredit goturmek \n2.Kredit odemek \n3.Hesabat\n4.Cixish");

        int choose = int.Parse(Console.ReadLine());

        switch (choose)
        {
            ///Kreditt goturmek
            case 1:
                if (choose == 1)
                {
                    Console.WriteLine("\n12 ayadek - 12%\n12 aydan cox - 18%\n");

                    Console.Write("Ay daxil edin: "); ay = int.Parse(Console.ReadLine());

                    Console.Write("Mebleg daxil edin: "); mebleg = int.Parse(Console.ReadLine());

                    if (ay <= 12)
                    {
                        umumOdenilecekMebleg = ((mebleg * 12) / 100) + mebleg;
                    }
                    else
                    {
                        umumOdenilecekMebleg = ((mebleg * 18) / 100) + mebleg;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOdenilecek mebleg: " + umumOdenilecekMebleg + " AZN");
                    Console.Write("Aylig odenish: " + umumOdenilecekMebleg / 12 + " AZN\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\nRazisiniz?");
                    Console.WriteLine("1.Beli");
                    Console.WriteLine("2.Xeyr");

                    int acces = int.Parse(Console.ReadLine());
                    if (acces == 1)
                        Console.WriteLine("Teshkur edirk");
                    else
                    {
                        Console.WriteLine("Sagolun");
                        umumOdenilecekMebleg = 0;
                        ay = 0;
                    }
                    break;
                }
                break;
            ///Kredit odemek
            case 2:
                if (choose == 2)
                {
                    up3:
                    Console.Write("Neche AZN odeyeceksiz? "); pay = int.Parse(Console.ReadLine());

                    if (pay <= umumOdenilecekMebleg)
                    {
                        umumOdenilecekMebleg = umumOdenilecekMebleg - pay;
                        if (umumOdenilecekMebleg == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Krediti tam olaraq bagladiz!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            ay = 0;
                            goto up;
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Qalig borc: {umumOdenilecekMebleg} AZN");
                        Console.ForegroundColor = ConsoleColor.White;
                        ay = --ay;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cox pul verdiz");
                        Console.ForegroundColor = ConsoleColor.White;

                        goto up3;
                    }
                    goto up;
                }
                break;
            ///Hesabat
            case 3:
                if (choose == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Qalig borc: {umumOdenilecekMebleg} AZN");
                    Console.WriteLine($"Qalan ay: {ay}");
                    Console.ForegroundColor = ConsoleColor.White;

                    goto up;
                }
                break;
            case 4:
                if (choose == 4)
                {


                    flaq = false;
                }
                break;
        }
    }
}


else
{
    Console.WriteLine("Password is wrong");
    goto up2;

}

