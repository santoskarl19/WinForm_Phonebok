using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Phonebook
{
    public partial class Form1 : Form
    {
        // dictionary to store data

        SortedDictionary<string, Person> personnel = new SortedDictionary<string, Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personnel.Add("Karl", new Person()
            {
                FirstName = "Karl",
                LastName = "Santos",
                MobilePhone = 5201231234,
                WorkPhone = 6691119999,
                Address = "Arizona"
            });
            personnel.Add("Barney", new Person()
            {
                FirstName = "Barney",
                LastName = "Stinson",
                MobilePhone = 6091239999,
                WorkPhone = 5209991111,
                Address = "New York"
            });
            personnel.Add("Nick", new Person()
            {
                FirstName = "Nick",
                LastName = "Miller",
                MobilePhone = 3181235555,
                WorkPhone = 6092225555,
                Address = "California"
            });
            personnel.Add("Marshall", new Person()
            {
                FirstName = "Marshall",
                LastName = "Erickson",
                MobilePhone = 5207771234,
                WorkPhone = 6693339999,
                Address = "Minnesota"
            });

            // assign dictionary as data source for data grid
            personGrid.DataSource = personnel.Values.ToList();

            // hide personal info
            personGrid.Columns["MobilePhone"].Visible = false;
            personGrid.Columns["Address"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // creating new person object
            Person newPerson = new Person();

            newPerson.FirstName = txtFirstName.Text;
            newPerson.LastName = txtLastName.Text;
            newPerson.MobilePhone = Convert.ToInt64(txtMobilePhone.Text);
            newPerson.WorkPhone = Convert.ToInt64(txtWorkPhone.Text);
            newPerson.Address = txtAddress.Text;

            // adding new person to dictionary
            personnel.Add(newPerson.FirstName, newPerson);

            MessageBox.Show("Record Added!");

            //reset info on grid box
            personGrid.DataSource = null;
            personGrid.DataSource = personnel.Values.ToList();
            // hide personal info
            personGrid.Columns["MobilePhone"].Visible = false;
            personGrid.Columns["Address"].Visible = false;

            //clear text data field
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtMobilePhone.Clear();
            txtWorkPhone.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get selected row here. Count will increase when user select from gridbox
            if (personGrid.SelectedRows.Count > 0)
            {
                // assign key value from selected row to a string
                string selectedKey = personGrid.SelectedRows[0].Cells["FirstName"].Value.ToString();

                // remove from dictionary
                personnel.Remove(selectedKey);
            }

            // display warning message
            MessageBox.Show("Do you want to delete the record?", "Warning", MessageBoxButtons.YesNo);

            //reset info on grid box
            personGrid.DataSource = null;
            personGrid.DataSource = personnel.Values.ToList();
            // hide personal info
            personGrid.Columns["MobilePhone"].Visible = false;
            personGrid.Columns["Address"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // assigning text field value to a string
            string searchQuery = txtSearchDisplay.Text;

            // check if searchQuary is a key in the dictionary
            if (personnel.ContainsKey(searchQuery))
            {
                MessageBox.Show("Name Found!");

                // create person object to store individual data
                Person person = personnel[searchQuery];
                string mobilePhone = person.MobilePhone.ToString();
                string address = person.Address;

                txtAddressDisplay.Text = address;
                txtMobileDisplay.Text = mobilePhone;
            }
            else 
            {
                MessageBox.Show("Name not found!");

                txtSearchDisplay.Clear();
            }

        }

        private void txtWorkPhone_Validating(object sender, CancelEventArgs e)
        {
            long num;

            if (!Int64.TryParse(txtWorkPhone.Text, out num))
            {
                MessageBox.Show("Please input a number!");
                e.Cancel = true;
                txtWorkPhone.Clear();
            }
        }

        private void txtMobilePhone_Validating(object sender, CancelEventArgs e)
        {
            long num;

            if (!Int64.TryParse(txtMobilePhone.Text, out num))
            {
                MessageBox.Show("Please input a number!");
                e.Cancel = true;
                txtMobilePhone.Clear();
            }
        }
    }
}
