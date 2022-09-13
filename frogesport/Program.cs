int point = 0;
string answer = "";
string restart = "ja";

Console.WriteLine("Välkommen till frågesporten :)");
while (restart == "ja")
{
    while (answer != "a" && answer != "b" && answer != "c" && answer != "d")
    {   
        Console.WriteLine("Hur många dagar är det i augusti?");
        Console.WriteLine("a: 28.");
        Console.WriteLine("b: 30");
        Console.WriteLine("c: 31");
        answer = Console.ReadLine();

        if (answer == "a")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "d";
        }
        else if (answer == "b")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "d";
        }
        else if (answer == "c")
        {
            point++;
            Console.WriteLine($"Rätt svar, du har {point} poäng");
            answer = "d";
        }
        else
        {
            Console.WriteLine("Felaktig input, skriv a, b eller c");
            answer = "";

        }
    }
    while (answer != "a" && answer != "b" && answer != "c" && answer != "e")
    {   

        Console.WriteLine("Hur många veckor är det på ett år?");
        Console.WriteLine("a: 100");
        Console.WriteLine("b: 52");
        Console.WriteLine("c: 51");
        answer = Console.ReadLine();

        if (answer == "a")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "e";
        }
        else if (answer == "c")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "e";
        }
        else if (answer == "b")
        {
            point++;
            Console.WriteLine($"Rätt svar, du har {point} poäng");
            answer = "e";
        }
        else
        {
            Console.WriteLine("Felaktig input, skriv a, b eller c");
            answer = "";
        }
    } 
    while (answer != "a" && answer != "b" && answer != "c" && 
    answer != "f")
    {
        Console.WriteLine("Vilket datum är jag född?");
        Console.WriteLine("a: 08/08");
        Console.WriteLine("b: 10/12");
        Console.WriteLine("c: 23/9");
        answer = Console.ReadLine();
        if (answer == "c")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "f";
        }
        else if (answer == "b")
        {
            Console.WriteLine($"Fel svar, du har {point} poäng");
            answer = "f";
        }
        else if (answer == "a")
        {
            point++;
            Console.WriteLine($"Rätt svar, du har {point} poäng");
            answer = "f";
        }
        else
        {
            Console.WriteLine("Felaktig input, skriv a, b eller c");
            answer = "";
        }
    }
Console.WriteLine("Vill du spela igen?");
restart = Console.ReadLine();

if (restart == "ja")
{
    Console.WriteLine("Okej, lycka till");
    point = 0;
}
else
{
    Console.WriteLine("Fett synd, du kanske skrev fel jag vet inte och bryr mig inte orkar inte skriva mer kod för fel inputs, ");
    Console.WriteLine("Hejdå");
}
}




Console.ReadLine();
