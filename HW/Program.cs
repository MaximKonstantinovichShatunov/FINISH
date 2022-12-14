string[] array = new string[] { "1234", "157", "-2", "computer", "PIG", "999", "777" };

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        Console.Write($"{array[i]} ");
    }
}

