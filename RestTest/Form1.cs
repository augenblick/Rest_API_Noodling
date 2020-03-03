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
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            
            RestClient client = new RestClient();
            client.restURI = "https://jsonplaceholder.typicode.com/todos";
            textRestResponse.Text = client.makeRequest().Result;

        }
    }
}
