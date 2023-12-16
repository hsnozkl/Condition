namespace if_else_if;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        
        if(time >= 6 && time < 11) // eğer
            Console.WriteLine("Gunaydin!");
        else if(time <= 18) // eğer değilse
            Console.WriteLine("Iyi Gunler!");
        else // değilse
            Console.WriteLine("Iyi Geceler!");

        string sonuc = time <= 18 ? "Iyi Gunler!" : "Iyi Geceler!";

        sonuc = time >= 6 && time <= 11 ? "Gunaydin!" : time <= 18 ? "Iyi Gunler!" : "Iyi Geceler!";
        Console.WriteLine(sonuc);
    }
}
