namespace srcds_rcon_app
{
    partial class connectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectWindow));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblAddrBoxDisc = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxAddr = new System.Windows.Forms.TextBox();
            this.lblPassBoxDisc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(212, 48);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(212, 77);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblAddrBoxDisc
            // 
            this.lblAddrBoxDisc.AutoSize = true;
            this.lblAddrBoxDisc.Location = new System.Drawing.Point(9, 14);
            this.lblAddrBoxDisc.Name = "lblAddrBoxDisc";
            this.lblAddrBoxDisc.Size = new System.Drawing.Size(82, 13);
            this.lblAddrBoxDisc.TabIndex = 2;
            this.lblAddrBoxDisc.Text = "Server Address:";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(12, 69);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(113, 20);
            this.txtBoxPass.TabIndex = 3;
            this.txtBoxPass.UseSystemPasswordChar = true;
            // 
            // txtBoxAddr
            // 
            this.txtBoxAddr.Location = new System.Drawing.Point(12, 30);
            this.txtBoxAddr.Name = "txtBoxAddr";
            this.txtBoxAddr.Size = new System.Drawing.Size(113, 20);
            this.txtBoxAddr.TabIndex = 4;
            // 
            // lblPassBoxDisc
            // 
            this.lblPassBoxDisc.AutoSize = true;
            this.lblPassBoxDisc.Location = new System.Drawing.Point(9, 53);
            this.lblPassBoxDisc.Name = "lblPassBoxDisc";
            this.lblPassBoxDisc.Size = new System.Drawing.Size(90, 13);
            this.lblPassBoxDisc.TabIndex = 5;
            this.lblPassBoxDisc.Text = "RCON Password:";
            // 
            // connectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 112);
            this.Controls.Add(this.lblPassBoxDisc);
            this.Controls.Add(this.txtBoxAddr);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblAddrBoxDisc);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "connectWindow";
            this.Text = "Login - SRCDS RCON Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblAddrBoxDisc;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxAddr;
        private System.Windows.Forms.Label lblPassBoxDisc;
    }
}

