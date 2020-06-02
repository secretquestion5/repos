using System;
using System.Collections.Generic;
using System.Data;
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
using Npgsql;

namespace SimpleBase
{
    public partial class MainWindow : Window
    {
        ItemsBase ib = new ItemsBase();
        Items item;
        Items newItem;

        public MainWindow()
        {
            InitializeComponent();

            data.ItemsSource = ib.Get();
            
            
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            InsertWindow iw = new InsertWindow();
            iw.ShowDialog();
            item = new Items
            {
                Variant = int.Parse(iw.Variant.Text),
                Surname = iw.Surname.Text,
                Cable = iw.Cable.Text,
                Closure = iw.Closure.Text,
                Converter = iw.Converter.Text,
                Transiver = iw.Transiver.Text,
                Transponder = iw.Transponder.Text,
                Switch = iw.Switch.Text,
                OpticalAmplifier = iw.OpticalAmplifier.Text,
                MUX = iw.MUX.Text,
                Price = int.Parse(iw.Price.Text)
            };
            ib.Add(item);
            iw.Close();
            data.ItemsSource = ib.Get();
           
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            var selectedCell = data.SelectedCells[0];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            
            ModifyWindow mw = new ModifyWindow(data);
           
            mw.ShowDialog();
            newItem = new Items
            {
                Variant = int.Parse(mw.Modify_Variant.Text),
                Surname = mw.Modify_Surname.Text,
                Cable = mw.Modify_Cable.Text,
                Closure = mw.Modify_Closure.Text,
                Converter = mw.Modify_Converter.Text,
                Transiver = mw.Modify_Transceiver.Text,
                Transponder = mw.Modify_Transponder.Text,
                Switch = mw.Modify_Switch.Text,
                OpticalAmplifier = mw.Modify_OpticalAmplifier.Text,
                MUX = mw.Modify_MUX.Text,
                Price = int.Parse(mw.Modify_Price.Text)
            };
            ib.Edit(int.Parse((cellContent as TextBlock).Text), newItem);
            mw.Close();
            data.ItemsSource = ib.Get();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedCell = data.SelectedCells[0];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);

            ib.Remove(int.Parse((cellContent as TextBlock).Text));
            data.ItemsSource = ib.Get();


        }
    }
}
