int sum = 0;
int[] nums = new int[10];

Random rand = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = ran.Next() % 100;
}

for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
}
Console.WriteLine(sum);