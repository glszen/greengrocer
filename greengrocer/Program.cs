// 1 ) If-else ile:

Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger bütün meyveler = 4 TL");

string elma = "2";
string armut = "3";
string çilek = "2";
string muz = "3";
string diger = "4";


Console.Write("\nHangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");

string meyve = Console.ReadLine();


if (meyve == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyati: " + elma + " Tl'dir");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyati: " + armut + " Tl'dir");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyati: " + çilek + " Tl'dir");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyati: " + muz + " Tl'dir");
}
else if (meyve == "diğer")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyati: " + diger + " Tl'dir");
}
else
{
    Console.WriteLine("Böyle bir meyve bulunmamaktadır.");
}




// 2) Switch-case ile:

Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diger bütün meyveler = 4 TL");

Console.Write("\nHangi meyveyi satin almak istersiniz? (Elma/Armut/Çilek/Muz/Diger): ");

int Meyveler = Convert.ToInt32(Console.ReadLine());

switch (Meyveler)
{
    case 0:
        Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2 TL'dir.");
        break;

    case 1:
        Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3 TL'dir.");
        break;

    case 2:
        Console.WriteLine("Seçtiğiniz meyvenin fiyati: 2 TL'dir.");
        break;

    case 3:
        Console.WriteLine("Seçtiğiniz meyvenin fiyati: 3 TL'dir.");
        break;

    case 4:
        Console.WriteLine("Seçtiğiniz meyvenin fiyati: 4 TL'dir.");
        break;

    default:
        Console.WriteLine("Geçersiz bir veri girdiniz.");
        break;

}

enum Meyveler //Değerleri listeden seçebilmek için bir enumlist oluşturuldu.
{
    Elma,
    Armut,
    Çilek,
    Muz,
    Diğer
}

//Bu problemi switch-case yapısı ile çözmek daha doğru, liste şeklinde bir seçim uygulaması switch-case ile daha pratik.