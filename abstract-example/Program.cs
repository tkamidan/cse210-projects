// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book diaryofawimpykid = new Book("Diary of a Wimpy Kid", "Jeff Kinney");

mistborn.Display();
diaryofawimpykid.Display();
Console.WriteLine(mistborn.IsAvaliable());