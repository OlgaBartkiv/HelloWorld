using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    public class Purchase
    {
        public void MakePurchase()
        {
            Product product = new Product();
            product.PickProduct();
            Cart cart = new Cart();
            cart.AddToCart();
            Payment payment = new Payment();
            payment.MakePayment();
            Debug.WriteLine("The purchase is successfully completed");
        }

        public class Product
        {
            public void PickProduct()
            {
                Debug.WriteLine("Picked a product from the menu");
            }
        }

        public class Cart
        {
            public void AddToCart()
            {
                Debug.WriteLine("Added the product to cart");
            }
        }

        public class Payment
        {
            public void MakePayment()
            {
                Debug.WriteLine("The payment is made successfully");
            }
        }
    }
}
