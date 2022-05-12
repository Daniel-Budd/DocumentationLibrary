using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Documentation;
public static class DocumentationExtensions
{
  public static void Iterate<T>(this (IEnumerable<T> enumerator, Action<T> action) setup)
  {
    foreach(var i in setup.enumerator) setup.action(i);
  }
  public static string SumLines(this string str)
  {
    return str.Separate().GetSum("\n");
  }
  public static string GetSum(this string[] array, Func<string,string> output)
  {
    string result = "";
    foreach(var line in array)
    {
      result += output(line);
    }
    return result;
  }
  public static string GetSum(this List<string> array, Func<string,string> output)
  {
    return array.ToArray().GetSum(output);
  }
  public static string GetSum(this string[] array)
  {
    string result = "";
    foreach(var line in array)
    {
      result += line;
    }
    return result;
  }
  public static string GetSum(this string[] array, string suffix)
  {
    string result = "";
    foreach(var line in array)
    {
      result += line + suffix;
    }
    return result;
  }
  public static string GetSum(this List<string> array)
  {
    return array.ToArray().GetSum();
  }
  public static string GetSum(this List<string> array, string suffix)
  {
    return array.ToArray().GetSum(suffix);
  }
  public static string GetSumWithLines(this string[] lines)
  {
    return lines.Pull((s) => s.Separate().GetSum("\n")).GetSum("\n");
  }
  public static string GetSumWithLines(this string[] lines, string lineSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum();
  }
  public static string GetSumWithLines(this string[] lines, Func<string,string> lineSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum();
  }
  public static string GetSumWithLines(this string[] lines, string lineSuffix, string groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this string[] lines, Func<string,string> lineSuffix, string groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this string[] lines, string lineSuffix, Func<string,string> groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this string[] lines, Func<string,string> lineSuffix, Func<string,string> groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this List<string> lines)
  {
    return lines.Pull((s) => s.Separate().GetSum()).GetSum();
  }
  public static string GetSumWithLines(this List<string> lines, string lineSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum();
  }
  public static string GetSumWithLines(this List<string> lines, Func<string,string> lineSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum();
  }
  public static string GetSumWithLines(this List<string> lines, string lineSuffix, string groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this List<string> lines, Func<string,string> lineSuffix, string groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this List<string> lines, string lineSuffix, Func<string,string> groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
  public static string GetSumWithLines(this List<string> lines, Func<string,string> lineSuffix, Func<string,string> groupSuffix)
  {
    return lines.Pull((s) => s.Separate().GetSum(lineSuffix)).GetSum(groupSuffix);
  }
/**
<summary>Gets output for every array member.</summary>
<typeparam name="Tin">The array type</typeparam>
<typeparam name="Tout">The output type</typeparam>
<param name="input">The array that is iterated through.</param>
<param name="output">The processor that is used to get the output</param>
<returns>An array of the outputs</returns>
*/
  public static Tout[] Pull<Tin,Tout>(this Tin[] input, Func<Tin,Tout> output)
  {
    Tout[] result = new Tout[input.Length];
    for(int i = 0; i < input.Length; i++)
    {
      result[i] = output(input[i]);
    }
    return result;
  }
/**
<summary>Gets output for every array member.</summary>
<typeparam name="Tin">The array type</typeparam>
<typeparam name="Tout">The output type</typeparam>
<param name="input">The array that is iterated through.</param>
<param name="output">The processor that is used to get the output</param>
<returns>An array of the outputs</returns>
*/
  public static Tout[] Pull<Tin,Tout>(this List<Tin> input, Func<Tin,Tout> output)
  {
    Tout[] result = new Tout[input.Count];
    for(int i = 0; i < input.Count; i++)
    {
      result[i] = output(input[i]);
    }
    return result;
  }
  public static string[] Separate(this string line)
  {
    if(!line.Contains("`")) return new string[]{line};
    else
    {
      return line.Split("`");
    }
  }
  public static string SumLines(this string str, Func<string,string> output)
  {
      string[] array = str.Split("`");
      string result = "";int i = 0;
      foreach(var line in array) {
        if(!line.Equals(""))
        {
          result += output(str) + "\n";
          i++;
        }
      }
      return result;
  }
  public static string SumLines(this string str, string suffix)
  {
      string[] array = str.Split("`");
      string result = "";int i = 0;
      foreach(var line in array) {
        if(!line.Equals(""))
        {
          result += str + suffix + "\n";
          i++;
        }
      }
      return result;
  }
  public static TAttr? GetAttribute<TAttr>(this Type type) where TAttr : Attribute
  {
    var attributes = (TAttr[])type.GetCustomAttributes(typeof(TAttr),false);
    return attributes != null && attributes.Count() > 0 ? attributes[0] : null;
  }
  public static TAttr[] GetAllAttributes<TAttr>(this Type type) where TAttr : Attribute
  {
    var attributes = (TAttr[])type.GetCustomAttributes(typeof(TAttr),false);
    return attributes ?? new TAttr[0];
  }
  public static void TryDisplaySyntax(this Type obj, bool wait = true)
  {
    try
    {
      var attribute = obj.GetAttribute<SyntaxAttribute>();
      if(attribute != null) 
      {
        ((SyntaxAttribute)attribute).DisplaySyntax(wait);
      }
    }
    catch
    {
      // 
    }
  }
  public static bool AND<T>(this Predicate<T>[] conditions, T index)
  {
    return !conditions.Pull(c => c(index)).Contains(false);
  }
  public static bool OR<T>(this Predicate<T>[] conditions, T index)
  {
    return conditions.Pull(c => c(index)).Contains(true);
  }
  public static bool TrueForAll<T>(this Predicate<T> condition, params T[] indices)
  {
    return !indices.Pull(i => condition(i)).Contains(false);
  }
  public static bool TrueForAny<T>(this Predicate<T> condition, params T[] indices)
  {
    return indices.Pull(i => condition(i)).Contains(true);
  }
  public static bool TrueForAll<T>(this Predicate<T>[] conditions, params T[] indices)
  {
    return !(indices.Pull((t) => conditions.AND(t)).Contains(false));
  }
  public static bool TrueForAny<T>(this Predicate<T>[] conditions, params T[] indices)
  {
    return indices.Pull((t) => conditions.AND(t)).Contains(true);
  }
}