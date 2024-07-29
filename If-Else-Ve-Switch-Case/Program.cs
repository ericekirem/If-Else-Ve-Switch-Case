

Console.WriteLine("Rüya manavında fiyatlar çok uygun!");

Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");


Console.WriteLine("Hangi meyveyi satın almak istersiniz? (ELma/Armut/Çilek/Muz/Diğer):");
string meyve = Console.ReadLine().ToLower();

if (meyve == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL ");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
}
else
{
    Console.WriteLine("Diğer bütün meyvelerin fiyatı : 4 TL");
}



Console.WriteLine("---------------------------------------");


Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
string fruit = Console.ReadLine().ToLower();

switch (fruit)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;
}

// if daha karmaşık durumları kontrol etmek için ideal ama verilen ifadedeki gibi belirli durumlar arasında seçim yapacaksak switch daha düzenli ve mantıklı bir seçenek.
