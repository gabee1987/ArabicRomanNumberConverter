using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanArabicNumberConverter;

namespace ConverterTests
{
    [TestClass]
    public class ConvertArabicNumberToRomanTests
    {
        ConverterLogic converter;
        
        [TestInitialize]
        public void CreateConverterObject()
        {
            converter = new ConverterLogic();
        }

        [TestMethod]
        public void Roman_1_I()
        {
            // Arrange
            string controlNumber = "I";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(1);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_2_II()
        {
            // Arrange
            string controlNumber = "II";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(2);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_3_III()
        {
            // Arrange
            string controlNumber = "III";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(3);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_4_IV()
        {
            // Arrange
            string controlNumber = "IV";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(4);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_5_V()
        {
            // Arrange
            string controlNumber = "V";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(5);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_9_IX()
        {
            // Arrange
            string controlNumber = "IX";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(9);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_10_X()
        {
            // Arrange
            string controlNumber = "X";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(10);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_49_XLIX()
        {
            // Arrange
            string controlNumber = "XLIX";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(49);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_50_L()
        {
            // Arrange
            string controlNumber = "L";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(50);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_100_C()
        {
            // Arrange
            string controlNumber = "C";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(100);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_400_CD()
        {
            // Arrange
            string controlNumber = "CD";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(400);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_500_D()
        {
            // Arrange
            string controlNumber = "D";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(500);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_900_CM()
        {
            // Arrange
            string controlNumber = "CM";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(900);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_1000_M()
        {
            // Arrange
            string controlNumber = "M";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(1000);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }

        [TestMethod]
        public void Roman_11984_MMMMMMMMMMMCMLXXXIV()
        {
            // Arrange
            string controlNumber = "MMMMMMMMMMMCMLXXXIV";

            // Act
            string romanNumber = converter.ConvertArabicNumberToRoman(11984);

            // Assert
            Assert.AreEqual(controlNumber, romanNumber);
        }
    }
}
