using ConGitFirst;

namespace ConGitFirstTest
{
    public class ProgramTest
    {
        [Fact]
        public void SumRange_ShouldReturnCorrectSum_ForNormalRange()
        {
            int from = 1;
            int to = 4;

            int result = Program.SumRange(from, to);

            Assert.Equal(10, result); // 1+2+3+4
        }

        [Fact]
        public void SumRange_ShouldReturnNumber_WhenFromEqualsTo()
        {
            int from = 5;
            int to = 5;

            int result = Program.SumRange(from, to);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SumRange_ShouldThrowArgumentException_WhenFromGreaterThanTo()
        {
            int from = 10;
            int to = 3;

            Assert.Throws<ArgumentException>(() => Program.SumRange(from, to));
        }
        
        
        
        [Fact]
        public void HasName_ShouldReturnTrue_WhenElementExists()
        {
            var items = new List<string> { "Ann", "Bob", "John" };

            bool result = Program.HasName(items, "Ann");

            Assert.True(result);
        }

        [Fact]
        public void HasName_ShouldReturnFalse_WhenElementDoesNotExist()
        {
            var items = new List<string> { "Ann", "Bob", "John" };

            bool result = Program.HasName(items, "Mike");

            Assert.False(result);
        }

        [Fact]
        public void HasName_ShouldReturnFalse_WhenListIsEmpty()
        {
            var items = new List<string>();
            
            bool result = Program.HasName(items, "Ann");
            
            Assert.False(result);
        }

        [Fact]
        public void HasName_ShouldThrowArgumentNullException_WhenListIsNull()
        {
            // Arrange
            List<string> items = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Program.HasName(items, "Ann"));
        }
        
        
        
        [Fact]
        public void CountWords_ShouldHandleMultipleSpacesCorrectly()
        {
            string input = "  a  b c ";

            int result = Program.CountWords(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void CountWords_ShouldReturnZero_ForEmptyString()
        {
            string input = "";

            int result = Program.CountWords(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CountWords_ShouldReturnZero_ForStringWithOnlySpaces()
        {
            string input = "     ";

            int result = Program.CountWords(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CountWords_ShouldThrowArgumentNullException_WhenInputIsNull()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => Program.CountWords(input));
        }


        [Fact]
        public void GetEvens_ShouldReturnCorrectList_ForNormalValue()
        {
            // Arrange
            int n = 6;

            // Act
            var result = Program.GetEvens(n);

            // Assert
            Assert.Equal(new List<int> { 2, 4, 6 }, result);
        }

        [Fact]
        public void GetEvens_ShouldReturnEmptyList_WhenNLessThanTwo()
        {
            // Arrange
            int n = 1;

            // Act
            var result = Program.GetEvens(n);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void GetEvens_ShouldIncludeNumber_WhenNIsEven()
        {
            // Arrange
            int n = 10;

            // Act
            var result = Program.GetEvens(n);

            // Assert
            Assert.Contains(10, result);
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, result);
        }
    }
}