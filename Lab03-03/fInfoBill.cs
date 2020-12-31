using Lab03_03.Model;
using Lab03_03.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class fInfoBill : Form
    {
        List<Order> listOrder = new List<Order>();
        List<Invoice> listlnvoice = new List<Invoice>();
        public fInfoBill()
        {
            InitializeComponent();
            listOrder = ProductInfoService.GetAll();
            foreach (var order in listOrder)
            {
                if (listlnvoice.Any(x => x.InvoiceNo == order.Invoice.InvoiceNo)) continue;
                listlnvoice.Add(order.Invoice);
            }
            LoadData(listlnvoice);

        }

        private void LoadData(List<Invoice> listlnvoice)
        {
            decimal num = 0;
            decimal num1 = 0;
            dgvProductInfo.Rows.Clear();
            foreach (var item in listlnvoice)
            {
                int index = dgvProductInfo.Rows.Add();
                dgvProductInfo.Rows[index].Cells[0].Value = index + 1;
                dgvProductInfo.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgvProductInfo.Rows[index].Cells[2].Value = item.OrderDate.ToString("dd/MM/yyyy");
                dgvProductInfo.Rows[index].Cells[3].Value = item.DeliveryDate.ToString("dd/MM/yyyy");
                foreach (var item1 in listOrder)
                {
                    if(item1.InvoiceNo == item.InvoiceNo)
                        num += item1.Price * item1.Quantity;
                    num1 += item1.Price * item1.Quantity;
                }
                dgvProductInfo.Rows[index].Cells[4].Value = num;
                num = 0;
            }

            textBox1.Text = num1.ToString();
        }


        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            DateTime time = new DateTime(date1.Value.Year, date1.Value.Month, date1.Value.Day);
            DateTime time1 = new DateTime(time.Year, time.Month,1);
            time1 = time1.AddMonths(1).AddDays(-1);
            date1.Value = DateTime.ParseExact(time.Date.ToString("01/MM/yyyy"),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            date2.Value = DateTime.ParseExact(time1.Date.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            if(date2.Value < date1.Value)
            {
                MessageBox.Show("Lỗi thao tác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date2.Value = DateTime.Now;
                return;
            }
            List<Invoice> listtemp = new List<Invoice>(listlnvoice);
            listtemp = listlnvoice.Where(x => x.DeliveryDate >= date1.Value && x.DeliveryDate <= date2.Value).ToList();
            LoadData(listtemp);
        }
    }
}
