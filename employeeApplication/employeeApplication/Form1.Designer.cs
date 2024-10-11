namespace employeeApplication
{
    partial class FrmEmployeeDatabase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAddEmp = new Label();
            labelEmpID = new Label();
            labelFName = new Label();
            labelLName = new Label();
            labelPosition = new Label();
            textBoxEmpID = new TextBox();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            textBoxPosition = new TextBox();
            buttonSubmit = new Button();
            dataGridViewEmployeList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeList).BeginInit();
            SuspendLayout();
            // 
            // labelAddEmp
            // 
            labelAddEmp.AutoSize = true;
            labelAddEmp.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddEmp.Location = new Point(55, 37);
            labelAddEmp.Name = "labelAddEmp";
            labelAddEmp.Size = new Size(249, 36);
            labelAddEmp.TabIndex = 0;
            labelAddEmp.Text = "Add Employee:";
            // 
            // labelEmpID
            // 
            labelEmpID.AutoSize = true;
            labelEmpID.Font = new Font("Segoe UI", 8F);
            labelEmpID.Location = new Point(63, 116);
            labelEmpID.Name = "labelEmpID";
            labelEmpID.Size = new Size(136, 30);
            labelEmpID.TabIndex = 1;
            labelEmpID.Text = "Employee ID";
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Font = new Font("Segoe UI", 8F);
            labelFName.Location = new Point(63, 198);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(117, 30);
            labelFName.TabIndex = 2;
            labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLName.Location = new Point(63, 296);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(112, 30);
            labelLName.TabIndex = 3;
            labelLName.Text = "Last Name";
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPosition.Location = new Point(63, 395);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(86, 30);
            labelPosition.TabIndex = 4;
            labelPosition.Text = "Position";
            // 
            // textBoxEmpID
            // 
            textBoxEmpID.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmpID.Location = new Point(61, 149);
            textBoxEmpID.Name = "textBoxEmpID";
            textBoxEmpID.Size = new Size(361, 32);
            textBoxEmpID.TabIndex = 5;
            // 
            // textBoxFName
            // 
            textBoxFName.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFName.Location = new Point(63, 231);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(359, 32);
            textBoxFName.TabIndex = 6;
            textBoxFName.KeyUp += textBoxFName_KeyUp;
            // 
            // textBoxLName
            // 
            textBoxLName.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLName.Location = new Point(63, 329);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(359, 32);
            textBoxLName.TabIndex = 7;
            textBoxLName.KeyUp += textBoxLName_KeyUp;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPosition.Location = new Point(63, 428);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(359, 32);
            textBoxPosition.TabIndex = 8;
            textBoxPosition.TextChanged += textBox4_TextChanged;
            textBoxPosition.KeyUp += textBoxPosition_KeyUp;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.LightSteelBlue;
            buttonSubmit.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(169, 477);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(150, 46);
            buttonSubmit.TabIndex = 9;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // dataGridViewEmployeList
            // 
            dataGridViewEmployeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeList.Location = new Point(493, 148);
            dataGridViewEmployeList.Name = "dataGridViewEmployeList";
            dataGridViewEmployeList.RowHeadersWidth = 82;
            dataGridViewEmployeList.Size = new Size(836, 312);
            dataGridViewEmployeList.TabIndex = 10;
            dataGridViewEmployeList.CellContentClick += dataGridViewEmployeList_CellContentClick;
            // 
            // FrmEmployeeDatabase
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1542, 576);
            Controls.Add(dataGridViewEmployeList);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPosition);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(textBoxEmpID);
            Controls.Add(labelPosition);
            Controls.Add(labelLName);
            Controls.Add(labelFName);
            Controls.Add(labelEmpID);
            Controls.Add(labelAddEmp);
            Font = new Font("Arial", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "FrmEmployeeDatabase";
            Text = "Employee Database";
            Load += FrmEmployeeDatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddEmp;
        private Label labelEmpID;
        private Label labelFName;
        private Label labelLName;
        private Label labelPosition;
        private TextBox textBoxEmpID;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private TextBox textBoxPosition;
        private Button buttonSubmit;
        private DataGridView dataGridViewEmployeList;
    }
}
