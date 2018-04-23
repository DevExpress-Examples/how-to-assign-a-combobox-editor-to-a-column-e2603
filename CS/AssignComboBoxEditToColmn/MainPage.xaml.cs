using System.Windows.Controls;
using DevExpress.Xpf.Editors.Settings;

namespace AssignComboBoxEditToColmn {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.DataSource = new ProductList();
            ((ComboBoxEditSettings)grid.Columns["ProductName"].EditSettings).ItemsSource = new ProductList();
        }
    }
}
