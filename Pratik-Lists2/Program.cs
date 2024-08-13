using System;

// Ana program
Console.WriteLine("Kahve Listesi Oluşturucu");
Console.WriteLine("-------------------------");

// Kahve isimlerini saklamak için bir liste oluştur
List<string> kahveler = new List<string>();

// Kullanıcıdan 5 kahve ismi al
for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i}. kahve adını giriniz: ");
    string kahveAdi = Console.ReadLine();

    // Boş girişleri engelle
    while (string.IsNullOrWhiteSpace(kahveAdi))
    {
        Console.Write("Lütfen geçerli bir kahve adı giriniz: ");
        kahveAdi = Console.ReadLine();
    }

    kahveler.Add(kahveAdi);
}

// Girilen kahve isimlerini ekrana yazdır
Console.WriteLine("\nGirilen Kahve İsimleri:");
Console.WriteLine("-------------------------");
foreach (string kahve in kahveler)
{
    Console.WriteLine($"- {kahve}");
}

Console.WriteLine("\nKahve listeniz hazır. Afiyet olsun!");