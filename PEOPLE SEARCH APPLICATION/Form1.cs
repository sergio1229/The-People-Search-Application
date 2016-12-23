using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEOPLE_SEARCH_APPLICATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.profileTableAdapter.Fill(this.searchdbDataSet.Profile);
                    profileBindingSource.DataSource = this.searchdbDataSet.Profile;
                    //dataGridView.DataSource = profileBindingSource;
                }
                else
                {
                    var query = from o in this.searchdbDataSet.Profile
                                where o.PersonName.Contains(txtSearch.Text) || o.Age == txtSearch.Text || o.PhoneNumber == txtSearch.Text || o.Interests == txtSearch.Text || o.Address.Contains(txtSearch.Text)
                                select o;
                    profileBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void datagridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS PROFILE ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    profileBindingSource.RemoveCurrent();
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd=new OpenFileDialog() { Filter="JPEG|*.jpg",ValidateNames=true,Multiselect=false})
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
                        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtPersonName.Focus();
                this.searchdbDataSet.Profile.AddProfileRow(this.searchdbDataSet.Profile.NewProfileRow());
                profileBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profileBindingSource.ResetBindings(false);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtPersonName.Focus();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            profileBindingSource.ResetBindings(false);
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                profileBindingSource.EndEdit();
                profileTableAdapter.Update(this.searchdbDataSet.Profile);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profileBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'searchdbDataSet.Profile' table. You can move, or remove it, as needed.
            this.profileTableAdapter.Fill(this.searchdbDataSet.Profile);
            profileBindingSource.DataSource = this.searchdbDataSet.Profile;
        }
    }
}
