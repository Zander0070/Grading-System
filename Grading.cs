int[] ZanderMarks = { 99, 68, 30, 87, 100 };
string[] ZanderSubjects = { "Maths", "Life-S", "LO", "Chemie", "Physics" };
string prompt = "";
Console.WriteLine("Zander Report Card\n");
Console.WriteLine("Subject\t\t\tMarks\tGrade\n");

for (int i = 0; i < ZanderMarks.Length; i++)
{
    
    if (ZanderMarks[i] > 90)
    {
        prompt = "A+";
    } else if (ZanderMarks[i] > 80 && ZanderMarks[i] < 91)
    {
        prompt = "A";
    } else if (ZanderMarks[i] < 81 && ZanderMarks[i] > 70){
        prompt = "B";
    } else if(ZanderMarks[i] < 71 && ZanderMarks[i] > 60){
        prompt = "C";
    }
    else {
        prompt = "F";
    }

    Console.WriteLine($"{ZanderSubjects[i]}\t\t\t{ZanderMarks[i]}\t{prompt}");
}
