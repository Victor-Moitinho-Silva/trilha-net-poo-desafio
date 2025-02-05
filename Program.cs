using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("98155078", "Nokia28", "eii9899o", 4);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("98155078", "Iphone 16", "eii9899o", 10);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");