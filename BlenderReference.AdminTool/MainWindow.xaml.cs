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
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Utils;

namespace BlenderReference.AdminTool
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
        private void OnClick_SaveRefKey(object sender, RoutedEventArgs e)
        {
            var refKey = new ReferenceKeyModel();
            refKey.Description =txtDescription.Text;            
            refKey.AreaTypeId = Int32.Parse(((ComboBoxItem)cboAreaType.SelectedItem).Tag.ToString());
            refKey.ModeTypeId = Int32.Parse(((ComboBoxItem)cboAreaType.SelectedItem).Tag.ToString());
            refKey.CanGrabScaleRotate = CommonUtils.ConvertBoolToInt(chkCanGrabScaleRotate.IsChecked).Value;
            refKey.CanRestrictToXYZAxis  = CommonUtils.ConvertBoolToInt(chkCanRestrictXYZAxis.IsChecked).Value;
            refKey.HasScrollWheelFeature = CommonUtils.ConvertBoolToInt(chkHasScrollwheelFeature.IsChecked).Value;
            refKey.CanEnterNumericValue = CommonUtils.ConvertBoolToInt(chkCanEnterNumericValue.IsChecked).Value;

            MessageBox.Show("Reference Key Saved Successfully!");
        }

        private void OnClick_AddItem(object sender, RoutedEventArgs e)
        {            

            if(txtHotKey.Text==String.Empty)
            {
                MessageBox.Show("No hotkey entered.");
                return;
            }

            if(!String.IsNullOrEmpty(txtHotKeyAlias.Text)&&!String.IsNullOrEmpty(txtHotKey.Text))
            {
                lstHotKeys.Items.Add(String.Join(";", txtHotKey.Text, txtHotKeyAlias.Text));
            }
            else
            {
                lstHotKeys.Items.Add(txtHotKey.Text);
            }
            
            txtHotKey.Text = String.Empty;
            txtHotKeyAlias.Text = String.Empty;
        }

        private void OnClick_RemoveItem(object sender, RoutedEventArgs e)
        {
            foreach (string item in lstHotKeys.SelectedItems)
            {
                lstHotKeys.Items.Remove(item);
            }
        }

    }
}
