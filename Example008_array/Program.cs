/*

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; 
}//            0   1   2   3   4   5   6   7   8
int[] array = {11, 21, 31, 41, 15, 61, 17, 211, 19};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    
    if(array[index] == find)
        {
            Console.WriteLine(index);
        }
        //index = index +1;
        index++;
}


int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    
    if(array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
        //index = index +1;
        index++;
}

*/
