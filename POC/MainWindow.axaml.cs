using Avalonia.Controls;
using Avalonia.Interactivity;

namespace POC;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Saberi_Click(object? sender, RoutedEventArgs e)
    {
        var a = int.Parse(tb_prvi.Text);
        var b = int.Parse(tb_drugi.Text);
        tb_rezultat.Text = (a + b).ToString();
    }
}