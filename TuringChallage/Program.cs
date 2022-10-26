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
  //https://www.geeksforgeeks.org/print-array-after-it-is-right-rotated-k-times-where-k-can-be-large-or-negative/
  public int[] QuestionOne(int[] nums, int k)
  {
    int n = nums.Length;

    // Case when K > N or K < -N
    k = k < 0 ? ((k * -1) % n) * -1 : k % n;

    k = k < 0 ? (n - (k * -1)) : k;
    // Reverse all the nums elements

    int temp1;int start1 = 0; int end1 = n - 1;


    while (start1 <= end1)
    {
      // Swapping the first and last character
      temp1 = nums[start1];
      nums[start1] = nums[end1];
      nums[end1] = temp1;
      start1++;
      end1--;
    }

    // Reverse the first k elements
    int temp2; int start2 = 0; int end2 = n - k;
    while (start2 <= end2)
    {
      // Swapping the first and last character
      temp2 = nums[start2];
      nums[start2] = nums[end2];
      nums[end2] = temp2;
      start2++;
      end2--;
    }
    // Reverse the elements from K
    // till the end1 of the nums
    int temp; int start = k; int end = n - 1;
    while (start <= end)
    {
      // Swapping the first and last character
      temp = nums[start];
      nums[start] = nums[end];
      nums[end] = temp;
      start++;
      end--;
    }
    return nums;
  }
  static void reverse(int[] nums, int start, int end)
  {

    // Temporary variable to store character
    int temp;
    while (start <= end)
    {
      // Swapping the first and last character
      temp = nums[start];
      nums[start] = nums[end];
      nums[end] = temp;
      start++;
      end--;
    }
  }
  public string Reverse(string s)
  {
     char[] temp= new char[s.Length];
    var main = s.ToCharArray();
    for (int i = 0; i < main.Length; i++)
    {
      if (char.IsLetter(main[i]))
      {
        temp[i] = main[i];
      }
    }
    temp = temp?.Reverse()?.ToArray();
    //var newS = new string(temp);
    //newS = newS.Reverse();
    for (int i = 0; i < main.Length; i++)
    {
      if (char.IsLetter(main[i]))
      {
         main[i] = temp[i];
      }
    }
    return new string( main);
  }
}
