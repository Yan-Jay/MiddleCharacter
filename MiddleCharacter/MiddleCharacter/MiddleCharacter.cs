namespace MiddleCharacter
{
    public class MiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            if ((s.Length % 2) == 0 ) return s.Substring((s.Length / 2) - 1, 2);
            return s.Substring(((s.Length + 1) / 2) - 1, 1);
        }
    }
}