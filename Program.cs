Console.Clear();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    switch (val)
    {
        case "1":
            SparaAnteckning();
            break;

        case "2":
            LäsaAnteckning();
            break;

        case "3":
            Console.WriteLine("Godmorgon Godnatt");
            return;

        default:
            Console.WriteLine("Fel val, försök igen: ");
            break;
    }
}


static void VisaMeny() {
    Console.WriteLine("Dessa alternativ finns");
    Console.WriteLine("1. Spara Anteckningar");
    Console.WriteLine("2. Läs upp dina anteckningar");
    Console.WriteLine("3. Avsluta programmet");
    Console.Write("Vad vill du göra? Svara endast med siffran för varje alternativ: ");
}

static void LäsaAnteckning() {
    string anteckning = File.ReadAllText("Anteckningstest.txt");
    Console.WriteLine(anteckning);
}

static void SparaAnteckning() {
    
    Console.Write("Vad vill du anteckna?: ");
    string anteckning = Console.ReadLine();

    // Spara i textfil
    File.AppendAllText("Anteckningstest.txt", " " + anteckning);
}

// Ville testa Appendtext ifall det skulle lägga till extra text istället för att skriva över det -
// - som redan fanns i textfilen som WriteAllText gör, men det öppnade bara nya tomma textfiler med orden jag skrev.

// Extra: Antagligen fungerar AppendAllText för det jag ville testa så jag var inte så långt ifrån svaret jag sökte!