using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{

    #region
    public class CarTests

    {

        #region Numeric
        [Fact]
        public void Accelerate_IncreaseToyotaVelocityInRange()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 10 }; // Initial velocity set to 10

            // Act
            toyota.Accelerate(); // Accelerate the Toyota

            // Assert
            Assert.InRange(toyota.velocity, 15, 40); // Assert that velocity increased by 15 and is in the range 25 to 40
        }
        [Fact]
        public void Accelerate_IncreaseBMWVelocityInRange()
        {
            // Arrange
            BMW bmw = new BMW() { velocity = 10 }; // Initial velocity set to 10

            // Act
            bmw.Accelerate(); // Accelerate the Toyota

            // Assert
            Assert.InRange(bmw.velocity, 25, 40); // Assert that velocity increased by 15 and is in the range 25 to 40
        }


        #endregion

    }

    #endregion

}
