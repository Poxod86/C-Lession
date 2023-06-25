int[] array = {1,12,3,34,5,36,74,8};

int n = array.Length;
int find  = 74;

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
