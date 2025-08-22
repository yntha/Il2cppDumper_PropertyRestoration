using System;

namespace Il2CppDumper_PropertyRestoration
{
    [AttributeUsage(AttributeTargets.Field)]
    class ArrayLengthAttribute : Attribute
    {
        public int Length { get; set; }
    }
}
