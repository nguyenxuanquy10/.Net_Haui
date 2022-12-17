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

namespace WpfApp1
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


        private void bthNhap_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You may only enter letters", "Error");
                throw new Exception("Phai nhap ten ");
            }
            if (txtLoaiNhanVien.SelectedItem == null)
            {
                throw new Exception("Phai chon loai nhan vien");
            }
            if (date.SelectedDate == null)
            {
                throw new Exception("Phai nhap ngay sinh");
            }
            if (txtSoTien.Text == null)
            {
                throw new Exception("Phai nhap so tien");
            }
            DateTime ngaySinh = date.SelectedDate.Value;
            //Tính tuổi
            TimeSpan timeSpan = DateTime.Now - ngaySinh;
            int tuoi = Convert.ToInt32(timeSpan.TotalDays / 365.25);
            if(tuoi<18 || tuoi > 60)
            {
                throw new Exception("qua tuoi");
            }
            string ketqua = txtName.Text + " - " + (txtLoaiNhanVien.SelectedItem as ComboBoxItem).Content.ToString() + " - " + txtSoTien.Text + " - " + tuoi;

            txtAll.Items.Add(ketqua);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            txtLoaiNhanVien.SelectedItem = null;
            txtAll.Items.Clear();
            date.SelectedDate = DateTime.Now;
            txtName.Focus();
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Window2 window2 = new Window2();
                window2.txtName.Text = txtName.Text;
                window2.txtSoTien.Text = txtSoTien.Text;
                window2.date.SelectedDate = date.SelectedDate;
                foreach (ComboBoxItem item in window2.txtLoaiNhanVien.Items)
                {
                        window2.txtLoaiNhanVien.SelectedItem = item;
                        break;
                }
                window2.Show();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
