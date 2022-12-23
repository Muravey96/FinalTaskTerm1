Console.Clear();

Console.Write("Введите целое число - Сколько элементов необходимо проверить; нажмите enter: ");
int userNum = int.Parse(Console.ReadLine() ?? "");
string[] userArray = FillArray(userNum);
string[] finalArray = RemoveUnsuitElem(userArray, 3); 
Console.WriteLine($"{String.Join(" ", userArray)}  -> {String.Join(" ", finalArray)}");

////////////////////////

