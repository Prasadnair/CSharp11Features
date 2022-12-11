namespace CSharp11Features.PatternMatching
{
    internal class ListPatternExample
    {
        static int[] numbers = { 1, 2, 3 };

        public static bool IsMatch()
        {
            var match = numbers is [1, 2, 3];

            return match;
        }

        public static bool IsNotMatch()
        {
            var match = numbers is [1, 2, 4];

            return match;
        }

        public static bool IsMatchWithExpression()
        {
            var match = numbers is [0 or 1, <=2, >=3];
            return match;
        }

    }
}
