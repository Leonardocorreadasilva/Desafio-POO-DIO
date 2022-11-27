using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "1264597", modelo: "Nokia One", imei: "132465789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Candy crush");

Console.WriteLine();

Console.WriteLine("Vez do iphone");

Smartphone iphone = new Iphone(numero: "1265425", modelo: "Iphone14", imei: "1234", memoria: 258);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("APP de Banco");