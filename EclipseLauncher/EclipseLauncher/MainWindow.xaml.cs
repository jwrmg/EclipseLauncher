using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace EclipseLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SolidColorBrush GoldColor { get; set; } = new(Color.FromArgb(255, 255, 133, 0));
        public SolidColorBrush PurpleColor { get; set; } = new(Color.FromArgb(255, 14, 0, 17));
        public SolidColorBrush LightPurpleColor { get; set; } = new(Color.FromArgb(255, 62, 51, 64));
        public SolidColorBrush TextColor { get; set; } = new(Color.FromArgb(255, 255, 255, 255));

        public int HeaderFontSize { get; set; } = 32;
        public int StandardFontSize { get; set; } = 16;

        private ObservableCollection<Project> m_Projects;

        public ObservableCollection<Project> Projects
        {
            get { return m_Projects ??= new(); }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            for (int i = 0; i < 100; i++)
            {
                Projects.Add(new Project());
            }
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TitleBar_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (Application.Current.MainWindow != null) Application.Current.MainWindow.DragMove();
            }
        }
    }
}