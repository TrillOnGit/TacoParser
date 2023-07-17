using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything - Done.

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoLongit = new TacoParser();

            //Act
            var actual = tacoLongit.Parse(line);

            //Assert
            Assert.Equal(actual.Location.Longitude, expected);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("33.671982, -85.826674, Taco Bell Annisto...", 33.671982)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Latitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoLat = new TacoParser();

            //Act
            var actual = tacoLat.Parse(line);

            //Assert
            Assert.Equal(actual.Location.Latitude, expected);
        }
        
        //Name for extra points
        [Theory]
        [InlineData("33.671982, -85.826674, Taco Bell Annisto...", " Taco Bell Annisto...")]
        public void ShouldParseName(string line, string expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Latitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoLat = new TacoParser();

            //Act
            var actual = tacoLat.Parse(line);

            //Assert
            Assert.Equal(actual.Name, expected);
        }
    }
}
