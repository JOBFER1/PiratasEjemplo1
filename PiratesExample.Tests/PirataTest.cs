//using NUnit.Framework;
using NUnit.Framework; 
using NUnit.Framework.Legacy;

using System;
using System.IO;

namespace PiratesExample
{
    [TestFixture]
    public class PirataTest
    {
        [Test]
        public void TestPresentarse()
        {
            // Arrange
            var pirata = new Pirata("Jack Sparrow", 35, "Black Pearl");
            var expectedOutput = "Soy Jack Sparrow, tengo 35 años y navego en el barco Black Pearl" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                pirata.Presentarse();

                // Assert
                var result = sw.ToString();
                //Assert.AreEqual(expectedOutput, result);
                ClassicAssert.AreEqual(expectedOutput, result);
            }
        }

        //Método TestAtacar
        [Test]
        public void TestAtacar()
        {
            // Arrange
            var pirata = new Pirata("Jack Sparrow", 35, "Black Pearl");
            var expectedOutput = "Soy Jack Sparrow y estoy atacando" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                pirata.Atacar();

                // Assert
                var result = sw.ToString();
                //Assert.AreEqual(expectedOutput, result);
                ClassicAssert.AreEqual(expectedOutput, result);
            }
        }
    }
}