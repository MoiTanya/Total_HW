// Программа, формирующая из имеющегося массива строк, новый массив строк, в который включены строки длиной менее или равной 3 символам

//Создадим метод, создающий из имеющегося массива строк новый массив строк, в который включены строки длиной менее или равной 3 символам 
string[] StringArrayLess3Simbol(string[] arr)
{
    int count = 0;
    //Определим количество строк с длиной менее 3-х символов
    for (int i=0; i<arr.Length; i++)
    {   
        if (arr[i].Length <=3) 
        count++;
    }
    //Создадим результирующий массив строк
    string[] ResultArr = new string[count];
    // 
    int ind = 0;
    for (int i=0; i<arr.Length; i++)
    {
        //Console.WriteLine(arr[i]);
        if (arr[i].Length <=3)
        {
            ResultArr[ind] = arr[i];
            ind++;
        } 
       
    } 
    return ResultArr;
}

//Создадим метод вывода в консоль всех строк массива
void PrintStringArray (string[] arr)
{
    if(arr.Length == 0)
    {
        Console.WriteLine("В исходном массиве нет строк менее или равные 3 символам!");
        return;
    }
    for (int i=0; i<arr.Length; i++)
    Console.WriteLine(arr[i]);
}

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Программа, формирующая из имеющегося массива строк, новый массив строк, в который включены строки длиной менее или равной 3 символам");
Console.WriteLine();
Console.WriteLine("Для работы программы необходимо ввести массив строк");
Console.WriteLine("Введите количество желаемых строк в массиве");

int ArrStrLength = Convert.ToInt32(Console.ReadLine());
string[] UsersStringArray = new string[ArrStrLength]; 
for (int i=0; i<UsersStringArray.Length; i++)
{
    Console.WriteLine($"Введите {(i+1)} строку");
    UsersStringArray[i] = Console.ReadLine();
}
string[] NewStringArr = StringArrayLess3Simbol(UsersStringArray);
Console.WriteLine();
Console.WriteLine("Результат: ");
PrintStringArray(NewStringArr);
