using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox usernameTxtBx;
        private TextBox passwordTxtBx;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void gridSomething_Loaded(object sender, RoutedEventArgs e)
        {

        }

        

        private void gridSomething_Initialized(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Content = "Welcome to the Login Page";
            label.FontSize = 24;
            label.Margin = new Thickness(0, -350, 0, 0);
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.VerticalAlignment = VerticalAlignment.Center;

            Label usernameLabel = new Label();
            usernameLabel.Content = "Username";
            usernameLabel.FontSize = 20;
            usernameLabel.Width = 210;
            usernameLabel.Height = 31;
            usernameLabel.Margin = new Thickness(0, -275, 0, 0);
            usernameLabel.HorizontalContentAlignment = HorizontalAlignment.Left;    
            usernameLabel.HorizontalAlignment = HorizontalAlignment.Center;
            usernameLabel.VerticalAlignment = VerticalAlignment.Center;

            usernameTxtBx = new TextBox();
            usernameTxtBx.Text = "Enter username";
            usernameTxtBx.Foreground = Brushes.Gray;
            usernameTxtBx.Width = 200;
            usernameTxtBx.Height = 25;
            usernameTxtBx.Margin = new Thickness(0, -200, 0, 0);
            usernameTxtBx.HorizontalAlignment = HorizontalAlignment.Center;

            Label passwordLabel = new Label();
            passwordLabel.Content = "Password";
            passwordLabel.FontSize = 20;
            passwordLabel.Width = 210;
            passwordLabel.Height = 35;
            passwordLabel.Margin = new Thickness(0, -100, 0, 0);
            passwordLabel.HorizontalContentAlignment = HorizontalAlignment.Left;
            passwordLabel.HorizontalAlignment = HorizontalAlignment.Center;
            passwordLabel.VerticalAlignment = VerticalAlignment.Center;

            passwordTxtBx = new TextBox();
            passwordTxtBx.Text = "Enter password";
            passwordTxtBx.Foreground = Brushes.Gray;
            passwordTxtBx.Width = 200;
            passwordTxtBx.Height = 25;
            passwordTxtBx.Margin = new Thickness(0, -25, 0, 0);
            passwordTxtBx.HorizontalAlignment = HorizontalAlignment.Center;

            Button logInBtn = new Button();
            logInBtn.Content = "Log In";
            logInBtn.Width = 200;
            logInBtn.Height = 25;
            logInBtn.Margin = new Thickness(0, 100, 0, 0);
            logInBtn.HorizontalAlignment = HorizontalAlignment.Center;

            gridSomething.Children.Add(label);
            gridSomething.Children.Add(usernameLabel);
            gridSomething.Children.Add(usernameTxtBx);
            gridSomething.Children.Add(passwordLabel);
            gridSomething.Children.Add(passwordTxtBx);
            gridSomething.Children.Add(logInBtn);

            usernameTxtBx.GotFocus += UsernameTxtBx_GotFocus;
            usernameTxtBx.LostFocus += UsernameTxtBx_LostFocus;

            passwordTxtBx.GotFocus += PasswordTxtBx_GotFocus;
            passwordTxtBx.LostFocus += PasswordTxtBx_LostFocus;

            logInBtn.Click += LogInBtn_Click;
        }

        private void UsernameTxtBx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "Enter username")
            {
                txt.Text = "";
                txt.Foreground = Brushes.Black;
            }
        }

        private void UsernameTxtBx_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Enter username";
                txt.Foreground = Brushes.Gray;
            }
        }

        private void PasswordTxtBx_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text == "Enter password")
            {
                txt.Text = "";
                txt.Foreground = Brushes.Black;
            }
        }

        private void PasswordTxtBx_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = "Enter password";
                txt.Foreground = Brushes.Gray;
            }
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTxtBx.Text == "admin" && passwordTxtBx.Text == "admin")
            {
                MessageBox.Show("Login successful!");
            }
            else if (usernameTxtBx.Text == "Who is" && passwordTxtBx.Text == "Steve Jobs")
            {
                MessageBox.Show("Ligma balls.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
