using dare.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "", modelo: "", imei: "", memoria: 1);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();

Console.WriteLine("IPhone");
Smartphone iphone = new Iphone(numero: "", modelo: "", imei: "", memoria: 1);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();