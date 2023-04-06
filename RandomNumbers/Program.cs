

#region Random even 10 numbers
//int[] numbers = new int[10];

//Random random = new();

#region With While
//int i = 0;
//while (i < numbers.Length)
//{
//    var randomNumber = random.Next(1, 100);
//    if (randomNumber % 2 == 0)
//    {
//        numbers[i] = randomNumber;
//        i++;
//    }
//}
#endregion

#region with for
//for (int i = 0; i < numbers.Length; i++)
//{
//    var randomNumber = random.Next(1, 100);
//    if (randomNumber % 2 == 0)
//        numbers[i] = randomNumber;
//}
#endregion

//Console.WriteLine("Random Numbers: ");
//int queue = 1;
//foreach (var number in numbers)
//{
//    if (number > 0)
//        Console.WriteLine($"{queue}: " + number);
//    queue++;
//}
#endregion

#region Random unique numbers

GenerateRandomNumbers(100, 0,200);

void GenerateRandomNumbers(int quantity,int startNumber,int lastNumber)
{
    int[] numbers = new int[quantity];
    Random random = new();

    for (int i = 0; i < numbers.Length; i++)
    {
        var randomNumber = random.Next(startNumber, lastNumber);
        if (Array.IndexOf(numbers, randomNumber) > -1)
        {
            i--;
            continue;
        }
        numbers[i] = randomNumber;
    }

    Console.Write("Random Numbers: ");
    foreach (var number in numbers)
    {
        Console.Write(number +", ");
    }
}
#endregion