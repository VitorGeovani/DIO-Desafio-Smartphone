using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia");
            Smartphone nokia = new Nokia(numero: "123456789", modelo: "3310", imei: "123456789", memoria: 16);
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone");
            Smartphone iphone = new Iphone(numero: "987654321", modelo: "12", imei: "987654321", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");

        }
    }
}