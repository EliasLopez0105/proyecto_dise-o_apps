using Microsoft.Maui.Controls;

namespace proyecto_diseño_apps.pages
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(RopaItem selectedItem)
        {
            InitializeComponent();
            itemImage.Source = selectedItem.ImageUrl;
            itemName.Text = selectedItem.Name;
            itemPrice.Text = selectedItem.Price;
        }

        public DetailPage()
        {
            InitializeComponent();
        }
    }
}
