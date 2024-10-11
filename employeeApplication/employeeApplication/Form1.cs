namespace employeeApplication
{
    public partial class FrmEmployeeDatabase : Form
    {
        public FrmEmployeeDatabase()
        {
            InitializeComponent();
            this.buttonSubmit.Enabled = false;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            this.createHeaders();
           
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(this.textBoxEmpID.Text, this.textBoxFName.Text, this.textBoxLName.Text, this.textBoxPosition.Text);
            this.dataGridViewEmployeList.Rows.Add(emp.getFields());
            this.clearFields();


        }
        private void createHeaders()
        {
            this.dataGridViewEmployeList.Columns.Add("col_id", "ID");
            this.dataGridViewEmployeList.Columns.Add("col_fName", "First Name");
            this.dataGridViewEmployeList.Columns.Add("col_lName", "Last Name");
            this.dataGridViewEmployeList.Columns.Add("col_position", "Position");
        }

        private void clearFields()
        {
            this.textBoxEmpID.Clear();
            this.textBoxFName.Clear();
            this.textBoxLName.Clear();
            this.textBoxPosition.Clear();
            this.textBoxEmpID.Focus();

            this.buttonSubmit.Enabled = false;

        }

        private void enableSubmitButton()
        {
            if (this.textBoxEmpID.Text.Length > 0 && this.textBoxFName.Text.Length > 0 && this.textBoxLName.Text.Length > 0 && this.textBoxPosition.Text.Length > 0)
            {
                this.buttonSubmit.Enabled = true;
            }
        }

        private void textBoxPosition_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonSubmit.PerformClick();
            }
            this.enableSubmitButton();
        }



        private void textBoxEmpID_KeyUp(object sender, KeyEventArgs e)
        {
            this.enableSubmitButton();
        }

        private void textBoxFName_KeyUp(object sender, KeyEventArgs e)
        {
            this.enableSubmitButton();
        }

        private void textBoxLName_KeyUp(object sender, KeyEventArgs e)
        {
            this.enableSubmitButton();
        }

        private void dataGridViewEmployeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridViewEmployeListAut
        }
    }
}
