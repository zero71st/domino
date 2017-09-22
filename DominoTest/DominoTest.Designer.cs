namespace DominoTest
{
    partial class DominoTest
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
            this.tbVtextName = new System.Windows.Forms.TextBox();
            this.btLoadMessage = new System.Windows.Forms.Button();
            this.btSendVtextData = new System.Windows.Forms.Button();
            this.btReboot = new System.Windows.Forms.Button();
            this.btActivateGroup = new System.Windows.Forms.Button();
            this.btDeactivateGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSendMsg = new System.Windows.Forms.TextBox();
            this.tbReceiveMsg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbVtextData = new System.Windows.Forms.TextBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btRun = new System.Windows.Forms.Button();
            this.btReadFwVersion = new System.Windows.Forms.Button();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domino IP:";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(36, 30);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(145, 23);
            this.tbIPAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(188, 30);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(77, 23);
            this.tbPort.TabIndex = 4;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(286, 25);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(95, 32);
            this.btConnect.TabIndex = 5;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(387, 25);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(93, 32);
            this.btDisconnect.TabIndex = 6;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(642, 495);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(168, 34);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gvCards
            // 
            this.gvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCards.Location = new System.Drawing.Point(36, 280);
            this.gvCards.Name = "gvCards";
            this.gvCards.Size = new System.Drawing.Size(774, 129);
            this.gvCards.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Message Name:";
            // 
            // tbMessageName
            // 
            this.tbMessageName.Location = new System.Drawing.Point(150, 75);
            this.tbMessageName.Name = "tbMessageName";
            this.tbMessageName.Size = new System.Drawing.Size(218, 23);
            this.tbMessageName.TabIndex = 10;
            this.tbMessageName.Text = "dz";
            // 
            // tbVtextName
            // 
            this.tbVtextName.Location = new System.Drawing.Point(150, 110);
            this.tbVtextName.Name = "tbVtextName";
            this.tbVtextName.Size = new System.Drawing.Size(218, 23);
            this.tbVtextName.TabIndex = 12;
            this.tbVtextName.Text = "vtext1";
            // 
            // btLoadMessage
            // 
            this.btLoadMessage.Location = new System.Drawing.Point(403, 71);
            this.btLoadMessage.Name = "btLoadMessage";
            this.btLoadMessage.Size = new System.Drawing.Size(168, 31);
            this.btLoadMessage.TabIndex = 18;
            this.btLoadMessage.Text = "Load Message";
            this.btLoadMessage.UseVisualStyleBackColor = true;
            this.btLoadMessage.Click += new System.EventHandler(this.btLoadMessage_Click);
            // 
            // btSendVtextData
            // 
            this.btSendVtextData.Location = new System.Drawing.Point(403, 139);
            this.btSendVtextData.Name = "btSendVtextData";
            this.btSendVtextData.Size = new System.Drawing.Size(168, 29);
            this.btSendVtextData.TabIndex = 19;
            this.btSendVtextData.Text = "Send Vtext Data";
            this.btSendVtextData.UseVisualStyleBackColor = true;
            this.btSendVtextData.Click += new System.EventHandler(this.btSendVtextData_Click);
            // 
            // btReboot
            // 
            this.btReboot.Location = new System.Drawing.Point(642, 71);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(168, 31);
            this.btReboot.TabIndex = 20;
            this.btReboot.Text = "Reboot";
            this.btReboot.UseVisualStyleBackColor = true;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // btActivateGroup
            // 
            this.btActivateGroup.Location = new System.Drawing.Point(642, 139);
            this.btActivateGroup.Name = "btActivateGroup";
            this.btActivateGroup.Size = new System.Drawing.Size(168, 30);
            this.btActivateGroup.TabIndex = 21;
            this.btActivateGroup.Text = "Activate Group";
            this.btActivateGroup.UseVisualStyleBackColor = true;
            this.btActivateGroup.Click += new System.EventHandler(this.btActivateGroup_Click);
            // 
            // btDeactivateGroup
            // 
            this.btDeactivateGroup.Location = new System.Drawing.Point(642, 175);
            this.btDeactivateGroup.Name = "btDeactivateGroup";
            this.btDeactivateGroup.Size = new System.Drawing.Size(168, 29);
            this.btDeactivateGroup.TabIndex = 22;
            this.btDeactivateGroup.Text = "Deactivate Group";
            this.btDeactivateGroup.UseVisualStyleBackColor = true;
            this.btDeactivateGroup.Click += new System.EventHandler(this.btDeactivateGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Send Message:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Receive Message:";
            // 
            // tbSendMsg
            // 
            this.tbSendMsg.Location = new System.Drawing.Point(162, 420);
            this.tbSendMsg.Name = "tbSendMsg";
            this.tbSendMsg.Size = new System.Drawing.Size(648, 23);
            this.tbSendMsg.TabIndex = 25;
            // 
            // tbReceiveMsg
            // 
            this.tbReceiveMsg.Location = new System.Drawing.Point(161, 449);
            this.tbReceiveMsg.Name = "tbReceiveMsg";
            this.tbReceiveMsg.Size = new System.Drawing.Size(649, 23);
            this.tbReceiveMsg.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Vtext name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Vtext data:";
            // 
            // tbVtextData
            // 
            this.tbVtextData.Location = new System.Drawing.Point(150, 145);
            this.tbVtextData.Name = "tbVtextData";
            this.tbVtextData.Size = new System.Drawing.Size(218, 23);
            this.tbVtextData.TabIndex = 31;
            this.tbVtextData.Text = "1234567890123456";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(245, 237);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(136, 34);
            this.btLoad.TabIndex = 32;
            this.btLoad.Text = "Browse Data";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(387, 237);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(126, 34);
            this.btRun.TabIndex = 33;
            this.btRun.Text = "Print All";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btReadFwVersion
            // 
            this.btReadFwVersion.Location = new System.Drawing.Point(642, 108);
            this.btReadFwVersion.Name = "btReadFwVersion";
            this.btReadFwVersion.Size = new System.Drawing.Size(168, 25);
            this.btReadFwVersion.TabIndex = 34;
            this.btReadFwVersion.Text = "Firmware Version";
            this.btReadFwVersion.UseVisualStyleBackColor = true;
            this.btReadFwVersion.Click += new System.EventHandler(this.btReadFwVersion_Click);
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(163, 243);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(67, 23);
            this.tbDelay.TabIndex = 35;
            this.tbDelay.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Command Delay:";
            // 
            // DominoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 541);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.btReadFwVersion);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.tbVtextData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbReceiveMsg);
            this.Controls.Add(this.tbSendMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDeactivateGroup);
            this.Controls.Add(this.btActivateGroup);
            this.Controls.Add(this.btReboot);
            this.Controls.Add(this.btSendVtextData);
            this.Controls.Add(this.btLoadMessage);
            this.Controls.Add(this.tbVtextName);
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
            this.Name = "DominoTest";
            this.Text = "DOMINO TEST";
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
        private System.Windows.Forms.TextBox tbVtextName;
        private System.Windows.Forms.Button btLoadMessage;
        private System.Windows.Forms.Button btSendVtextData;
        private System.Windows.Forms.Button btReboot;
        private System.Windows.Forms.Button btActivateGroup;
        private System.Windows.Forms.Button btDeactivateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSendMsg;
        private System.Windows.Forms.TextBox tbReceiveMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbVtextData;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btReadFwVersion;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label6;
    }
}

