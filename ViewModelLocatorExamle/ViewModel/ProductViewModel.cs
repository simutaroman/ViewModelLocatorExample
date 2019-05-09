using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MyCoffeeStore.StockManagement.Extensions;
using ViewModelLocatorExample.DAL;
using ViewModelLocatorExample.Model;

namespace ViewModelLocatorExample.ViewModel
{
    public class ProductViewModel
    {
        private readonly IProductRepository _productRepository;
        private ObservableCollection<Product> _products;


        public ProductViewModel(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            LoadProducts();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged(nameof(Products));
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadProducts()
        {
            Products = _productRepository.GetProducts().ToObservableCollection();
        }
    }
}
