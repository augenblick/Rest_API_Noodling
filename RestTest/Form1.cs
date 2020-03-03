using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RestTest
{
    public partial class FormRestTest : Form
    {
        public FormRestTest()
        {
            System.Diagnostics.Debug.WriteLine("Howdy");
            InitializeComponent();
            textRestURI.SelectAll();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textRestURI.Text))
            {
                MessageBox.Show("Please enter the URI for a REST API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textRestURI.Focus();
                return;
            }

            RestClient client = new RestClient();
            client.restURI = textRestURI.Text;
            try
            {
                textRestResponse.Text = client.makeRequest().Result;
            }
            catch(Exception f)
            {
                MessageBox.Show($"{System.Environment.NewLine} {f.Message} {System.Environment.NewLine} {f.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
