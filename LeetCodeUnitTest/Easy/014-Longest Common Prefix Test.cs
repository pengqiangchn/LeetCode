using LeetCode;
using Xunit;

namespace LeetCodeUnitTest
{
    public class Solution014Test
    {
        [Fact]
        public void LongestCommonPrefix_HasCommon()
        {
            //Arrange
            Solution014 s014 = new Solution014();
            string[] strArrar = new string[] { "flower", "flow", "flight" };
            string expected = "fl";

            //Act
            string actual = s014.LongestCommonPrefix(strArrar);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestCommonPrefix_Ex1()
        {
            //Arrange
            Solution014 s014 = new Solution014();
            string[] strArrar = new string[] { "aca", "cba" };
            string expected = "";

            //Act
            string actual = s014.LongestCommonPrefix(strArrar);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestCommonPrefix_NoCommon()
        {
            //Arrange
            Solution014 s014 = new Solution014();
            string[] strArrar = new string[] { "dog", "racecar", "car" };
            string expected = "";

            //Act
            string actual = s014.LongestCommonPrefix(strArrar);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
