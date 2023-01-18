using System;

string name = "Viola";
char sex = 'K';
int age = 27;

if (sex == 'K' && age < 28)
{
    Console.WriteLine("kobieta ponziej 27 Wiosen");
}
else if (name == "Viola" && age == 28)
{
    Console.WriteLine("Jestem Viola 28 Lat");
}
else
{
    if (sex == 'M' && age < 18)
    {
        Console.WriteLine("niepelnoletni mezczyzna");
    }
}


