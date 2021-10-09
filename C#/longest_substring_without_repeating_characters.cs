using System;

public class LongestSubstringWithoutRepeatingCharacters
{
	public static void Main()
    {
        string s = Console.ReadLine();
        Console.WriteLine(LengthOfLongestSubstring(s));
    }

    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length <= 1)
        {
            return s.Length;
        }

        int end = 0;
        int start = 0;
        int maxLength = 0;

        Dictionary<char, int> currChars = new Dictionary<char, int>();

        while (end < s.Length)
        {
            int tempLength = end - start;
            if (currChars.ContainsKey(s[end]))
            {
                maxLength = Math.Max(tempLength, maxLength);
                currChars.Remove(s[start]);
                start = start + 1;
            }
            else
            {
                maxLength = Math.Max(tempLength + 1, maxLength);
                currChars.Add(s[end], end);
                end = end + 1;
            }
        }

        return maxLength;
    }
}

// Given a string s, find the length of the longest substring without repeating characters.

// Example 1:
// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.

// Example 2:
// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.

// Example 3:
// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

// Example 4:
// Input: s = ""
// Output: 0

// Time Complexity: O(n)
// Space Complexity: O(n)