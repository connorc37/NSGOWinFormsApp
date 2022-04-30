using Xunit;
using NSGOWinFormsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGOWinFormsApp.Tests
{
    public class LogicTests
    {
        string goodInput = "<p begin=\"158491667t\"><span style=\"style1\">Subtitle1</span></p>" 
                         + "<p begin=\"158491667t\"><span style=\"style1\">Subtitle2</span></p>";

        string missingTag = "<p begin=\"158491667t\"><span style=\"style1\">Subtitle1</span></p>"
                          + "<p begin=\"158491667t\"><span style=\"style1\">Subtitle2</span></p";

        string noSpanTag = "<p begin=\"158491667t\">Subtitle1</p>"
                         + "<p begin=\"158491667t\">Subtitle2</p";
        
        [Fact()]
        public void GetFileContentTest()
        {
            // Add test with Windows Forms concerns
        }

        [Fact()]
        public void ContentIsValidTest_GoodInput_ReturnsTrue()
        {
            // Arrange & Act
            bool result = Logic.ContentIsValid(goodInput);
            // Assert
            Assert.True(result);
        }

        [Fact()]
        public void ContentIsValidTest_BadInput_ReturnsFalse()
        {
            // Arrange & Act
            bool result = Logic.ContentIsValid(missingTag);
            // Assert
            Assert.False(result);
        }

        [Fact()]
        public void GetSubtitleListTest_GoodInput_ReturnsList()
        {
            // Arrange
            List<string> expected = new() { "Subtitle1", "Subtitle2" };
            // Act
            List<string> actual = Logic.GetSubtitleList(goodInput);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GetSubtitleListTest_BadInput_ReturnsEmptyList()
        {
            // Arrange
            List<string> expected = new();
            // Act
            List<string> actual = Logic.GetSubtitleList(noSpanTag);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void GetSubtitleQueueTest()
        {
            // Add test with Windows Forms concerns
        }

        [Fact()]
        public void GetSortedSubtitleListTest()
        {
            // Add test with Windows Forms concerns
        }

        [Fact()]
        public void AlphabetizeTest_Alphabetizes()
        {
            // Arrange
            List<string> test = new() { "d", "b", "c", "a" };
            List<string> expected = new() { "a", "b", "c", "d" };
            // Act
            List<string> actual = Logic.Alphabetize(test);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
