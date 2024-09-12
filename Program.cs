using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 15", imei: "9999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "456789", modelo: "Iphone 15", imei: "7777777", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
