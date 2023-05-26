using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        public dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hunter fm = new hunter();
            this.Hide();
            fm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void uC_Additems1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
        }
      
    }
}
