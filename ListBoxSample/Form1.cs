using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace ListBoxSample
{
    public partial class Form1 : Form
    {

        List<StateList> states = new List<StateList>();
        public Form1()
        {
            InitializeComponent();           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddState(int id, string name, string abbrev)
        {
            states.Add(new StateList { Id = id, Name = name, Abbrev = abbrev });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "" && txtState.Text != "" && txtAbrev.Text != "")
            {
                int id = Int16.Parse(txtID.Text.ToString());
                string name = txtState.Text.ToString();
                string abrev = txtAbrev.Text.ToString();
                AddState(id, name, abrev);
            }
            else MessageBox.Show("Check the textboxes. There is an error.");
                        
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetBindings();
        }

        private void comboStates_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpeningItems();
        }

        private void  OpeningItems()
        {
            AddState(1, "Green", "Sock");
            AddState(2, "Red", "Pattern");
            AddState(3, "Orange", "Juice");
            SetBindings();
        }

        private void SetBindings()
        {
            listbStates.DataSource = null;
            listbStates.DataSource = states;
            listbStates.DisplayMember = "Name";
            comboStates.DataSource = null;
            comboStates.DataSource = states;
            comboStates.DisplayMember = "Name";

        }
    }

    public class StateList
        {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Abbrev { get; set; }
        }
}