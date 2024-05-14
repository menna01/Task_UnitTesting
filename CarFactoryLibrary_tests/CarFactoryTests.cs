using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary_tests
{
    public class CarFactoryTests
    {
   



        #region Type
        [Fact]
        public void NewCar_AskForToyota_toyotaObject()
        {
            // Act
            Car? result = CarFactory.NewCar(CarTypes.Toyota);

            // Type Assert
            Assert.IsType<Toyota>(result);
            Assert.IsNotType<BMW>(result);

            Assert.IsAssignableFrom<Car>(result);
        }


        [Fact]
        public void NewCar_AskForBMW_BMWObject()
        {
            // Arrange

            // Act
            Car? result = CarFactory.NewCar(CarTypes.BMW);

            // Type Assert
            Assert.IsType<BMW>(result);
            Assert.IsNotType<Toyota>(result);

            Assert.IsAssignableFrom<Car>(result);
        }

        #endregion






        #region Exception
        [Fact]

        public void NewCar_AskForHonda_Exception()
        {
            // Arrange



            // Exception Assert
            Assert.Throws<NotImplementedException>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
            Assert.ThrowsAny<Exception>(() =>
            {
                // Act
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });

        }

        #endregion
    }
}
