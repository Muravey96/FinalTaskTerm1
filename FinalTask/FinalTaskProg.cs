Console.Clear();

Console.Write("Введите целое число - Сколько элементов необходимо проверить; нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] userArray = FillArray(userNum);
string[] finalArray = RemoveUnsuitElem(userArray, 3); 
Console.WriteLine($"{String.Join(" ", userArray)}  -> {String.Join(" ", finalArray)}");

////////////////////////

string[] FillArray(int n)
{
    string[] filledArray = new string[n];
    Console.WriteLine($"Введите {n} элемента/ов:");
    for (int i = 0; i < n; i++) filledArray[i] = Console.ReadLine() ?? "";    
    return filledArray;
}

////////////////////////

string[] RemoveUnsuitElem(string[] newArray, int num)
{
    int count = 0; 
    int[] with_restrictions = new int[newArray.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= num) 
        {
            with_restrictions[count] = i;
            count++;
        }
    }
    string[] resultArray = new string[count];
    for (int j = 0; j < count; j++) resultArray[j] = newArray[with_restrictions[j]];
    return resultArray;
}