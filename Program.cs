using DesafioPOO.Models;

Smartphone nk = new Nokia(numero: "123456", modelo: "Modelo I", imei: "IGHDSB23", memoria: 128);
Smartphone iph = new Iphone(numero: "245678", modelo: "Modelo XR", imei: "34DHFD45", memoria: 256);

Console.WriteLine("=========Smartphone Nokia=========");
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("Telegram");


Console.WriteLine("\n========Smartphone Iphone=========");
iph.Ligar();
iph.ReceberLigacao();
iph.InstalarAplicativo("Duolingo");