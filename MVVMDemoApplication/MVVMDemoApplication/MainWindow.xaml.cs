using MVVMDemoApplication.Model;
using MVVMDemoApplication.ViewModel;

namespace MVVMDemoApplication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Database db = new Database();

            // create the ViewModel object and setup the DataContext to it
            MasterViewModel masterViewModel = new MasterViewModel(db);
            this.MasterView.DataContext = masterViewModel;
            this.DetailView.DataContext = masterViewModel;
        }
    }
}
