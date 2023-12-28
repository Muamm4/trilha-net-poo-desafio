using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new("11999999999", "Nokia 160", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new("1191999555", "Iphone 13", "191587355", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");