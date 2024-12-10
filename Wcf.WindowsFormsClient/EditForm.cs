using System;
using System.Windows.Forms;
using Wcf.Models;

namespace Wcf.WindowsFormsClient
{
    public partial class EditForm : Form
    {
        public Invoice Invoice { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Invoice invoice) : this()
        {
            this.Invoice = invoice;

            if (Invoice != null)
            {
                this.textBoxId.Text = Invoice.Id.ToString();
                this.textBoxNumber.Text = Invoice.Number;
                this.textBoxNIP.Text = Invoice.NIP;
                this.textBoxSeller.Text = Invoice.Seller;
                this.textBoxBuyer.Text = Invoice.Buyer;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Invoice == null)
            {
                Invoice = new Invoice();
            }

            Invoice.Number = this.textBoxNumber.Text;
            Invoice.NIP = this.textBoxNIP.Text;
            Invoice.Seller = this.textBoxSeller.Text;
            Invoice.Buyer = this.textBoxBuyer.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
