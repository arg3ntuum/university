namespace SP_Lab_4
{
    public class Checkers<T>
    {
        public static bool CheckForNull(T t)
        {
            if (t != null)
                return true;
            else return false;
        }
    }
}