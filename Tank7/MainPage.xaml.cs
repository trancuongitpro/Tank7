using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Tank7.model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tank7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> icons;
        private ObservableCollection<Student> students;
        public MainPage()
        {
            this.InitializeComponent();
            icons = new List<Icon>();
            icons.Add(new Icon { Avatar = "Assets/male-01.png" });
            icons.Add(new Icon { Avatar = "Assets/male-02.png" });
            icons.Add(new Icon { Avatar = "Assets/male-03.png" });
            icons.Add(new Icon { Avatar = "Assets/female-01.png" });
            icons.Add(new Icon { Avatar = "Assets/female-02.png" });
            icons.Add(new Icon { Avatar = "Assets/female-03.png" });

            students = new ObservableCollection<Student>();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            string avatars = ((Icon)addImageTextBox.SelectedValue).Avatar;
            students.Add(new Student { Name = AddNameTextBox.Text, Author = AddAuthorTextBox.Text, Image = avatars });
            AddNameTextBox.Text = "";
            AddAuthorTextBox.Text = "";
            addImageTextBox.SelectedIndex = -1;
            AddNameTextBox.Focus(FocusState.Programmatic);
        }

    }
}
