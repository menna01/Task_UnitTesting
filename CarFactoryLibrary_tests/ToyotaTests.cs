using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class ToyotaTests
    {
        #region Boolean
        [Fact]
        public void IsStopped_VelocityNegative_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = -10;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }
        [Fact]
        public void IsStopped_Velocity0_true()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 0;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.True(actualResult);
        }
        [Fact]
        public void IsStopped_Velocity20_false()
        {
            // Arrange
            Toyota toyota = new Toyota();
            toyota.velocity = 20;

            // Act
            bool actualResult = toyota.IsStopped();

            // Boolean Assert
            Assert.False(actualResult);
        }

        #endregion




        #region Numeric

        [Fact]
        public void IncreaseVelocity_velocity10Add20_Velocity30()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 10 };
            double AddedVelocity = 20;

            // Act
            toyota.IncreaseVelocity(AddedVelocity);

            Assert.Equal(30, toyota.velocity);
            //Assert.NotEqual(40, toyota.velocity);
        }

        [Fact]
        public void DecreaseVelocity_NegativeAddedVelocity()
        {
            // Arrange
            Toyota toyota = new Toyota() { velocity = 10 };
            double negativeAddedVelocity = -5;

            // Act
            toyota.IncreaseVelocity(negativeAddedVelocity);

          
            Assert.Equal(5, toyota.velocity);
        }

        #endregion




        #region String


        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Backward };

            // Act
            string result = toyota.GetDirection();

            Assert.Equal("Backward", result);

            Assert.StartsWith("Ba", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("ward", result);
            Assert.DoesNotContain("forward", result);

            Assert.Matches("[A-Z][a-z]{7}", result);
            Assert.DoesNotMatch("F[a-z]{7}", result);
        }
        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Stopped };

            // Act
            string result = toyota.GetDirection();

            Assert.Equal("Stopped", result);

            Assert.StartsWith("St", result);
            Assert.EndsWith("ed", result);

            Assert.Contains("topp", result);
            Assert.DoesNotContain("forward", result);

            Assert.Matches("[A-Z][a-z]{5}", result);
            Assert.DoesNotMatch("F[a-z]{6}", result);
        }
        [Fact]
        public void GetDirection_DirectionForward_Forward()
        {
            // Arrange
            Toyota toyota = new Toyota() { drivingMode = DrivingMode.Forward };

            // Act
            string result = toyota.GetDirection();

        
            Assert.Equal("Forward", result);

            Assert.StartsWith("Fo", result);
            Assert.EndsWith("rd", result);

            Assert.Contains("wa", result);
            Assert.DoesNotContain("zx", result);

            Assert.Matches("F[a-z]{6}", result);
            Assert.DoesNotMatch("F[a-z]{8}", result);
        }
        #endregion



        #region reference
        [Fact]
        public void AskForRefrenceBMW()
        {
     
            BMW bmw1 = new BMW();
            BMW bmw2 = new BMW();

            
            Car result = bmw1.GetMyCar();

          
            Assert.Same(bmw1, result);
            Assert.NotSame(bmw2, result);
        }
        [Fact]
        public void AskForRefrenceToyota()
        {

            Toyota t1 = new Toyota();
            Toyota t2 = new Toyota();


            Car result = t1.GetMyCar();


            Assert.Same(t1, result);
            Assert.NotSame(t2, result);
        }


        [Fact]
        public void NewCar_AskForAudi_null()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.Audi);

            // Reference Asssert
            Assert.Null(result);
            //Assert.NotNull(result);
        }
    }

    
}

    #endregion



