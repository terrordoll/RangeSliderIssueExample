using System.Windows;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _testOnset = 100;
        private double _testPeak = 200;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TestOnset = 100;
            TestPeak = 200;
        }

        public double TestOnset
        {
            get { return _testOnset; }
            set { _testOnset = value; }
        }

        public double TestPeak
        {
            get { return _testPeak; }
            set { _testPeak = value; }
        }
    }
}
