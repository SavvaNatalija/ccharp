int[] array = {11,12,33,59,84,45,66,17,88,59};

int n =array.Length;
int find = 59;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }



    index++;

}