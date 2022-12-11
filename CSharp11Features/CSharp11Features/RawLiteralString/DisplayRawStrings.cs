using System.Text;

namespace CSharp11Features.RawLiteralString
{
    internal class DisplayRawStrings
    {

        public static string OldApproach()
        {
            var _rawstring = new StringBuilder();
            _rawstring.Append("I'm explaining \"raw string\" here with escape character");

            return _rawstring.ToString();
        }



        public static string NewApproach()
        {
            var _rawstring = new StringBuilder();
            _rawstring.Append("""I'm explaining "raw string" here without escape character""");

            return _rawstring.ToString();
        }

        public static string InterpolationApproach()
        {
            var firstName = "Prasad";
            var _rawstring = $$"""
                            {
                             "firstName" : "{{firstName}}"

                            }
                            """;

            return _rawstring;

        }

    }
}
