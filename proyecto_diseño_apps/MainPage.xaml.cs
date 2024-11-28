using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using proyecto_diseño_apps.pages; 

namespace proyecto_diseño_apps
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<RopaItem> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<RopaItem>
            {
                new RopaItem { Name = "Camiseta", Price = "$20", ImageUrl = "camiseta.png" },
                new RopaItem { Name = "Pantalones", Price = "$30", ImageUrl = "pantalones.png" },
                new RopaItem { Name = "Chaqueta", Price = "$50", ImageUrl = "chaqueta.png" }
            };
            itemsCollectionView.ItemsSource = Items;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection[0] as RopaItem;
            if (selectedItem != null)
            {
                await Navigation.PushAsync(new DetailPage(selectedItem));
            }
        }
    }

    public class RopaItem
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
