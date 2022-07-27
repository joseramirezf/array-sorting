Console.WriteLine("\nArray Sorting");

int[] array = new int [5000];
int randomNumber;
Random randomNumbers = new Random();

Console.WriteLine("\nRandom List\n");

for (int i = 0; i < 1000; i++)
 {
 int numbers = randomNumbers.Next(0, 1000);
 array[i] = numbers;
 randomNumber = array[i];
 Console.Write(randomNumber + " ");
 }

Console.WriteLine("\n\nSorted List\n");
Array.Sort(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

