string[] Array1 = { "hello", "2", "world", ":-)" };
string[] Array2 = { "12345", "1567", "-2", "computer science" };
string[] Array3 = { "Russia", "Denmark", "Kazan" };
int size = 0;
void numbersOfLines(string[] numbsOfArray)
{
    int count = 0;
    int sizeArray = numbsOfArray.Length;
    for (int i = 0; i < sizeArray; i++)
    {
        if (numbsOfArray[i].Length <= 3)
        {
            count++;
        }
    }
    size = count;
}
void sortArray(string[] unsortArray)
{
    string[] SortedArray = new string[size];
    int sizeArray = unsortArray.Length;
    int index = 0;
    for (int j = 0; j < sizeArray; j++)
    {
        if (unsortArray[j].Length <= 3)
        {
            SortedArray[index] = unsortArray[j];
            index++;
        }
    }
    Console.WriteLine(String.Join(" ", SortedArray));
}
numbersOfLines(Array1);
sortArray(Array1);
