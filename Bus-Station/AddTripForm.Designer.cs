namespace Bus_Station
{
    partial class AddTripForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            numTotalSeats = new NumericUpDown();
            dtpDeparture = new DateTimePicker();
            txtDestination = new TextBox();
            txtNumber = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalSeats).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(numTotalSeats);
            panel1.Controls.Add(dtpDeparture);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(txtNumber);
            panel1.Location = new Point(131, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 658);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(372, 316);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 89);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(151, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 89);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numTotalSeats
            // 
            numTotalSeats.Location = new Point(151, 211);
            numTotalSeats.Name = "numTotalSeats";
            numTotalSeats.Size = new Size(379, 23);
            numTotalSeats.TabIndex = 3;
            // 
            // dtpDeparture
            // 
            dtpDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDeparture.Format = DateTimePickerFormat.Custom;
            dtpDeparture.Location = new Point(151, 166);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(379, 23);
            dtpDeparture.TabIndex = 2;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(151, 123);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(379, 23);
            txtDestination.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(151, 76);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(379, 23);
            txtNumber.TabIndex = 0;
            // 
            // AddTripForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 736);
            Controls.Add(panel1);
            Name = "AddTripForm";
            Text = "AddTripForm";
            Load += AddTripForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalSeats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown numTotalSeats;
        private DateTimePicker dtpDeparture;
        private TextBox txtDestination;
        private TextBox txtNumber;
    }
}