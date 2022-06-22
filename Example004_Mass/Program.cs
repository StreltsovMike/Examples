int[] array1 = new int[] { 3,3,4,2,5,7,2,8,13,4,9 };
var str = string.Join(" ", array1);
Console.Write("Массив :");
Console.WriteLine(str);

int count = 0;
int max = array1[1];

while(count<11) 
{
    if(array1[count] > max) 
    {
        max = array1[count];
    }
    count++;
}

Console.Write("Максимальное число : " + max);