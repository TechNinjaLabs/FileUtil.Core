using Ninja.FileUtil.Configuration;

namespace Ninja.FileUtil.Tests.Configuration
{
    public class Delimiter : IDelimiter
    {
        public Delimiter(char value)
        {
            Value = value;
        }

        public char Value { get; set; }
    }
}