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
            Customers cName = new Customers(); /* thos arrange Customer name for test*/
            string validName = "Kristopher";
            string validZip = "77566";

            //Act
            cName.Name = validName;
            cName.Zip = validZip;
            
            //Assert
            Assert.NotNull(cName.Name);
            Assert.Equal(validName, cName.Name);
             
             Assert.NotNull(cName.Zip);
            Assert.Equal(validZip, cName.Zip);
        }
    }
}