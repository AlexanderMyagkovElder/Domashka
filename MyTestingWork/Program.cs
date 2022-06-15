/*Написать программу,которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо
равна 3 символа.Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.*/
Console.WriteLine("Введите количество используемых строк: ");
int kolvoStrok=Convert.ToInt32(Console.ReadLine());
string strokaMama=String.Empty;
int dlinnaMassiva=0;
for (int i = 0; i < kolvoStrok; i++)
{
    string? temp=EnterStrings($"Введите {i+1} строку: ");
    if (temp?.Length<4)
    {
        strokaMama+=temp;
        dlinnaMassiva+=temp.Length;
    }
}
char[] answerArray=new char[dlinnaMassiva];
answerArray=strokaMama.ToArray();
PrintArray(answerArray);

string? EnterStrings(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}
void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
