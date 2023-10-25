using Abstractions.Interfaces.Models;
using System.Windows.Forms;

namespace CustomerEditorGUI
{
    public partial class Form1 : Form
    {
        private readonly Abstractions.Interfaces.Services.ICustomerService _customerService;
        private readonly FormUpdate _formUpdate;
        public Form1(Abstractions.Interfaces.Services.ICustomerService customerService, FormUpdate formUpdate)
        {
            InitializeComponent(); //metode fra Form der køre alle componenter 
            _customerService = customerService;
            _formUpdate = formUpdate;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllCustomerForDataGridView();
        }





        /// <summary>
        /// method for DataGridView
        /// </summary>
        private void LoadAllCustomerForDataGridView()
        {
            //send all customers into a variable
            var customerList = _customerService.GetAllCutomers();

            //bindingSource updetere datagridviewen heletiden
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = customerList;

            //send the list into a dataGridView 
            dGridV_CustomerList.DataSource = bindingSource;
        }





        //denne metode skal hente alle detaljer om en kunde og sende den til textbox
        private void ShowCustomerDetails(Abstractions.Interfaces.Models.ICustomer customer)
        {
            tb_firstname.Text = customer.FirstName;
            tb_lastname.Text = customer.LastName;
            tb_Email.Text = customer.Email;
            tb_phonenumber.Text = customer.PhoneNumber;
        }



        //denne metode sender den selected item fra datagridview og bruger ShowCustomerDetaljer
        private void dGridV_CustomerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dGridV_CustomerList.SelectedRows.Count > 0) //It's making sure that the user has actually selected something before proceeding.
            {
                ShowCustomerDetails((ICustomer)dGridV_CustomerList.SelectedRows[0].DataBoundItem);
            }
        }




        private void dGridV_CustomerList_DoubleClick(object sender, EventArgs e)
        {
            _formUpdate.customer = (ICustomer)dGridV_CustomerList.SelectedRows[0].DataBoundItem;
            _formUpdate.ShowDialog();
        }



        //public Abstractions.Interfaces.Models.ICustomer Customer;
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            var customer = (ICustomer)dGridV_CustomerList.SelectedRows[0].DataBoundItem;
            _customerService.DeleteCustomer(customer.ID);
            LoadAllCustomerForDataGridView();
        }




        private void CreateCustomerBtn_Click(object sender, EventArgs e)
        {

            //ved click så skal textboxer være tom
            tb_firstname.Text = string.Empty;
            tb_lastname.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_phonenumber.Text = string.Empty;

            _formUpdate.ShowDialog();
            LoadAllCustomerForDataGridView();
        }
    }
}