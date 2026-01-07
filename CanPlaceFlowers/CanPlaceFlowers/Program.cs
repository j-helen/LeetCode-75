public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int len = flowerbed.Length;
        for(int i=0; i<len; i++)
        {
            if(flowerbed[i]==0)
            {
                bool leftEmpty = (i==0) || (flowerbed[i-1]==0);
                bool rightEmpty = (i==len-1) || (flowerbed[i+1]==0);

                if(leftEmpty && rightEmpty)
                {
                    flowerbed[i] = 1;
                    n--;
                    if(n==0)
                    return true;
                }
            }
        }
        return n<=0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] case1Flowerbed = new int[] {1,0,0,0,1};
        int case1N = 1;
        int[] case2Flowerbed = new int[] {1,0,0,0,1};
        int case2N = 2;
        bool case1 = solution.CanPlaceFlowers(case1Flowerbed, case1N);
        Console.WriteLine(case1); // Output: True
        bool case2 = solution.CanPlaceFlowers(case2Flowerbed, case2N);
        Console.WriteLine(case2); // Output: False
    }
}