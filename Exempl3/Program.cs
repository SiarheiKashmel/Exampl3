int[] _Random = new int[20];
Random rnd = new Random();
Console.WriteLine("Исходный массив: \n");
  for (int i = 0; i < 20; i++)
  {
    _Random[i] = rnd.Next(-20, 20);
    Console.Write(" {0} ", _Random[i] );
  }
Console.WriteLine("\n\n Массив после сортировки: \n");
var orderedNumbers = from i in _Random orderby i select i;
foreach (int i in orderedNumbers)
    Console.Write(" {0}", i);



int[] nums = new int[20];
Random random = new Random();
Console.WriteLine("\n\n Исходный массив: \n");
for (int i = 0; i < 20; i++)
{
    nums[i] = random.Next(-20, 20);
    Console.Write(" {0} ", nums[i]);
}

int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

Console.WriteLine("\n\n Вывод отсортированного массива \n");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(" {0}", nums[i]);
}