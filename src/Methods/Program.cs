
void SayHello()
{
    Console.WriteLine("Hello"); // void SayHello() => Console.WriteLine("Hello");
}

SayHello(); // Hello
SayHello(); // Hello

void SayHelloEn()
{
    Console.Write("Hello");
}
void SayHelloFr()
{
    Console.WriteLine("Salut");
}
void SayHelloRu()
{
    Console.WriteLine("Ку");
}

string language = "en";

switch (language)
{
    case "en":
        SayHelloEn();
        break;
    case "fr":
        SayHelloFr();
        break;
    case "ru":
        SayHelloRu();
        break;
}


void PrintMessage(string message)
{
    Console.WriteLine(message);
}

PrintMessage("Hello work");           // Hello work
PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
PrintMessage("Hello C#");             // Hello C#

void Sum(int x, int y) => Console.WriteLine($"x+y={x + y}");

Sum(10, 5);

void PrintPerson(string name, int age = 1, string company = "Undefined")
{
    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
}

PrintPerson("Tom", 37, "Microsoft");  // Name: Tom  Age: 37  Company: Microsoft
PrintPerson("Tom", 37);               // Name: Tom  Age: 37  Company: Undefined
PrintPerson("Tom");                   // Name: Tom  Age: 1   Company: Undefined


PrintPerson("Tom", company: "Valve", age: 45);
PrintPerson(company: "Blizzard", name: "Bobby");