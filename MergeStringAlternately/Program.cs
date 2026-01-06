/*
You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.

 

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r

Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s

Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d

 

Constraints:

    1 <= word1.length, word2.length <= 100
    word1 and word2 consist of lowercase English letters.

*/

using System;
using System.Text;

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1 = word1.Length;
        int n2 = word2.Length;
        var result = new StringBuilder(n1 + n2);
        int i = 0, j = 0;

        while (i < n1 || j < n2) {
            if (i < n1) {
                result.Append(word1[i]);
                i++; // move pointer for word1
            }
            if (j < n2) {
                result.Append(word2[j]);
                j++; // move pointer for word2
            }
        }

        return result.ToString();
    }
}

public class Program {
    public static void Main(string[] args) {       
        Solution solution = new Solution();
        string merged = solution.MergeAlternately("abc", "pqr");

        Console.WriteLine(merged); // Output: apbqcr
    }
}
