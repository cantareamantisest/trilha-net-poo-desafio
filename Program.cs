using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("12345678", "Nokia", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n\r");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia("87654321", "Iphone", "222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

Console.ReadKey();
