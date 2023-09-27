class Program
{
    static void Main(string[] args)
    {
        Lahev lahev = new Lahev(2); 

        lahev.Objem = 1; 
        Console.WriteLine(lahev.Objem); 

        lahev.NastavitObjemML(500); 
        Console.WriteLine(lahev.Objem);

        Console.WriteLine(lahev.ZiskatObjemML()); 

        lahev.Zavrit(); 
        lahev.Objem = 1.5;
        Console.WriteLine(lahev.Objem); 

        lahev.Otevrit(); 
        lahev.Vyprazdnit();
        Console.WriteLine(lahev.Objem); 
    }
}
