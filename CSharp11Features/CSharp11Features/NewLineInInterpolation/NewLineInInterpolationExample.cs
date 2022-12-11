namespace CSharp11Features.NewLineInInterpolation
{
    internal class NewLineInInterpolationExample
    {
        public static string NewLineApproach()
        {
            var name = "PRASAD";

            var _rawString = $"Fistname in LowerCase : {name
                .ToLower()}";
            return _rawString;
        }
    }
}
