//Says hello
Console.WriteLine("Hello, User!");
//Asks for first name
Console.WriteLine("Please insert first name");
//Code to enter first name
string firstName = Console.ReadLine();
// Introduces to you with first name, asks for last name
Console.WriteLine($"Hello {firstName}, please specify with last name");
//Code to enter last name
string lastName = Console.ReadLine();
//Thanks you with you full name, first and Last
Console.WriteLine($"Thank you, Hello {firstName} {lastName}");