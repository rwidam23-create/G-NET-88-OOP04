namespace Assimatpolymorphism
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region Question01
            #region(a)
            //Method overloading:same level(one person,same tasks) / static / It depends on Parent
            //Method overriding:multiable level(many person,same tasks) /dynamic/It depends on child
            #endregion
            #region(b)
            //static Binding:refrenece(compile time) / overloading(new)
            //dynamic Binding:object(RunTime)/ overriding(virtual/override)
            #endregion
            #endregion

            #region Question02
            #region(a)
            //The sealed keyword is used to prevent inheritance.
            #endregion
            #region(b)
            //sealed clas:Applied to the entire class/Prevents other classes from inheriting from it
            //Can be applied to standard classes
            //sealed Method:Applied to an individual method/Prevents child classes from overriding
            //(override) the method/Must be used with the override keyword on a inherited method
            #endregion
            #region(c)
            //No=>because:When you mark a method as sealed, you explicitly instruct the compiler to lock its implementation
            //so that any further derived classes cannot provide a new override for it
            //To:Enforces Design Intent/Security & Integrity/Performance.
            #endregion
            #endregion
        }
    }
}
