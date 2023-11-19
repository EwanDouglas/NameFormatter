namespace NameFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Declaring string variables to hold their place.

            string firstName = txtFirst.Text;   //To hold first name entry.
            string middleName = txtMiddle.Text; //To hold middle name entry.
            string lastName = txtLast.Text;     //To hold last name entry.
            string title = txtTitle.Text;           //To hold preferred title entry.

            //Combine the name entries, with a space and/or comma between them. 
            //Display the list of names.
            lstOutput.Items.Add(txtTitle.Text + " " + txtFirst.Text + " " + txtMiddle.Text + " " + txtLast.Text);
            lstOutput.Items.Add(txtFirst.Text + " " + txtMiddle.Text + " " + txtLast.Text);
            lstOutput.Items.Add(txtFirst.Text + " " + txtLast.Text);
            lstOutput.Items.Add(txtLast.Text + "," + txtFirst.Text + " " + txtMiddle.Text + "," + txtTitle.Text);
            lstOutput.Items.Add(txtLast.Text + "," + txtFirst.Text + " " + txtMiddle.Text);
            lstOutput.Items.Add(txtLast.Text + "," + txtFirst.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes.
            txtFirst.Text = "";
            txtMiddle.Text = "";
            txtLast.Text = "";
            txtTitle.Text = "";
            //Clear the listOutput control.
            lstOutput.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}