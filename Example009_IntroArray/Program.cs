int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// int a1 = 15;
// int b1 = 23;
// int c1 = 39;
// int a2 = 12;
// int b2 = 237;
// int c2 = 33;
// int a3 = 13;
// int b3 = 21;
// int c3 = 31;
int[] array = {11, 211, 31, 41, 51, 16, 17, 18, 19};

int max = Max(
        Max(array[0], array[1], array[2]), 
        Max(array[3], array[4], array[5]), 
        Max(array[6], array[7], array[8])
        );
Console.WriteLine(max);
