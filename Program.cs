using DesafioPOO.Models;


class Program
{
    static void Main()
    {

        Iphone iphone = new Iphone("123456789", "iPhone X", "IMEI123", 64);
        Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI456", 16);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine(); 

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.ReadLine(); 

    }
}