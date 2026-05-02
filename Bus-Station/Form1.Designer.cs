namespace Bus_Station
{
    partial class Form1
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
            dgvTrips = new DataGridView();
            panel1 = new Panel();
            btnAddTrip = new Button();
            btnSellTicket = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTrips
            // 
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrips.Dock = DockStyle.Fill;
            dgvTrips.Location = new Point(0, 196);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.Size = new Size(1222, 665);
            dgvTrips.TabIndex = 0;
            dgvTrips.CellContentClick += dgvTrips_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddTrip);
            panel1.Controls.Add(btnSellTicket);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 196);
            panel1.TabIndex = 1;
            // 
            // btnAddTrip
            // 
            btnAddTrip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddTrip.Location = new Point(958, 93);
            btnAddTrip.Name = "btnAddTrip";
            btnAddTrip.Size = new Size(202, 61);
            btnAddTrip.TabIndex = 3;
            btnAddTrip.Text = "Додати рейс";
            btnAddTrip.UseVisualStyleBackColor = true;
            btnAddTrip.Click += btnAddTrip_Click;
            // 
            // btnSellTicket
            // 
            btnSellTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSellTicket.Location = new Point(958, 12);
            btnSellTicket.Name = "btnSellTicket";
            btnSellTicket.Size = new Size(202, 58);
            btnSellTicket.TabIndex = 2;
            btnSellTicket.Text = "Оформити квиток";
            btnSellTicket.UseVisualStyleBackColor = true;
            btnSellTicket.Click += btnSellTicket_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(627, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Пошук\r\n";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(168, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(428, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 861);
            Controls.Add(dgvTrips);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTrips;
        private Panel panel1;
        private Button btnAddTrip;
        private Button btnSellTicket;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
