// Создать программу, которая будет генерировать 
//случайный массив из 10 членов и находит индекс искомого значения
System.Console.WriteLine(" ");
System.Console.WriteLine("Здравствуйте! Керим написал программу, которая по заданным параметрам генерирует ");
System.Console.WriteLine("случайный массив, а потом находит в нем индекс искомого вами значения ");
System.Console.WriteLine(" ");
System.Console.WriteLine("Если Керим - красавчик введите 1");
int UserLove = Convert.ToInt32(Console.ReadLine());
if (UserLove==1)
{
System.Console.WriteLine(" ");
System.Console.WriteLine("Ему будет приятно)))");
System.Console.WriteLine("Теперь можем приступать");
System.Console.WriteLine(" ");
System.Console.WriteLine("Введите количество значений массива");
int UserLenght = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное допустимое значение в массиве");
int UserMin = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное допустимое значение в массиве");
int UserMax = Convert.ToInt32(Console.ReadLine());
while (UserMin>UserMax)
{
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Так не пойдет. Минимальное должно быть больше максимального");
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Давай попробуем еще раз");
    System.Console.WriteLine("Введите минимальное допустимое значение в массиве");
    UserMin = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите максимальное допустимое значение в массиве");
    UserMax = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("Введите искомое значение");
int find = Convert.ToInt32(Console.ReadLine());
while (UserMin>find || UserMax<find)
{
    System.Console.WriteLine("Кажется искомое значение не вписывается в диапазон массива. Чтобы изменить диапазон введите 0, ");
    System.Console.WriteLine("чтобы изменить искомое значение введите 1");
    int UserChois = Convert.ToInt32(Console.ReadLine());
    while (UserChois!=0 && UserChois!=1)
    {
        System.Console.WriteLine("Введите 0, чтобы изменить диапазон или 1, чтобы изменить искомое значение");
        UserChois = Convert.ToInt32(Console.ReadLine());
    }
    if (UserChois==0)
    {
    System.Console.Write("Введите минимальное допустимое значение в массиве. Оно должно быть меньше ");
    System.Console.WriteLine(find);
    UserMin = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите максимальное допустимое значение в массиве. Оно должно быть больше ");
    System.Console.WriteLine(find);
    UserMax = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        System.Console.Write("Введите значение от ");
        System.Console.Write(UserMin);
        System.Console.Write(" до ");
        System.Console.WriteLine(UserMax);
        find = Convert.ToInt32(Console.ReadLine());
    }
}

int[] array = new int [UserLenght];
int lengnt = array.Length;
int index = 0;
int result = -1;
// for (index =0; index<lengnt-1; index++)
// {
//     array [index]= new Random().Next(0,11);
//     System.Console.Write(array[index]);
//     if (find == array[index])
//     {
//         System.Console.WriteLine(index);
    
//     }
   
// }
// сделать функцию определения длинны массива и сравнения find c array [index] столько раз, сколько членов в массиве. Если find не равен ни одному из array [index], то написать, что искомого значения в массиве нет
System.Console.Write("Сгенерированный массив: ");
while (index<lengnt)
{
    array [index] = new Random().Next(UserMin,UserMax+1);
    if (index<lengnt-1)
    {
        System.Console.Write(array[index]);
        System.Console.Write(", ");
    }
    else
    {
        System.Console.Write(array[index]);
        System.Console.WriteLine(".");
    }
    if (find == array[index])
    {
        result = index;
        index++;
    }
    else
    {
        index++;
    }
}
if (result == -1)
{
    System.Console.WriteLine("Искомого значения в сгенерированном массиве нет");
}
else
{
    System.Console.Write("Индекс искомого значения: ");
    System.Console.WriteLine(result);
}
System.Console.WriteLine("Конец алгоритма. Печеньку?");
}
else
{
    System.Console.WriteLine("Ой, ну и ладно!");
}