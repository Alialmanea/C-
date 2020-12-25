// C# program to find the number of charters 
// in the longest word in the sentence. 
using System; 
  
class MainClass { 
      
    static int secondLongestWordLength(string str){ 
        int n = str.Length; 
        int res = 0, curr_len = 0; 
        for (int i = 0; i < n; i++) { 
            if (str[i] != ' ') 
                curr_len++; 
            else{ 
                res = Math.Max(res, curr_len); 
                curr_len = 0; 
            } 
        } 
      
        return Math.Min(res, curr_len); 
    }
    static string findWordLength(string str, int l){
      String[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++) { 
          if(words[i].Length == l)
          return  words[i];
        }
        return null; 
    } 
  
    public static void Main() {
       Console.WriteLine("En uzun 2.kelimeyi bulmak istediğiniz metin giriniz:");
        string s = Console.ReadLine(); 
        Console.Write("En uzun 2.kelimeyi metinde: "+findWordLength(s,secondLongestWordLength(s))); 
    } 
} 
  
