using System;

Console.WriteLine("Bir bilgi yarışması yapıyoruz!"); // Start of the game
Console.WriteLine("2 cevap şıklı 3 adet sorumuz var."); // Introduction to the game

// First question
Console.WriteLine("1) Kızınca tüküren hayvan hangisidir?"); // First question of the game
Console.WriteLine("A) Deve  B) Lama");  // Options for the first question
string answer1 = Console.ReadLine().ToLower();  // Read user input and convert to lowercase
int correctAnswers = 0; // Initialize the counter for correct answers   

if (answer1 == "b" || answer1 == "lama")  // Check if the answer is correct
{
    Console.WriteLine("Doğru cevap!");  // If correct, print message
    correctAnswers++;                   // Increment the counter for correct answers
}
else if (answer1 == "a" || answer1 == "deve")  // Check if the answer is incorrect
{
    Console.WriteLine("Yanlış cevap! Doğru cevap B) Lama ");  // If incorrect, print the correct answer
}
else
{
    Console.WriteLine("Geçersiz cevap! Lütfen ya sadece şık ismi ya da seçeneği giriniz.");   // If the input is invalid, prompt the user to enter a valid answer
}

// Second question
Console.WriteLine("2) İstiklal Marşı’nın yazarı kimdir?");  // Second question of the game
Console.WriteLine("A) Mehmet Akif Ersoy  B) Namık Kemal");  // Options for the second question
string answer2 = Console.ReadLine().ToLower();           // Read user input and convert to lowercase

if (answer2 == "a" || answer2 == "mehmet akif ersoy")  // Check if the answer is correct
{
    Console.WriteLine("Doğru cevap!"); // If correct, print message
    correctAnswers++;  // Increment the counter for correct answers
}
else if (answer2 == "b" || answer2 == "namık kemal")  // Check if the answer is incorrect
{
    Console.WriteLine("Yanlış cevap! Doğru cevap A) Mehmet Akif Ersoy ");  // If incorrect, print the correct answer
}
else
{
    Console.WriteLine("Geçersiz cevap! Lütfen ya sadece şık ismi ya da seçeneği giriniz.");  // If the input is invalid, prompt the user to enter a valid answer
}

// Third question (only if less than 2 correct answers)
if (correctAnswers < 2)  // Proceed to the third question only if the user has less than 2 correct answers
{
    Console.WriteLine("3) Malazgirt Meydan Muharebesi hangi yıl yapılmıştır?");   // Third question of the game
    Console.WriteLine("A) 1071  B) 1453");  // Options for the third question
    string answer3 = Console.ReadLine().ToLower();  // Read user input and convert to lowercase

    if (answer3 == "a" || answer3 == "1071")  // Check if the answer is correct
    {
        Console.WriteLine("Doğru cevap!");  // If correct, print message
        correctAnswers++;     // Increment the counter for correct answers
    }
    else if (answer3 == "b" || answer3 == "1453")  // Check if the answer is incorrect
    {
        Console.WriteLine("Yanlış cevap! Doğru cevap A) 1071 "); // If incorrect, print the correct answer
    }
    else
    {
        Console.WriteLine("Geçersiz cevap! Lütfen ya sadece şık ismi ya da seçeneği giriniz.");  // If the input is invalid, prompt the user to enter a valid answer
    }
}

Console.WriteLine($"\nToplam doğru sayınız: {correctAnswers}"); // Print the total number of correct answers






switch (correctAnswers)  // Use a switch statement to determine the outcome based on the number of correct answers
{
    
    case 2:
        Console.WriteLine("Helal olsun! İki soruyu doğru cevapladınız."); // If the user answered both questions correctly
        break; // End of the case for 2 correct answers
    case 1:
        Console.WriteLine("Fena değil! Bir soruyu doğru cevapladınız."); // If the user answered one question correctly
        break; // End of the case for 1 correct answer
    case 0:
        Console.WriteLine("Üzgünüz, hiç doğru cevap veremediniz.");  // If the user answered no questions correctly
        break; // End of the case for 0 correct answers
    default:
        Console.WriteLine("Geçersiz sonuç!"); // If the number of correct answers is not recognized
        break; // End of the default case
}
