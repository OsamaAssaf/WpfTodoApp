using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text.Trim();
            if (string.IsNullOrEmpty(todoText)) return;
            TextBlock textBlock = new TextBlock
            {
                Text = todoText,
                Margin = new Thickness(10),
                Foreground = new SolidColorBrush(Colors.White),
            };
            TodoList.Children.Add(textBlock);
            TodoInput.Clear();
        }
    }
}