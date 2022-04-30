using System;
using System.Windows.Forms;
namespace MerisToSQL
{ 
    
    public partial class Main : Form
    {
        ADO ado = new ADO();
       
        private void crtbtn_Click(object sender, EventArgs e)
        {
            if(databasebox.Text.Trim() == "" || merise.Text.Trim() == "")
            {
                MessageBox.Show("Base is missing or Meris");
                return;
            }
            MeriseSQL ms = new MeriseSQL(merise.Text, databasebox.Text);
            finishedres.Text = ms.createQuery();
            tablesbox.Text = $"{ms.TablesCount} Tables";
            Clipboard.Clear();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ado.deconnecter();
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ado.connecter();
        }

        private void use_Click(object sender, EventArgs e)
        {
            Help hl = new Help();
            hl.ShowDialog();
        }

        private void CSQbtn_Click(object sender, EventArgs e)
        {
            if (finishedres.Text == "")
            {
                MessageBox.Show("There is no Data To Copy");
            }
            else
            {
                Clipboard.Clear();
                Clipboard.SetText(finishedres.Text);
            }
        }
    }
}
