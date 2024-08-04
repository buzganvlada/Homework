namespace StringAndListUnits
{
    public class StringAndListUnitTesting
    {
        public class StringValidatorTEst
        {
            [Theory]
            [InlineData("example@gmail.com", true)]
            [InlineData("example", false)]
            [InlineData("@gmail.com", false)]
            [InlineData(".", false)]
            [InlineData(" ", false)]

            public void TestingIsValidEmail(string input, bool expected)
            {
                bool output = StringValidator.IsValidEmail(input);
                Assert.Equal(expected, output);
            }

            [Theory]
            [InlineData("1254367098", true)]
            [InlineData("123", false)]
            [InlineData("143yt", false)]
            [InlineData("abcd345", false)]

            public void TestingIsPhoneNumber(string input, bool expected)
            {
                bool output = StringValidator.IsPhoneNumber(input);
                Assert.Equal(expected, output);
            }
        }

        public class ListManipulatorTest
        {
            [Theory]
            [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
            [InlineData(new[] { -7 - 6 - 5 - 4 - 3 - 2 - 1 }, -1)]
            [InlineData(new[] { 0, 0, 0, 0, 0 }, 0)]

            public void TestingFindMax(int[] input, int expected)
            {
                int max = ListManipulator.FindMax(input.ToList());
                Assert.Equal(expected, max);
            }

            [Theory]
            [InlineData(new[] { 1, 2, 3, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
            [InlineData(new[] { -1, -2, -3, -3, -4, -5 }, new[] { -1, -2, -3, -4, -5 })]
            [InlineData(new[] { 0, 0, 0, 0, 0 }, new[] { 0 })]

            public void TestingRemoveDuplicates(int[] input, int[] expected)
            {
                List<int> output = ListManipulator.RemoveDuplicates(input.ToList());
                Assert.Equal(expected, output);
            }
        }
    }
}