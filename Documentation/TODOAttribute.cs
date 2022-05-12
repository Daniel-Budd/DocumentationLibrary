using System;

namespace Documentation
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple=true,Inherited=false)]
    public class TODOAttribute : Attribute
    {
        public TODOAttribute(string message)
        {
          // 
        }
        public TODOAttribute(){}
    }
}