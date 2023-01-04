// See https://aka.ms/new-console-template for more information
Solution s = new Solution();
var list = new List<string> { "le#et", "co#de" };
var answer = s.Encode(list);
Console.WriteLine(answer);
var ll = s.Decode(answer);
Console.WriteLine(string.Join(",", ll));

public class Solution
{
  /*
   * We will use each string length+#+str format for each string from list to encode
   */
  public string Encode(List<string> list)
  {
    string str = string.Empty;
    foreach(var l in list)
    {
      str += l.Length + "#" + l;
    }
    return str;
  }

  public List<string> Decode(string str)
  {
    var result = new List<string>();
    // Example - 4#abcd
    for (int i = 0; i < str.Length; i++)
    {
      int j = i;
      while (j < str.Length && str[j] != '#') j++;
      var size = Convert.ToInt32(str.Substring(i, j - i));
      string ss = str.Substring(j + 1, size);
      result.Add(ss); 
      i = j + size;
    }

    return result;
  }
}