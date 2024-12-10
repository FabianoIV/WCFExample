using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wcf.Models;
using Wcf.ServiceContract;

namespace Wcf.WindowsFormsClient
{
    public partial class Form1 : Form
    {
        string uri = "net.tcp://localhost:6565/MessageService";

        public NetTcpBinding Binding { get; set; }
        public ChannelFactory<IMessageService> ChannelFactory { get; set; }
        public EndpointAddress Endpoint { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeConnection();
        }

        public void InitializeConnection()
        {
            Binding = new NetTcpBinding(SecurityMode.None);
            ChannelFactory = new ChannelFactory<IMessageService>(Binding);
            Endpoint = new EndpointAddress(uri);
        }

        public List<Invoice> GetInvoices()
        {
            var proxy = ChannelFactory.CreateChannel(Endpoint);
            var result = proxy.GetInvoices();
            return result;
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            //var items = GetMessage();
            //listViewResult.Items.AddRange(items.Select(i => new ListViewItem(i)).ToArray());

            listViewResult.Items.Clear();
            var invoices = GetInvoices();
            listViewResult.Items.AddRange(invoices.Select(i => {
                var listViewItem = new ListViewItem(i.Number + ", NIP: " + i.NIP + ", liczba pozycji:" + i.Positions.Count)
                {
                    Tag = i
                };

                return listViewItem;
            }).ToArray());
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            var selectedItems = listViewResult.SelectedItems.OfType<ListViewItem>().ToList();

            listViewResult.SelectedItems.OfType<ListViewItem>().ToList().ForEach(i => { 
                var invoice = i.Tag as Invoice;
                var proxy = ChannelFactory.CreateChannel(Endpoint);
                proxy.DeleteInvoice(invoice.Id);
                listViewResult.Items.Remove(i);
            });
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listViewResult.SelectedItems.OfType<ListViewItem>().FirstOrDefault();

            if (selectedItem == null)
            {
                return;
            }

            var invoice = selectedItem.Tag as Invoice;

            var form = new EditForm(invoice);

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                var proxy = ChannelFactory.CreateChannel(Endpoint);
                proxy.UpdateInvoice(form.Invoice);
                selectedItem.Text = form.Invoice.Number + ", NIP: " + form.Invoice.NIP;
            }
        }
    }
}
