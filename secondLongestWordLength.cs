// C# program to find the number of charters 
// in the longest word in the sentence. 
using System; 
  
class MainClass { 
      
    static int secondLongestWordLength(string st){ 
        int n = str.Length; 
        int res = 0, curr_len = 0; 
        for (int i = 0; i < n; i++) { 
              
            // If current character is not 
            // end of current word. 
            if (str[i] != ' ') 
                curr_len++; 
      
            // If end of word is found 
            else{ 
                res = Math.Max(res, curr_len); 
                curr_len = 0; 
            } 
        } 
      
        // We do max one more time to consider 
        // last word as there won't be any space 
        // after last word. 
        return Math.Min(res, curr_len); 
    } 
  
    public static void Main() { 
        string s = "ali rashad almanea1995"; 
        Console.Write(secondLongestWordLength(s)); 
    } 
} 
  
