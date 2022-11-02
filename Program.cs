Console.WriteLine("\t\t\t\t\t\tWelcome to Bank!");
Console.WriteLine("\t\t\t\t\t\t-----------------");
yeniden:
Console.WriteLine("Username:");
string username = Console.ReadLine();
Console.WriteLine("password:");
string password = Console.ReadLine();
if (username!="Ferid")
{
    Console.WriteLine("username sehvdir");
    goto yeniden;
}
if (password != "123")
{
    Console.WriteLine("password:");
    goto yeniden;
}
double ayliqmebleg = 0;
double mebleg_odenilecek=0;
double mebleg=0;
int ay=0;
Console.WriteLine("\t\t\t\t\t\tWelcome"+ " " +username);
tryagain:
Console.WriteLine("1)Kredit goturmek\n2)Kredit odemek\n3)Hesabat");
int secim = Convert.ToInt32(Console.ReadLine());
if (secim==1 && ay!=0)
{
    Console.WriteLine("Borcunuzu odemeden yeniden kredit goture bilmezsiz");
    goto tryagain;
}
if (secim == 1)
{
    Console.WriteLine("ay:");
    ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("goturelecek mebleg:");
    mebleg = Convert.ToInt32(Console.ReadLine());
    if (ay > 12 && ay <= 18)
    {
        mebleg_odenilecek = mebleg + (mebleg * 18) / 100;
        Console.WriteLine("Odenilecek mebleg:" + mebleg_odenilecek);
        ayliqmebleg = mebleg_odenilecek / ay;
        Console.WriteLine("Ayliq odenis:" + ayliqmebleg);

    }
    else if (ay <= 12)
    {
        mebleg_odenilecek = mebleg + (mebleg * 12) / 100;
        ayliqmebleg = mebleg_odenilecek / ay;
        Console.WriteLine("Odenilecek mebleg:" + mebleg_odenilecek);
        Console.WriteLine("Ayliq odenis:" + ayliqmebleg);
    }
    Console.WriteLine("Razisiniz?\n1)Yes\n2)No");
    int sec = Convert.ToInt32(Console.ReadLine());
    if (sec == 1)
    {
        Console.WriteLine("Emeliyyat ugurlu oldu");
        goto tryagain;
    }
    else if (sec == 2)
    {
        Console.WriteLine("Emeliyyat ugursuz oldu");
        goto tryagain;
    }
}
else if (secim == 2)
{

    Console.WriteLine("Odenilecek mebleg" + " " + ayliqmebleg);
    Console.WriteLine("Razisiniz?\n1)Yes\n2)No");
    int sec = Convert.ToInt32(Console.ReadLine());
    if (sec == 1)
    {
        ay = ay - 1;
        mebleg_odenilecek = mebleg_odenilecek - ayliqmebleg;
        if(ay == 0)
        {
            Console.WriteLine("Sizin borcunuz yoxdur !");
            goto tryagain;
        }
        Console.WriteLine("Emeliyyat ugurlu oldu");
        goto tryagain;
    }
    else if (sec == 2)
    {
        Console.WriteLine("Emeliyyat ugursuz oldu");
        goto tryagain;
    }
}
else if (secim == 3)
{
    
    Console.WriteLine("Borcunuz:" + mebleg_odenilecek);
    Console.WriteLine("Qalan Ay:" + ay);
    goto tryagain;
}