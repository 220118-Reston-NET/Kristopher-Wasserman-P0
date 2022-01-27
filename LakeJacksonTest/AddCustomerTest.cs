using LakeJacksonCyclingModel;
using Xunit;

namespace LakeJacksonTest
{

    public class AddCustomerTest
    {
        [Fact]
        public void AddCustomerNameData()
        {
            //Arrange
            Customers cName = new Customers();
            string validName = "Kristopher";

            //Act
            cName.Name = validName;
            
            //Assert
            Assert.NotNull(cName.Name);
            Assert.Equal(validName, cName.Name);
        }
    }
}