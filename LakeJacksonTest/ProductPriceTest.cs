using LakeJacksonCyclingModel;
using Xunit;

namespace LakeJacksonTest
{
    public class ProductPriceTest
    {
        [Fact]
        public void ProductPriceData()
        {
            // Given
            Products _pInfo = new Products();
            double _price = 12.20;
            // When
            _pInfo.Price = _price;
            // Then

            Assert.NotNull(_pInfo.Price);
            Assert.Equal(_price,_pInfo.Price);
        }
    }
}