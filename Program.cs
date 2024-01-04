using DesafioPOO.Models;
Iphone c1 = new Iphone("81993184712", "iPhone 12", "123123123", 256);
Nokia c2 = new Nokia("81995592429", "Tijolão", "321321321321321", 8);

c1.InstalarAplicativo("Whatsapp");
c2.InstalarAplicativo("Whatsapp");

Console.WriteLine($"Número do Nokia e do Iphone: {c1.Numero} e {c2.Numero}\n");

c1.Ligar();
c2.ReceberLigacao();

Console.WriteLine("\n");

c2.Ligar();
c1.ReceberLigacao();
// TODO: Realizar os testes com as classes Nokia e Iphone