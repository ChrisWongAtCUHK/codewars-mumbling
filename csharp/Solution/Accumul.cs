using System.Linq;

public class Accumul
{
  public static string Accum(string s)
  {
    s = s.ToUpper();
    string[] arr = s.ToCharArray().Select(c => c.ToString()).ToArray();
    for (int i = 0; i < arr.Length; i++)
    {
      for (int j = 0; j < i; j++)
      {
        arr[i] += s[i].ToString().ToLower();
      }
    }
    return string.Join("-", arr);
  }
}