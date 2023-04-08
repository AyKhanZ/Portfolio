using System.Windows;
using System.Windows.Input;

namespace AdminEcommerceApp.View;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed) DragMove();
    }
}