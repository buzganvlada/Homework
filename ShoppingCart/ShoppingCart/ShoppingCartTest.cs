using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using ShoppingCart;

public class ShoppingCartTests
{
    [Fact]
    public void AddToCart_ShouldAddProductToCart()
    {

        var mockProductRepository = new Mock<IProductRepository>();
        var product = new Product { ProductId = 1, Name = "Test Product", Price = 10.00m };
        mockProductRepository.Setup(repo => repo.GetProductById(1)).Returns(product);

        var shoppingCart = new ShoppingCartClass(mockProductRepository.Object);

        shoppingCart.AddToCart(1);

        var total = shoppingCart.CalculateTotal();
        Assert.Equal(10.00m, total);
    }

    [Fact]
    public void AddToCart_ShouldNotAddProductIfNotFound()
    {
        var mockProductRepository = new Mock<IProductRepository>();
        mockProductRepository.Setup(repo => repo.GetProductById(It.IsAny<int>())).Returns<Product>(null);

        var shoppingCart = new ShoppingCartClass(mockProductRepository.Object);

        shoppingCart.AddToCart(1);

        var total = shoppingCart.CalculateTotal();
        Assert.Equal(0.00m, total);
    }
}
