using System;

namespace Documentation
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false,Inherited=true)]
    public class ExtensionMethodAttribute : MethodSyntaxAtttribute
    {
        protected override bool IsExtensionMethod { get => true;}
        public ExtensionMethodAttribute(string methodName, Type returnType, params Type[] parameterTypes) : base(methodName, returnType, parameterTypes)
        {
          // 
        }
        // 
    }
}