using System.Windows;
using System.Windows.Input;
namespace UserEcommerceApp.View;
public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }
}