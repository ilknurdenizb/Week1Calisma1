Console.Write("Lütfen bir sayı giriniz: ");
int input = Convert.ToInt32(Console.ReadLine());
if (input > 10)
{ Console.WriteLine("Sayı 10'dan büyüktür."); }
else if ( input < 10 )
{ Console.WriteLine("Sayı 10'dan küçüktür."); }
else if ( input == 10 )
{
    Console.WriteLine("Sayı 10!a eşittir.");
}
  if (input %2 == 0)
    Console.WriteLine("Sayı çift sayıdır.");
else if ( input %2 != 0)
{ Console.WriteLine("Sayı tek sayıdır."); }
