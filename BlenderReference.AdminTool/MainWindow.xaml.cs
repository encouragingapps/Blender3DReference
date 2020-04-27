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
using BlenderReference.Domain.Data;
using System.Collections;

namespace BlenderReference.AdminTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<HotKeyTypeModel> HotKeys  { get; set; }
        public HotKeyTypeModel KeyVal { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            InitializeHotKeysList();

        }

        private void InitializeHotKeysList()
        {
      
            var comboSource = new Dictionary<string, string>();

            HotKeys = new List<HotKeyTypeModel>();
            HotKeys = SqliteDataAccess.LoadHotKeys();

            foreach (HotKeyTypeModel items in HotKeys)
                {
                 comboSource.Add(items.Id.ToString(), 
                                 items.HotKey.ToString());
                };

            cboHotKeys.ItemsSource = comboSource;
          

        }

        private void OnClick_SaveRefKey(object sender, RoutedEventArgs e)
        {
            var refKey = new ReferenceKeyModel();
            refKey.Description =txtDescription.Text;
            refKey.ModeTypeId = Int32.Parse(((ComboBoxItem)cboAreaType.SelectedItem).Tag.ToString());
            refKey.AreaTypeId = Int32.Parse(((ComboBoxItem)cboAreaType.SelectedItem).Tag.ToString());            
            refKey.CanGrabScaleRotate = CommonUtils.ConvertBoolToInt(chkCanGrabScaleRotate.IsChecked).Value;
            refKey.CanRestrictToXYZAxis  = CommonUtils.ConvertBoolToInt(chkCanRestrictXYZAxis.IsChecked).Value;
            refKey.HasScrollWheelFeature = CommonUtils.ConvertBoolToInt(chkHasScrollwheelFeature.IsChecked).Value;
            refKey.CanEnterNumericValue = CommonUtils.ConvertBoolToInt(chkCanEnterNumericValue.IsChecked).Value;
            refKey.Comment = txtComment.Text;
          
            var listHotKey = new List<HotKeyTypeModel>();
            HotKeyTypeModel keyVal;

            foreach (var item in lstHotKeys.Items)
            {
                string[] data = item.ToString().Split(';');
                keyVal = new HotKeyTypeModel
                {
                    Id = Int32.Parse(data[0])
                };

                listHotKey.Add(keyVal);

            }

            try
            {
                SqliteDataAccess.SaveReferenceKey(refKey, listHotKey);
                MessageBox.Show("Reference Key Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Reference Key failed to save.");
            }



        }

        private void OnClick_AddItem(object sender, RoutedEventArgs e)
        {            

            if(cboHotKeys.Text==String.Empty)
            {
                MessageBox.Show("No hotkey entered.");
                return;
            }

            
            lstHotKeys.Items.Add(String.Join(";", cboHotKeys.SelectedValue, cboHotKeys.Text));
            
         
            
            cboHotKeys.Text = String.Empty;
            
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
