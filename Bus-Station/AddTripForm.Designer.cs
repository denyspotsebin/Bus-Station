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
            txtStationName = new TextBox();
            btnAddStation = new Button();
            btnRemoveStation = new Button();
            lbStations = new ListBox();
            label2 = new Label();
            label1 = new Label();
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
            panel1.Controls.Add(txtStationName);
            panel1.Controls.Add(btnAddStation);
            panel1.Controls.Add(btnRemoveStation);
            panel1.Controls.Add(lbStations);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(numTotalSeats);
            panel1.Controls.Add(dtpDeparture);
            panel1.Controls.Add(txtDestination);
            panel1.Controls.Add(txtNumber);
            panel1.Location = new Point(131, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 658);
            panel1.TabIndex = 0;
            // 
            // txtStationName
            // 
            txtStationName.Location = new Point(151, 135);
            txtStationName.Name = "txtStationName";
            txtStationName.PlaceholderText = "Місце зупинки . . .";
            txtStationName.Size = new Size(302, 23);
            txtStationName.TabIndex = 11;
            // 
            // btnAddStation
            // 
            btnAddStation.Location = new Point(459, 121);
            btnAddStation.Name = "btnAddStation";
            btnAddStation.Size = new Size(119, 49);
            btnAddStation.TabIndex = 10;
            btnAddStation.Text = "Додати зупинку";
            btnAddStation.UseVisualStyleBackColor = true;
            btnAddStation.Click += btnAddStation_Click;
            // 
            // btnRemoveStation
            // 
            btnRemoveStation.Location = new Point(481, 178);
            btnRemoveStation.Name = "btnRemoveStation";
            btnRemoveStation.Size = new Size(97, 184);
            btnRemoveStation.TabIndex = 9;
            btnRemoveStation.Text = "Видалити обрану";
            btnRemoveStation.UseVisualStyleBackColor = true;
            btnRemoveStation.Click += btnRemoveStation_Click;
            // 
            // lbStations
            // 
            lbStations.FormattingEnabled = true;
            lbStations.Location = new Point(151, 178);
            lbStations.Name = "lbStations";
            lbStations.Size = new Size(311, 184);
            lbStations.TabIndex = 8;
            lbStations.SelectedIndexChanged += lbStations_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 430);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 7;
            label2.Text = "Кількість місць";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 387);
            label1.Name = "label1";
            label1.Size = new Size(131, 17);
            label1.TabIndex = 6;
            label1.Text = "Час відправлення ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(378, 484);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 89);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(151, 484);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 89);
            btnSave.TabIndex = 4;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numTotalSeats
            // 
            numTotalSeats.Location = new Point(151, 430);
            numTotalSeats.Name = "numTotalSeats";
            numTotalSeats.Size = new Size(427, 23);
            numTotalSeats.TabIndex = 3;
            // 
            // dtpDeparture
            // 
            dtpDeparture.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDeparture.Format = DateTimePickerFormat.Custom;
            dtpDeparture.Location = new Point(151, 387);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(427, 23);
            dtpDeparture.TabIndex = 2;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(151, 92);
            txtDestination.Name = "txtDestination";
            txtDestination.PlaceholderText = "Місце призначення . . .";
            txtDestination.Size = new Size(427, 23);
            txtDestination.TabIndex = 1;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(151, 50);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Номер рейсу . . .";
            txtNumber.Size = new Size(427, 23);
            txtNumber.TabIndex = 0;
            // 
            // AddTripForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 736);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddTripForm";
            Text = "Додавання нового рейсу";
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
        private Label label2;
        private Label label1;
        private Button btnRemoveStation;
        private ListBox lbStations;
        private TextBox txtStationName;
        private Button btnAddStation;
    }
}