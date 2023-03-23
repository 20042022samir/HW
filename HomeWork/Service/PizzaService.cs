

using GT.work;

public class PizzaService<W> where W: Pizza 
{
    List<W> lists=new List<W>();
    int counter = 0;
    public void Create(W w)
    {   
        w.name = "kasarli";
        w.type = "pendirli";
        counter++;
        w.Id = counter;
        w.ExtraInfo = "Bol pendirlidir,Nisbeten ucuzdur";
        w.priceB = 25;
        w.priceM = 20;
        w.priceS = 15;
        lists.Add(w);
        
    }
    

    public void Create2(W W)
    {
        W.name = "Adana";
        W.type = "acili";
        counter++;
        W.Id=counter;
        W.ExtraInfo = "acilidir,meksika bibari istifade edilir";
        W.priceB = 30;
        W.priceM = 25;
        W.priceS = 17;
        lists.Add(W);
    }
    
   

    public void GetAll()
    {
        foreach (Pizza item in lists)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"adi-->{item.name}---tipi-->{item.type}---Id-si-->{item.Id}");
        }
    }

    public void ExtraInfo()
    {
     Console.WriteLine("pizzalar haqqinda elave melumat almaq ucun ID-sini daxil edin");
    AGAIN:
        try
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            foreach (var item in lists)
            {
                if (item.Id == choice)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("etrafli melumat-->" + item.ExtraInfo);
                    Helper.Maiiin();
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("umumi mebleg-->" + item.priceM);
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("umumi mebleg-->" + item.priceB);
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("umumi mebleg-->" + item.priceS);
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("sadece 3 secim var");
                            break;
                    }

                }
             
            }
        }
        catch (Exception)
        {
            Console.WriteLine("duzgun bir sey daxil edin");
            goto AGAIN;
            
        }
          
    }
    
    public void CreateByClient()
    {
        Console.WriteLine("alamq istediyiniz pizzanin adini daxil edin");
        string namee=Console.ReadLine();
        foreach (Pizza item in lists)
        {
            if (item.name.Contains(namee))
            {
                Console.WriteLine("almaq istediyiniz pizzanin boyunu secin");
                Console.WriteLine(Extra.BoyukBoy+"-->"+item.priceB);
                Console.WriteLine(Extra.Ortaboy+"-->"+item.priceM);
                Console.WriteLine(Extra.KicikBoy+"-->"+item.priceS);
                int choice10=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ela bizi secdiyiniz ucun tesekkur edirik");
            }
        }
    }
}

