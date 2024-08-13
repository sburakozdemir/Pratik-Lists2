# Pratik-Lists2


Bu basit C# konsol uygulaması, kullanıcının favori kahvelerini listelemesine olanak tanır. Program, kullanıcıdan 5 kahve ismi alır ve bu isimleri bir liste halinde görüntüler.

## Özellikler

- Kullanıcıdan 5 kahve ismi alır
- Boş girişleri engeller
- Girilen kahve isimlerini düzenli bir şekilde listeler

## Nasıl Kullanılır

1. Uygulamayı çalıştırın.
2. İstendiğinde, 5 farklı kahve ismi girin.
3. Program, girdiğiniz kahve isimlerini listeleyecektir.

## Kod Örneği

```csharp
using System;

Console.WriteLine("Kahve Listesi Oluşturucu");
Console.WriteLine("-------------------------");

List<string> kahveler = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i}. kahve adını giriniz: ");
    string kahveAdi = Console.ReadLine();
    
    while (string.IsNullOrWhiteSpace(kahveAdi))
    {
        Console.Write("Lütfen geçerli bir kahve adı giriniz: ");
        kahveAdi = Console.ReadLine();
    }
    
    kahveler.Add(kahveAdi);
}

Console.WriteLine("\nGirilen Kahve İsimleri:");
Console.WriteLine("-------------------------");
foreach (string kahve in kahveler)
{
    Console.WriteLine($"- {kahve}");
}

Console.WriteLine("\nKahve listeniz hazır. Afiyet olsun!");
```


## Katkıda Bul
