using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstractions.Interfaces.Models;
using Repositories.Models;

namespace CustomerEditorGUI
{
    public partial class FormUpdate : Form
    {
        public Abstractions.Interfaces.Models.ICustomer customer;

        private readonly Abstractions.Interfaces.Services.ICustomerService _customerService;


        public FormUpdate(Abstractions.Interfaces.Services.ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            if (customer != null)
            {
                tb_firstnameForm3.Text = customer.FirstName;
                tb_lastnameForm3.Text = customer.LastName;
                tb_phonenumberForm3.Text = customer.PhoneNumber;
                tb_EmailForm3.Text = customer.Email;
            }
            else
            {
                tb_firstnameForm3.Text = string.Empty;
                tb_lastnameForm3.Text= string.Empty;
                tb_EmailForm3.Text= string.Empty;
                tb_phonenumberForm3.Text= string.Empty;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                _customerService.UpdateCustomer(tb_firstnameForm3.Text, tb_lastnameForm3.Text, 
                    tb_phonenumberForm3.Text, tb_EmailForm3.Text, customer.ID);
            }
            else
            {
                _customerService.CreateCustomer(tb_firstnameForm3.Text, tb_lastnameForm3.Text, 
                    tb_phonenumberForm3.Text, tb_EmailForm3.Text);
            }


            this.Close();
        }
    }
}
