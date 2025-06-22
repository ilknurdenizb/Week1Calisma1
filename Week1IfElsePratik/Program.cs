Console.Write("Lütfen bir sayı giriniz: ");
int input = Convert.ToInt32(Console.ReadLine()); // get user input then convert to integer

if (input > 10) // check if the input is greater than 10
{ Console.WriteLine("Sayı 10'dan büyüktür."); }  // after checking print this message
else if ( input < 10) // check if input is smaller than 10
{ Console.WriteLine("Sayı 10'dan küçüktür."); } // if it is smaller than 10, print this message
else if ( input == 10) // check if input is equal to 10
{
    Console.WriteLine("Sayı 10!a eşittir."); // if it is equal to 10, print this message
}
  if (input %2 == 0) // check if the input is even by using modulus operator
    Console.WriteLine("Sayı çift sayıdır."); // if condition is true, print this message
else if ( input %2 != 0) // check if the input is odd by using modulus operator
{ Console.WriteLine("Sayı tek sayıdır."); } // if condition returns true, print this message
