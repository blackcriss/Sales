﻿namespace Sales.ViewModels
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Sales.Views;
    using Xamarin.Forms;

    public class MainViewModel
    {
        public ProductsViewModel Products { get; set; }

        public AddProducViewModel AddProduct { get; set; }

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }

        public ICommand AddProductCommand
        {
            get
            {
                return new RelayCommand(GoToAddProduct);
            }
        }

        private async void GoToAddProduct()
        {
            this.AddProduct = new AddProducViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new AddProductPage());
        }
    }
}
