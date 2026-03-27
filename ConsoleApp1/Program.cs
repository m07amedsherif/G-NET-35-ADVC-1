using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T FindMax<T>(List<T> list) where T : IComparable<T>
        {
            T max = list[0];

            foreach (var item in list)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }

            return max;
        }

        static void Main(string[] args)
        {
            /*
             * A generic class uses type parameters that are replaced with actual types when you create an instance. 
             * The type parameter T acts as a placeholder
             * we use it because of the typesafe, performance and code reuse.
            */


            /*
             * Q3 It is a class with more than one type parameter which can be replaced with actual types when you create an instance.
             */

            /*
             * Q4 A generic method declares its own type parameter(s)
             */

            /*
             * Q6 Generic interfaces define contracts with type parameters. Classes implementing them specify the actual types.
             */

            /*
             * Q7 The 'struct' constraint restricts T to value types only.
             */

            /*
             * Q8 The 'class' constraint restricts T to reference types only.
             */

            /*
             * Q9 The 'new' constraint requires T to have a public parameterless constructor.
             */

            /*
             * Q10 The interface constraint requires T to implement a specific interface.
             */

            /*
             * Q11 The base class constraint requires T to implement a specific base class.
             */

            /*
             * Q12  By using the "where" keyword with more than one condition.
             * Example: class Example<T> where T : class, IDisposable, new()
             */

            /*
             * Q13 It returns the default value of a type when the exact type is not known at compile time.
             */

            /*
             * 
             */

            // Q15 Covariance allows a generic type to return a more derived type than originally specified.
            // The 'out' keyword is used to mark a type parameter as covariant.

            // Q16 Contravariance allows a generic type to accept a less derived (more general) type.
            // The 'in' keyword is used to mark a type parameter as contravariant.

            // Q17
            // Covariance ('out') allows using a more derived type (child → parent direction).
            // Contravariance ('in') allows using a less derived type (parent → child direction).

            // Q18 Static members in generic types are specific to each closed constructed type.

            // Q19 two ways:
            // 1. By passing a specific type to the base generic class.
            // 2. By keeping the derived class generic and passing the type parameter to the base class.

        }

    }
}