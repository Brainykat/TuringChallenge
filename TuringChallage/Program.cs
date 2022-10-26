// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Net;

Console.WriteLine("Hello, World!");
var t = new test();
Console.WriteLine("{}(){[]} => " + t.Valid("{}(){[]}"));
Console.WriteLine("[] => " + t.Valid("[]"));
Console.WriteLine("([)] => " + t.Valid("([)]"));
Console.WriteLine("[[[]]] => " + t.Valid("[[[]]]"));
Console.WriteLine("[[[]] => " + t.Valid("[[[]]"));
public class test
{
  //[5,2,c,d,+] = 30
  //[5,-2,4,c,d,9,+,+] = 27
  //[1] = 1
  //Question One
  public int CalPoints(string[] ops)
  {
    List<int> points = new List<int>();
    for (int i = 0; i < ops.Length; i++)
    {
      if (int.TryParse(ops[i], out int y))
      {
        points.Add(y);
      }
      else
      {
        switch (ops[i].ToUpper())
        {
          case "C": //Remove previous
            {
              points.RemoveAt(points.Count - 1);
            }
            break;
          case "D": //Double previous
            {
              points.Add(points[points.Count - 1] * 2);
            }
            break;
          case "+": //Sum The last 2
            {
              points.Add(points[points.Count - 1] + points[points.Count - 2]);
            }
            break;
          default:
            break;
        }
      }
    }
    return points.Sum();
  }
  // "{}(){[]}" = Valid
  // "[]" = valid
  // "([)]" = invlaid
  // "[[[]]]" = valid

  //Question Two
  public bool Valid(string s)
  {
    int n = -1;
    while (s.Length != n)
    {
      n = s.Length;
      s = s.Replace("()", "");
      s = s.Replace("{}", "");
      s = s.Replace("[]", "");
    }
    if (s.Length == 0) return true;
    else return false;
  }


}
