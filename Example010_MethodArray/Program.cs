int[] array = {1, 12, 31, 4, 51, 16, 17, 18};

int n = array.Length;
int find = 18; // we will look where '4' in the array
int index = 0; // counter

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // if there are more than one number, 
            //we get the first one and then break out of the programm
    }
    index ++;
}

