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