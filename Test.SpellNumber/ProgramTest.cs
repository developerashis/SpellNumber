using SpellNumber;
using Xunit;

namespace Test.SpellNumber
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(13456, "thirteen thousand four hundred and fifty six")]
        [InlineData(134, "one hundred and thirty four")]
        [InlineData(100834, "one lakh eight hundred and thirty four")]
        public void ConvertToWords_Should_Spell_Correctly(long n, string expectedResult)
        {            
            string result = Program.ConvertToWords(n);
            Assert.Equal(expectedResult, result);

        }
    }
}
