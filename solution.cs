using System;
using System.Text;
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }
  }
}
