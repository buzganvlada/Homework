using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // ... alte proprietăți
    }


    public interface IProductRepository
    {
        Product GetProductById(int productId);
    }


    public class ShoppingCartClass
    {
        private IProductRepository _productRepository;
        private List<Product> _cartItems;


        public ShoppingCartClass(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _cartItems = new List<Product>();
        }


        public void AddToCart(int productId)
        {
            var product = _productRepository.GetProductById(productId);
            if (product != null)
            {
                _cartItems.Add(product);
            }
        }


        public decimal CalculateTotal()
        {
            return _cartItems.Sum(item => item.Price);
        }
    }

}
