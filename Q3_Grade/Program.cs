Console.Write("Enter marks: ");
int marks = int.Parse(Console.ReadLine());

Console.WriteLine("Marks: " + marks);


if (marks % 2 == 0)
{
    Console.WriteLine(marks + " is Even");
}
else
{
    Console.WriteLine(marks + " is Odd");
}

// Part B: Grade
if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade C");
}
else if (marks >= 40)
{
    Console.WriteLine("Grade D");
}
else
{
    Console.WriteLine("Fail");
}