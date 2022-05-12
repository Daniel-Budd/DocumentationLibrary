using System;

namespace Documentation
{
  [AttributeUsage(AttributeTargets.All, AllowMultiple=true,Inherited=false)]
  public class ExampleAttribute : Attribute
  {
      public string Example { get; }
      public ExampleAttribute(string example)
      {
        Example = example;
      }
      private string GenerateText()
      {
        return Example.SumLines();
      }
      public void Display()
      {
        Console.WriteLine($"For Example,\n{GenerateText()}");
      }
  }
}