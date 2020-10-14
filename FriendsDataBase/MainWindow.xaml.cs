using FriendsDataBase.Context;
using FriendsDataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FriendsDataBase
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadFriendsFromDB();
        }
        #region Methods
        private void LoadFriendsFromDB()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var friend in db.Friends)
                    friendsWrapPannel.Children.Add(CreateNewFriendStackPannel(friend));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (WindowState)
            {
                case (WindowState.Maximized):
                    WindowState = WindowState.Normal;
                    break;
                case (WindowState.Normal):
                    WindowState = WindowState.Maximized;
                    break;
            }
        }

        private void CloseAppButtonClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void getNameTextBlock_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var textblock = sender as TextBox;
            if (textblock.Text == "Enter your name" || textblock.Text == "Enter your surname")
                textblock.Text = "";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void GetNameButton_Click(object sender, RoutedEventArgs e)
        {
            if (getNameTextBox.Text == "Enter your name" || string.IsNullOrWhiteSpace(getNameTextBox.Text))
                userNameBorder.Background = Brushes.Red;
            else
                userNameBorder.Background = Brushes.LightGreen;

            if (getSurnameTextBox.Text == "Enter your surname" || string.IsNullOrWhiteSpace(getSurnameTextBox.Text))
                userSurnameBorder.Background = Brushes.Red;
            else
                userSurnameBorder.Background = Brushes.LightGreen;

            if ((getNameTextBox.Text == "Enter your name" || string.IsNullOrWhiteSpace(getNameTextBox.Text)) ||
                (getSurnameTextBox.Text == "Enter your surname" || string.IsNullOrWhiteSpace(getSurnameTextBox.Text)))
            {
                ErrorLabel.Content = "Enter correct name and surname";
                ErrorLabel.Foreground = Brushes.Red;
            }

            if ((getNameTextBox.Text != "Enter your name" && !string.IsNullOrWhiteSpace(getNameTextBox.Text)) &&
                (getSurnameTextBox.Text != "Enter your surname" && !string.IsNullOrWhiteSpace(getSurnameTextBox.Text)))
            {
                var newFriend = new Friend(getNameTextBox.Text, getSurnameTextBox.Text);

                if (AddNewFriend(newFriend))
                {
                    friendsWrapPannel.Children.Add(CreateNewFriendStackPannel(newFriend));
                    ErrorLabel.Content = $"Welcome, {newFriend.Name + " " + newFriend.Surname}";
                    ErrorLabel.Foreground = Brushes.LightGreen;
                }
                else
                {
                    ErrorLabel.Content = "This friend is alrady in list";
                    ErrorLabel.Foreground = Brushes.Red;
                    userNameBorder.Background = Brushes.Red;
                    userSurnameBorder.Background = Brushes.Red;
                }

            }

        }

        private bool AddNewFriend(Friend friend)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!db.Friends.Any(f => f.Name == friend.Name && f.Surname == friend.Surname))
                {
                    db.Friends.Add(friend);
                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        private Border CreateNewFriendStackPannel(Friend friend)
        {
            Border border = new Border();

            border.CornerRadius = new CornerRadius(15);
            border.Margin = new Thickness(5);

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();

            GradientStop gradientStop1 = new GradientStop();
            gradientStop1.Color = (Color)ColorConverter.ConvertFromString("#40567a");
            gradientStop1.Offset = 0.2;

            GradientStop gradientStop2 = new GradientStop();
            gradientStop2.Color = (Color)ColorConverter.ConvertFromString("#3a5f9c");
            gradientStop2.Offset = 0.5;

            linearGradientBrush.GradientStops.Add(gradientStop1);
            linearGradientBrush.GradientStops.Add(gradientStop2);

            border.Background = linearGradientBrush;

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Vertical;
            stackPanel.Opacity = 0.5;
            stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;

            StackPanel name = new StackPanel();
            name.Margin = new Thickness(5);

            Label label = new Label();
            label.Foreground = Brushes.White;
            label.FontFamily = new FontFamily("Arial");
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.VerticalAlignment = VerticalAlignment.Center;
            label.FontSize = 22;
            label.FontWeight = FontWeights.Light;
            label.Content = friend?.Name;

            name.Children.Add(label);

            StackPanel surname = new StackPanel();
            surname.Margin = new Thickness(5);

            Label label1 = new Label();
            label1.Foreground = Brushes.White;
            label1.FontFamily = new FontFamily("Arial");
            label1.HorizontalAlignment = HorizontalAlignment.Center;
            label1.VerticalAlignment = VerticalAlignment.Center;
            label1.FontSize = 22;
            label1.FontWeight = FontWeights.Light;
            label1.Content = friend?.Surname;

            surname.Children.Add(label1);

            stackPanel.Children.Add(name);
            stackPanel.Children.Add(surname);

            border.Child = stackPanel;

            return border;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter: SearcherMech(); break;
            }
        }
        private void SearcherMech()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!string.IsNullOrWhiteSpace(Searcher.Text))
                {
                    if (db.Friends.Any(f => EF.Functions.Like(f.Name, $"%{Searcher.Text}%") ||
                                            EF.Functions.Like(f.Surname, $"%{Searcher.Text}%")))
                    {
                        var friends = db.Friends.Where(f => EF.Functions.Like(f.Name, $"%{Searcher.Text}%") ||
                                                            EF.Functions.Like(f.Surname, $"%{Searcher.Text}%"));

                        friendsWrapPannel.Children.Clear();

                        foreach (var friend in friends)
                            friendsWrapPannel.Children.Add(CreateNewFriendStackPannel(friend));
                    }
                }
                else
                {
                    if (friendsWrapPannel.Children.Count != db.Friends.Count())
                    {
                        friendsWrapPannel.Children.Clear();

                        foreach (var friend in db.Friends)
                            friendsWrapPannel.Children.Add(CreateNewFriendStackPannel(friend));
                    }
                }
            }
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Searcher.Text == "Enter name")
                Searcher.Text = "";
        }
        #endregion
    }
}
