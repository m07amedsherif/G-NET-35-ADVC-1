using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StructExample<T> where T : struct
    {
        public T Value;
    }

    public class ClassExample<T> where T : class
    {
        public T Value;
    }

    public class NewExample<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }

    public class InterfaceExample<T> where T : IComparable<T>
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class Animal
    {
        public void Speak() { }
    }

    class Dog : Animal { }

    public class BaseClassExample<T> where T : Animal
    {
        public void MakeSound(T obj)
        {
            obj.Speak();
        }
    }
}
