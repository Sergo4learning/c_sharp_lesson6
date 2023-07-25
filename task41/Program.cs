// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] get_array(int num)
{
    int[] coord = new int[num];    
    for (int i = 1; i<=num; i++)
    {
        Console.Write("Введите "+i+" Элемент массива: ");
        coord[i-1] = Convert.ToInt32(Console.ReadLine());
    }    
    return coord;
}
int how_many_pos_num(int[] arr,int num)
{
    int kol=0;
    for (int i=1; i<=num;i++)
    {
        if (arr[i-1]>0)
        {
            kol++;
        }
    }
    return kol;
}
Console.Write("Введите размерность массива: ");
int arr_dim = Convert.ToInt32(Console.ReadLine());
int[] array = get_array(arr_dim);
int rez=how_many_pos_num(array,arr_dim);
Console.WriteLine(rez);