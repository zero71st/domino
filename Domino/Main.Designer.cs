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
            this.tbPin1 = new System.Windows.Forms.TextBox();
            this.tbPin2 = new System.Windows.Forms.TextBox();
            this.tbSno1 = new System.Windows.Forms.TextBox();
            this.tbBar1 = new System.Windows.Forms.TextBox();
            this.tbSno2 = new System.Windows.Forms.TextBox();
            this.tbBar2 = new System.Windows.Forms.TextBox();
            this.btLoadMessage = new System.Windows.Forms.Button();
            this.btSendVtextData = new System.Windows.Forms.Button();
            this.btReboot = new System.Windows.Forms.Button();
            this.btActivateGroup = new System.Windows.Forms.Button();
            this.btDeactivateGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSendMsg = new System.Windows.Forms.TextBox();
            this.tbReceiveMsg = new System.Windows.Forms.TextBox();
            this.ckHardcode = new System.Windows.Forms.CheckBox();
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
            this.btClose.Location = new System.Drawing.Point(588, 382);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(168, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gvCards
            // 
            this.gvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCards.Location = new System.Drawing.Point(36, 202);
            this.gvCards.Name = "gvCards";
            this.gvCards.Size = new System.Drawing.Size(516, 203);
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
            this.tbMessageName.Text = "dz";
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
            // btLoadMessage
            // 
            this.btLoadMessage.Location = new System.Drawing.Point(588, 130);
            this.btLoadMessage.Name = "btLoadMessage";
            this.btLoadMessage.Size = new System.Drawing.Size(168, 23);
            this.btLoadMessage.TabIndex = 18;
            this.btLoadMessage.Text = "Load Message";
            this.btLoadMessage.UseVisualStyleBackColor = true;
            this.btLoadMessage.Click += new System.EventHandler(this.btLoadMessage_Click);
            // 
            // btSendVtextData
            // 
            this.btSendVtextData.Location = new System.Drawing.Point(588, 159);
            this.btSendVtextData.Name = "btSendVtextData";
            this.btSendVtextData.Size = new System.Drawing.Size(168, 23);
            this.btSendVtextData.TabIndex = 19;
            this.btSendVtextData.Text = "Send Vtext Data";
            this.btSendVtextData.UseVisualStyleBackColor = true;
            this.btSendVtextData.Click += new System.EventHandler(this.btSendVtextData_Click);
            // 
            // btReboot
            // 
            this.btReboot.Location = new System.Drawing.Point(588, 101);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(168, 23);
            this.btReboot.TabIndex = 20;
            this.btReboot.Text = "Reboot";
            this.btReboot.UseVisualStyleBackColor = true;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // btActivateGroup
            // 
            this.btActivateGroup.Location = new System.Drawing.Point(588, 271);
            this.btActivateGroup.Name = "btActivateGroup";
            this.btActivateGroup.Size = new System.Drawing.Size(168, 23);
            this.btActivateGroup.TabIndex = 21;
            this.btActivateGroup.Text = "Activate Group";
            this.btActivateGroup.UseVisualStyleBackColor = true;
            // 
            // btDeactivateGroup
            // 
            this.btDeactivateGroup.Location = new System.Drawing.Point(588, 300);
            this.btDeactivateGroup.Name = "btDeactivateGroup";
            this.btDeactivateGroup.Size = new System.Drawing.Size(168, 23);
            this.btDeactivateGroup.TabIndex = 22;
            this.btDeactivateGroup.Text = "Deactivate Group";
            this.btDeactivateGroup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Send Message:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Receive Message:";
            // 
            // tbSendMsg
            // 
            this.tbSendMsg.Location = new System.Drawing.Point(165, 411);
            this.tbSendMsg.Name = "tbSendMsg";
            this.tbSendMsg.Size = new System.Drawing.Size(591, 23);
            this.tbSendMsg.TabIndex = 25;
            // 
            // tbReceiveMsg
            // 
            this.tbReceiveMsg.Location = new System.Drawing.Point(164, 440);
            this.tbReceiveMsg.Name = "tbReceiveMsg";
            this.tbReceiveMsg.Size = new System.Drawing.Size(592, 23);
            this.tbReceiveMsg.TabIndex = 26;
            // 
            // ckHardcode
            // 
            this.ckHardcode.AutoSize = true;
            this.ckHardcode.Location = new System.Drawing.Point(588, 74);
            this.ckHardcode.Name = "ckHardcode";
            this.ckHardcode.Size = new System.Drawing.Size(96, 21);
            this.ckHardcode.TabIndex = 27;
            this.ckHardcode.Text = "Hard code";
            this.ckHardcode.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 475);
            this.Controls.Add(this.ckHardcode);
            this.Controls.Add(this.tbReceiveMsg);
            this.Controls.Add(this.tbSendMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDeactivateGroup);
            this.Controls.Add(this.btActivateGroup);
            this.Controls.Add(this.btReboot);
            this.Controls.Add(this.btSendVtextData);
            this.Controls.Add(this.btLoadMessage);
            this.Controls.Add(this.tbBar2);
            this.Controls.Add(this.tbSno2);
            this.Controls.Add(this.tbBar1);
            this.Controls.Add(this.tbSno1);
            this.Controls.Add(this.tbPin2);
            this.Controls.Add(this.tbPin1);
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
        private System.Windows.Forms.TextBox tbPin1;
        private System.Windows.Forms.TextBox tbPin2;
        private System.Windows.Forms.TextBox tbSno1;
        private System.Windows.Forms.TextBox tbBar1;
        private System.Windows.Forms.TextBox tbSno2;
        private System.Windows.Forms.TextBox tbBar2;
        private System.Windows.Forms.Button btLoadMessage;
        private System.Windows.Forms.Button btSendVtextData;
        private System.Windows.Forms.Button btReboot;
        private System.Windows.Forms.Button btActivateGroup;
        private System.Windows.Forms.Button btDeactivateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSendMsg;
        private System.Windows.Forms.TextBox tbReceiveMsg;
        private System.Windows.Forms.CheckBox ckHardcode;
    }
}

