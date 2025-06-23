Console.WriteLine("Rüya Manavına Hoşgeldiniz!"); // Print welcome message to the user
Console.WriteLine("Elma = 2 TL"); // Print the price of apple
Console.WriteLine("Armut = 3 TL"); // Print the price of pear
Console.WriteLine("Muz = 4 TL"); // Print the price of banana
Console.WriteLine("Diger bütün meyveler = 4 TL"); // Print the price of all other fruits as default price

Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Diğer): ");// Prompt the user to enter the name of the fruit they want to buy
string fruitName = Console.ReadLine().ToLower(); // Read user input and convert it to lowercase for case-insensitive comparison
if (fruitName == "elma") //cheching if the input is apple
{     Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); // Print the price of apple  
}
else if (fruitName == "armut") //checking if the input is armut
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL"); // Print the price of pear
}
else if (fruitName == "muz") //checking if the input is muz
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); // Print the price of banana
}
else //if the input is not any of the above fruits
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); // Print the default price for all other fruits
}


// For this fruit price selection scenario with fixed input values, switch-case offers cleaner and more readable code than if-else.