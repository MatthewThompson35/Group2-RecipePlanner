using RecipePlannerDesktopApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipePlannerDesktopApplication
{
    public partial class MainScreen : Form
    {
        private AddNameViewModel viewModel;

        public MainScreen()
        {
            InitializeComponent();
            this.viewModel = new AddNameViewModel();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            String name = "";

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                this.errorNameLabel.Visible = true;
            }
            else
            {
                this.errorNameLabel.Visible = false;
                name = nameTextBox.Text;

                this.viewModel.AddName(name);

                //Do Something with name
                MessageBox.Show("Hello " + name + "!, your name was added to the database");
            }
        }

    }
}
