


using GT.work;
Helper.Helperr();
AGAIN:
try
{
    Console.ForegroundColor = ConsoleColor.White;
    int choice = Convert.ToInt32(Console.ReadLine());
    PizzaService<Pizza> service = new PizzaService<Pizza>();
    service.Create(new KasarliPizza());
    service.Create2(new AciliPizza());

    switch (choice)
    {
        case 1:
            service.GetAll();
            Console.ForegroundColor = ConsoleColor.White;
            service.ExtraInfo();
            break;
        case 2:
            service.CreateByClient();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("yalniz 2 secim var");
            Console.WriteLine("bir daha daxil edin");
            goto AGAIN;
            break;
    }
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("zehmet olmasa duzgun bir sey daxil edin");
    Console.WriteLine("bir daha daxil edin");
    goto AGAIN;
}
