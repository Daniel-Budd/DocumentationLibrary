using System;
using System.Runtime.InteropServices;
namespace Documentation
{
    [AttributeUsage(AttributeTargets.Parameter,AllowMultiple=false, Inherited=true)]
    public class ParameterSyntaxAttribute : Attribute
    {
        public string ParameterName { get; }
        public Type ParameterType { get; }
        public ParameterModifier Modifier { get; }
        public ParameterSyntaxAttribute(string parameterName, Type parameterType, [Optional]ParameterModifier modifier)
        {
          ParameterName = parameterName;
          ParameterType = parameterType;
          Modifier = modifier;
        }
        protected string GenerateInfo()
        {
          return Modifier != ParameterModifier.None ? $"{Modifier.ToString().ToLower()} {ParameterType.ToString()} {ParameterName}" : $"{ParameterType.ToString()} {ParameterName}";
        }
        public void Display()
        {
          Console.WriteLine($"Parameter Name: {ParameterName}");
          Console.WriteLine($"Parameter Type: {ParameterType.ToString()}");
          Console.WriteLine($"Parameter Modifier: {Modifier.ToString().ToLower()}");
          Console.WriteLine($"Parameter Signature: {GenerateInfo()} ");
        }
    }
    public enum ParameterModifier
    {
      None = 0,
      In,
      Out,
      Ref
    }
}