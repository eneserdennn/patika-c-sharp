Console.WriteLine("Isminizi giriniz");
string name = Console.ReadLine() ?? "";
Console.WriteLine("Soyadinizi giriniz");
string surname = Console.ReadLine() ?? "";
Console.WriteLine("Merhaba" + " " + name + " " + surname);