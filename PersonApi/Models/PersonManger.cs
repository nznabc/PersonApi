namespace PersonApi.Models
{
    /// <summary>
    /// three samples of implementing singleton design pattern
    /// one way is to declare our class as static
    /// second way is to define our class as sealed, this way we restrict our class to inherit from other classes(Sealed: sealed classes are used to restrict the inheritance feature.  it cannot be used as a base class)
    /// third way is to define a private constructor, a private statice field to manage single instance of the class.
    /// </summary>
    public static class PersonManger
    {
    }

    public sealed class PersonManger2
    {
    }

    public class PersonManger3
    {
        private static PersonManger3 _instance;

        private PersonManger3()
        {

        }

        /// <summary>
        /// a public static method to get the single instance of the class
        /// </summary>
        /// <returns>single instance of the class</returns>
        public static PersonManger3 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PersonManger3();
            }

            return _instance;
        }
    }
}
