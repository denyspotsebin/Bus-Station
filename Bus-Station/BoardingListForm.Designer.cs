namespace Bus_Station
{
    partial class BoardingListForm
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
            lbTickets = new ListBox();
            btnClose = new Button();
            btnReturnTicket = new Button();
            SuspendLayout();
            // 
            // lbTickets
            // 
            lbTickets.FormattingEnabled = true;
            lbTickets.Location = new Point(71, 34);
            lbTickets.Name = "lbTickets";
            lbTickets.Size = new Size(354, 619);
            lbTickets.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(658, 181);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(186, 67);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрити\r\n";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReturnTicket
            // 
            btnReturnTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturnTicket.Location = new Point(658, 65);
            btnReturnTicket.Name = "btnReturnTicket";
            btnReturnTicket.Size = new Size(186, 67);
            btnReturnTicket.TabIndex = 3;
            btnReturnTicket.Text = "Повернути квиток";
            btnReturnTicket.UseVisualStyleBackColor = true;
            btnReturnTicket.Click += btnReturnTicket_Click;
            // 
            // BoardingListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 736);
            Controls.Add(btnReturnTicket);
            Controls.Add(btnClose);
            Controls.Add(lbTickets);
            MinimumSize = new Size(900, 700);
            Name = "BoardingListForm";
            Text = "Відомість про рейс";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTickets;
        private Button btnClose;
        private Button btnReturnTicket;
    }
}