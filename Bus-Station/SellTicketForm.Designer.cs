namespace Bus_Station
{
    partial class SellTicketForm
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            btnOk = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(104, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 660);
            panel1.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(423, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(220, 143);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(423, 23);
            txtSurname.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(220, 241);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(423, 66);
            btnOk.TabIndex = 2;
            btnOk.Text = "Оформити квиток";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // SellTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 736);
            Controls.Add(panel1);
            Name = "SellTicketForm";
            Text = "SellTicketForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOk;
        private TextBox txtSurname;
        private TextBox txtName;
    }
}