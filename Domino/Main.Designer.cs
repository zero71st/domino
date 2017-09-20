namespace Domino
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.MaskedTextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.gvCards = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMessageName = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.tbPin1 = new System.Windows.Forms.TextBox();
            this.tbPin2 = new System.Windows.Forms.TextBox();
            this.tbSno1 = new System.Windows.Forms.TextBox();
            this.tbBar1 = new System.Windows.Forms.TextBox();
            this.tbSno2 = new System.Windows.Forms.TextBox();
            this.tbBar2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domino IP:";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(36, 35);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(229, 23);
            this.tbIPAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(286, 35);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(77, 23);
            this.tbPort.TabIndex = 4;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(384, 35);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(121, 23);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(511, 35);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(121, 23);
            this.btDisconnect.TabIndex = 6;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(557, 379);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // gvCards
            // 
            this.gvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCards.Location = new System.Drawing.Point(36, 208);
            this.gvCards.Name = "gvCards";
            this.gvCards.Size = new System.Drawing.Size(596, 112);
            this.gvCards.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message Name:";
            // 
            // tbMessageName
            // 
            this.tbMessageName.Location = new System.Drawing.Point(36, 101);
            this.tbMessageName.Name = "tbMessageName";
            this.tbMessageName.Size = new System.Drawing.Size(166, 23);
            this.tbMessageName.TabIndex = 10;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(511, 326);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(121, 23);
            this.btPrint.TabIndex = 11;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // tbPin1
            // 
            this.tbPin1.Location = new System.Drawing.Point(254, 101);
            this.tbPin1.Name = "tbPin1";
            this.tbPin1.Size = new System.Drawing.Size(100, 23);
            this.tbPin1.TabIndex = 12;
            this.tbPin1.Text = "PIN1";
            // 
            // tbPin2
            // 
            this.tbPin2.Location = new System.Drawing.Point(452, 101);
            this.tbPin2.Name = "tbPin2";
            this.tbPin2.Size = new System.Drawing.Size(100, 23);
            this.tbPin2.TabIndex = 13;
            this.tbPin2.Text = "PIN2";
            // 
            // tbSno1
            // 
            this.tbSno1.Location = new System.Drawing.Point(254, 130);
            this.tbSno1.Name = "tbSno1";
            this.tbSno1.Size = new System.Drawing.Size(100, 23);
            this.tbSno1.TabIndex = 14;
            this.tbSno1.Text = "SNO1";
            // 
            // tbBar1
            // 
            this.tbBar1.Location = new System.Drawing.Point(254, 159);
            this.tbBar1.Name = "tbBar1";
            this.tbBar1.Size = new System.Drawing.Size(100, 23);
            this.tbBar1.TabIndex = 15;
            this.tbBar1.Text = "BAR1";
            // 
            // tbSno2
            // 
            this.tbSno2.Location = new System.Drawing.Point(452, 130);
            this.tbSno2.Name = "tbSno2";
            this.tbSno2.Size = new System.Drawing.Size(100, 23);
            this.tbSno2.TabIndex = 16;
            this.tbSno2.Text = "SNO2";
            // 
            // tbBar2
            // 
            this.tbBar2.Location = new System.Drawing.Point(452, 159);
            this.tbBar2.Name = "tbBar2";
            this.tbBar2.Size = new System.Drawing.Size(100, 23);
            this.tbBar2.TabIndex = 17;
            this.tbBar2.Text = "BAR2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 414);
            this.Controls.Add(this.tbBar2);
            this.Controls.Add(this.tbSno2);
            this.Controls.Add(this.tbBar1);
            this.Controls.Add(this.tbSno1);
            this.Controls.Add(this.tbPin2);
            this.Controls.Add(this.tbPin1);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.tbMessageName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvCards);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.gvCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbPort;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView gvCards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessageName;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox tbPin1;
        private System.Windows.Forms.TextBox tbPin2;
        private System.Windows.Forms.TextBox tbSno1;
        private System.Windows.Forms.TextBox tbBar1;
        private System.Windows.Forms.TextBox tbSno2;
        private System.Windows.Forms.TextBox tbBar2;
    }
}

