﻿Console.WriteLine("Rüya Manavına Hoşgeldiniz!"); // Print welcome message to the user
Console.Write("\nElma = 2 TL"); // Print the price of apple
Console.Write("\nArmut = 3 TL"); // Print the price of pear
Console.Write("\nMuz = 4 TL"); // Print the price of banana
Console.Write("\nDiger bütün meyveler = 4 TL"); // Print the price of all other fruits as default price

Console.Write("\nLütfen almak istediğiniz meyvenin adını giriniz: "); // Prompt the user to enter the name of the fruit they want to buy
switch (Console.ReadLine().ToLower()) // Read user input and convert it to lowercase for case-insensitive comparison
{
    case "elma": // Check if the input is "elma"
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); // Print the price of apple  
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL"); // Print the price of pear
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); // Print the price of banana
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL"); // Print the default price for all other fruits
        break;
}


Console.WriteLine("Rüya Manavına Hoşgeldiniz!"); // Print welcome message to the user
Console.WriteLine("Elma = 2 TL"); // Print the price of apple
Console.WriteLine("Armut = 3 TL"); // Print the price of pear
Console.WriteLine("Muz = 4 TL"); // Print the price of banana
Console.WriteLine("Diger bütün meyveler = 4 TL"); // Print the price of all other fruits as default price

//Second Part of the code using if-else statements
Console.WriteLine("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Diğer): ");// Prompt the user to enter the name of the fruit they want to buy
string fruitName = Console.ReadLine().ToLower(); // Read user input and convert it to lowercase for case-insensitive comparison
if (fruitName == "elma") //cheching if the input is apple
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL"); // Print the price of apple  
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


// As a summary for this fruit price selection scenario with fixed input values, switch-case offers cleaner and more readable code than if-else.