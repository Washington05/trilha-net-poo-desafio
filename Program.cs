using DesafioPOO.Models;

// TODO: Implementado

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1196734234", modelo: "Modelo 1", imei: "1293984821", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "1193545346", modelo: "Modelo 2", imei: "2345784754", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");