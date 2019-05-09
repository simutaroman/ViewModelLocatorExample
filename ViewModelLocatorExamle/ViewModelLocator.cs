using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLocatorExample.DAL;
using ViewModelLocatorExample.ViewModel;

namespace ViewModelLocatorExample
{
    public class ViewModelLocator
    {
        private static IProductRepository _productRepository = new ProductRepository();

        public static ProductViewModel ProductViewModel { get; } = new ProductViewModel(_productRepository);
    }
}
