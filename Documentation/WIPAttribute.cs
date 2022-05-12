using System;

namespace Documentation
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class WIPAttribute : Attribute
    {
        public WIPAttribute() {}
    }
}