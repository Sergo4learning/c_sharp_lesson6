// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float[] get_coof()
{
    float[] cooficient = new float[2];    
    Console.Write("Введите угловой коэффициент прямой (k): ");
    cooficient[0] = (float)Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите свободный коэффициент прямой (b): ");
    cooficient[1] = (float)Convert.ToDouble(Console.ReadLine());    
    return cooficient;
}
void output_answer(float[] arr)
{
    switch (arr[2])
    {
        case 0:
            Console.WriteLine("Прямые совпадают.");
            break;
        case -1:
            Console.WriteLine("Прямые не пересекаются.");
            break;
        case 1:
            Console.WriteLine("("+arr[0]+"; "+arr[1]+")");
            break;
        default:
        Console.WriteLine("Произошло что то странное и непредвиденное.");
        break;
    }
}
float[] intersection_point(float[] arr1,float[] arr2)
{
    float[] intersection_coord = new float[3];
    intersection_coord[2] = 1;
    if (arr1[0]==arr2[0])
    {
        if (arr1[1]==arr2[1])
        {
            intersection_coord[2] = 0;
        }
        else
        {
            intersection_coord[2] = -1;
        }
    }
    else
    {
        intersection_coord[0] =(arr1[1]-arr2[1])/(arr2[0]-arr1[0]);
        intersection_coord[1] =arr1[0]*intersection_coord[0]+arr1[1];
    }
    return intersection_coord;
}
float[] first_line = get_coof();
float[] second_line = get_coof();
float[] intersect_point = intersection_point(first_line,second_line);
output_answer(intersect_point);