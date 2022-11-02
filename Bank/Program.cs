Console.WriteLine("\t\t\t\t----------- Welcome to Abb ------------");


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

up2:
Console.Write("Username: ");
string User = Console.ReadLine();
Console.Write("Password: ");
string Password = Console.ReadLine();

if (User == user && Password == password)
{
    Console.WriteLine($"\t\t\t\t----------- Welcome {person} ------------\n\n");
up:
    Console.WriteLine("\nNe etmek isteyirsiniz?");
    Console.WriteLine("\n1.Kredit goturmek \n2.Kredit odemek \n3.Hesabat");

    int choose = int.Parse(Console.ReadLine());


    switch (choose)
    {
        ///Kreditt goturmek
        case 1:
            if (choose == 1)
            {
                Console.WriteLine("12 ayadek - 12%\n12 aydan cox - 18%\n");

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
                Console.WriteLine("Odenilecek mebleg: " + umumOdenilecekMebleg);
                Console.Write("Aylig odenish: " + umumOdenilecekMebleg / 12 + "\n");

                Console.WriteLine("\nRazisiniz?");
                Console.WriteLine("1.Beli");
                Console.WriteLine("2.Xeyr");

                int acces = int.Parse(Console.ReadLine());
                if (acces == 1)
                    Console.WriteLine("Teshkur edirk");
                else
                    Console.WriteLine("Sagolun");
                goto up;
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
                        goto up;
                    }
                    Console.WriteLine($"Qalig borc: {umumOdenilecekMebleg}");
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
                Console.WriteLine($"Qalig borc: {umumOdenilecekMebleg} AZN");
                Console.WriteLine($"Qalan ay: {ay}");

                goto up;
            }
            break;
    }
}


else
{
    Console.WriteLine("Password is wrong");
    goto up2;

}

