
Orchestrate();
double[] GetInput()
{
    bool isInt = true;
    double len;
    double width;
    double height;
    while (true)
    {
        Console.WriteLine("What is the length of the classroom?");
        isInt = double.TryParse(Console.ReadLine(), out len);
        if (!isInt)
        {
            Console.WriteLine("Valid doubles only bruh...");
            continue;
        }
        Console.WriteLine("What is the width of the classroom?");
        isInt = double.TryParse(Console.ReadLine(), out width);
        if (!isInt)
        {
            Console.WriteLine("Valid doubles only bruh...");
            continue;
        }
        Console.WriteLine("What is the height of the classroom?");
        isInt = double.TryParse(Console.ReadLine(), out height);
        if (!isInt)
        {
            Console.WriteLine("Valid doubles only bruh...");
            continue;
        }
        return new double[] { len, width, height };
    }
}

double GetArea(double[] values)
{
    return values[0] * values[1];
}
double GetVolume(double[] values)
{
    return values[0] * values[1] * values[2];
}
double GetPerimeter(double[] values)
{
    return (values[0] * 2) + (values[1] * 2);
}
double GetSurfaceArea(double[] values)
{
    return 2 * ((values[0] * values[1]) + (values[2] * values[1]) + (values[2] * values[0]));
}

string JudgeRoomArea(double[] values)
{
    switch (GetArea(values))
    {
        case <= 250:
            return "smoll";
        case <= 650:
            return "medium";
        case > 650:
            return "LARGE";
        default:
            return "";
    }
}

void Orchestrate()
{
    double[] values = GetInput();
    Console.WriteLine($"The area of the classroom is {GetArea(values)} square feet");
    Console.WriteLine($"The perimeter of the classroom is {GetPerimeter(values)} feet");
    Console.WriteLine($"The volume of the classr0om is {GetVolume(values)} cubic feet");
    Console.WriteLine($"The surface area of the classroom is {GetSurfaceArea(values)} square feets!");
    Console.WriteLine($"The classroom is {JudgeRoomArea(values)}");
}
