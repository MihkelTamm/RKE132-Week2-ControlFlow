﻿// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida tema sugu(m/f)
//rakendus küsib kasutajal sisetada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnamimi] / "Welcome, Ms. [kasutaja perekonnamimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõna) formaadis

Console.WriteLine("Please,enter your last name:");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


