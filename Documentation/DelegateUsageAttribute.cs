using System;

namespace Documentation
{
    [TODO("Add Documentation")]
    [AttributeUsage(AttributeTargets.Delegate,AllowMultiple=false,Inherited=false)]
    public class DelegateUsageAttribute : Attribute
    {
        public string DelegateName { get; }
        public Type ReturnType { get; }
        public Type[] ParameterTypes { get; }
        public DelegateUsageAttribute(string delegateName, Type returnType, params Type[] parameters)
        {
          DelegateName = delegateName;
          ReturnType = returnType;
          ParameterTypes = parameters;
        }
        private string GenerateTypeText()
        {
          string result = "";
          for(int i = 0; i < ParameterTypes.Length; i++)
          {
            result += $"{i}: {ParameterTypes[i]}\n";
          }
          return result;
        }
        public void Display()
        {
          Console.WriteLine($"Name: {DelegateName}");
          Console.WriteLine($"Parameters: {GenerateTypeText()}");
          Console.WriteLine($"Return Type: {ReturnType}");
        }
    }
}