using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmSubscriber : Form
    {
        List<Subscriber> Subscribers;
        public FrmSubscriber()
        {

            InitializeComponent();

            Subscribers = new List<Subscriber>();
            {
                for (int i = 0; i < 5; i++)

                {
                    Subscribers.Add(new Subscriber { FirstName = $"Sanaz{i + 1}", LastName = $"fathali{i + 1}", CellPhone = $"09124193469{i + 1}", Code = $"12345{i + 1}" });
                }
                dataGridView1.DataSource = Subscribers;

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSubscriber_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Subscriber subscriber = new Subscriber(txtName.Text, txtLastName.Text, txtCellphone.Text, txtcode.Text);
                Subscribers.Add(subscriber);

                MessageBox.Show("One Item Added...");

                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtCellphone.Text = string.Empty;
                txtcode.Text = string.Empty;


                txtName.Focus();
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Subscribers;
            dataGridView1.Refresh();

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNumeric = true;

            IsNumeric = Base.ToValidateNumericTextBox(e.KeyChar);

            if (IsNumeric == false)
            {

                MessageBox.Show("Only Numbers are valid...");
                e.Handled = true;

            }
        }

        private void txtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNumeric = true;

            IsNumeric = Base.ToValidateNumericTextBox(e.KeyChar);

            if (IsNumeric == false)
            {

                MessageBox.Show("Only Numbers are valid...");
                e.Handled = true;

            }
        }
    }
}
