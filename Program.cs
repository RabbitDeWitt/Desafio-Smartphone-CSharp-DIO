using Desafio_Smartphone_CSharp_DIO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone iphone= new Iphone("456789", "Modelo 2", "22222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");