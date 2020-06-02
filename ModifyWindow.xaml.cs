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
using System.Windows.Shapes;

namespace SimpleBase
{

    public partial class ModifyWindow : Window
    {
        public ModifyWindow(DataGrid data)
        {

            InitializeComponent();

            Modify_Variant.Text = (data.SelectedCells[1].Column.GetCellContent(data.SelectedCells[1].Item) as TextBlock).Text;
            Modify_Surname.Text = (data.SelectedCells[2].Column.GetCellContent(data.SelectedCells[2].Item) as TextBlock).Text;
            Modify_Cable.Text = (data.SelectedCells[3].Column.GetCellContent(data.SelectedCells[3].Item) as TextBlock).Text;
            Modify_Closure.Text = (data.SelectedCells[4].Column.GetCellContent(data.SelectedCells[4].Item) as TextBlock).Text;
            Modify_Converter.Text = (data.SelectedCells[5].Column.GetCellContent(data.SelectedCells[5].Item) as TextBlock).Text;
            Modify_Transceiver.Text = (data.SelectedCells[6].Column.GetCellContent(data.SelectedCells[6].Item) as TextBlock).Text;
            Modify_Transponder.Text = (data.SelectedCells[7].Column.GetCellContent(data.SelectedCells[7].Item) as TextBlock).Text;
            Modify_Switch.Text = (data.SelectedCells[8].Column.GetCellContent(data.SelectedCells[8].Item) as TextBlock).Text;
            Modify_OpticalAmplifier.Text = (data.SelectedCells[9].Column.GetCellContent(data.SelectedCells[9].Item) as TextBlock).Text;
            Modify_MUX.Text = (data.SelectedCells[10].Column.GetCellContent(data.SelectedCells[10].Item) as TextBlock).Text;
            Modify_Price.Text = (data.SelectedCells[11].Column.GetCellContent(data.SelectedCells[11].Item) as TextBlock).Text;
        }

        

        private void Modify_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Modify_Variant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifySurname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyCable_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyClosure_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyConverter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyTransiver_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyOpticalAmplifier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyMUX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyTransponder_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifySwitch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ModifyPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
