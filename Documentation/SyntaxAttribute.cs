using System;
using System.Threading;
using System.Threading.Tasks;
namespace Documentation;
[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Delegate | AttributeTargets.Interface,AllowMultiple=false,Inherited=false)]
public class SyntaxAttribute : Attribute
{
    private string Name { get; }
    private string Description { get; }
    private string[] Notes { get; }
    public SyntaxAttribute(string name, string desc, params string[] notes)
    {
      Name = name;
      Description = desc;
      Notes = notes;
    }
    private string GenerateDescription()
    {
      return Description.SumLines();
    }
    private string GenerateNotes()
    {
      string result = "Notes:\n";
      result += Notes.GetSumWithLines();
      return result;
    }
    public void DisplaySyntax(bool wait)
    {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Description:\n {GenerateDescription()}");
      Console.WriteLine(GenerateNotes());
    }
    public async Task DisplaySyntaxAsync(bool wait)
    {
      await Task.Run(() => Console.WriteLine($"Name: {Name}"));
      await Task.Run(() => Console.WriteLine($"Description:\n {GenerateDescription()}"));
      await Task.Run(() => Console.WriteLine(GenerateNotes()));
    }
}