﻿Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
Console.Write("TC Kimlik Numarasi: ");
string tC = Console.ReadLine(); // string: although it's numeric, ID is used as a text and not for calculations
Console.Write("Adı: ");
string name = Console.ReadLine();// string: names are always text, not used in arithmetic
Console.Write("Soyadı: " );
string surname = Console.ReadLine();
Console.Write("Telefon Numarası: ");
string phonum = Console.ReadLine();// string: phone numbers can start with zero and are not used in calculations
Console.Write("Yaş: ");
int age = Convert.ToInt32(Console.ReadLine());// int: age is a whole number, so integer type is appropriate
Console.Write("İlk Aldığı ürünün fiyatı: ");
decimal firstprod = Convert.ToDecimal(Console.ReadLine());// decimal: product prices may include decimals, and decimal type is best for money values
Console.Write("İkinci Aldığı ürünün fiyatı: ");
decimal secondprod = Convert.ToDecimal(Console.ReadLine());
decimal sum1 = firstprod + secondprod;// decimal: total amount spent
decimal v = 0.10m;
decimal sale = sum1 * v;// decimal: calculated discount value
Console.WriteLine($"{tC} TC numaralı {name} {surname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phonum} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{sum1} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {sale} TL'dir");



