string customerInput = "42";
int result;
int.TryParse(customerInput, out result);
Console.WriteLine("Dönüşüm tamamlanmıştır: "+ result);
