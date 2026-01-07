/*
For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

 

Example 1:

Input: str1 = "ABCABC", str2 = "ABC"

Output: "ABC"

Example 2:

Input: str1 = "ABABAB", str2 = "ABAB"

Output: "AB"

Example 3:

Input: str1 = "LEET", str2 = "CODE"

Output: ""

Example 4:

Input: str1 = "AAAAAB", str2 = "AAA"

Output: ""​​​​​​​

 

Constraints:

    1 <= str1.length, str2.length <= 1000
    str1 and str2 consist of English uppercase letters.


*/

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
      if(str1 + str2 != str2 + str1)
      { return "";}
      
      int substringLen = GCD(str1.Length, str2.Length);

      return str1.Substring(0, substringLen);
    }

    public int GCD(int a, int b)
    {
        if(b==0)
        return a;

        return GCD(b, a%b);
    }
}

public class Program { 
    public static void Main(string[] args) { 
        Solution solution = new Solution(); 
        Console.WriteLine(solution.GcdOfStrings("ABCABC", "ABC")); // Output: "ABC" 
        Console.WriteLine(solution.GcdOfStrings("ABABAB", "ABAB")); // Output: "AB" 
        Console.WriteLine(solution.GcdOfStrings("LEET", "CODE")); // Output: ""
        Console.WriteLine(solution.GcdOfStrings("AAAAAB", "AAA")); // Output: "" 
    } 
}