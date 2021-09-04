
namespace superGym
{
    partial class F_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nameUser = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_acess = new System.Windows.Forms.Label();
            this.lbl_typeAcess = new System.Windows.Forms.Label();
            this.pb_ledLoggedIn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLoggedIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_nameUser);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_acess);
            this.panel1.Controls.Add(this.lbl_typeAcess);
            this.panel1.Controls.Add(this.pb_ledLoggedIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 0;
            // 
            // lbl_nameUser
            // 
            this.lbl_nameUser.AutoSize = true;
            this.lbl_nameUser.Location = new System.Drawing.Point(165, 11);
            this.lbl_nameUser.Name = "lbl_nameUser";
            this.lbl_nameUser.Size = new System.Drawing.Size(22, 15);
            this.lbl_nameUser.TabIndex = 4;
            this.lbl_nameUser.Text = "---";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(108, 11);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(50, 15);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Usuário:";
            // 
            // lbl_acess
            // 
            this.lbl_acess.AutoSize = true;
            this.lbl_acess.Location = new System.Drawing.Point(89, 11);
            this.lbl_acess.Name = "lbl_acess";
            this.lbl_acess.Size = new System.Drawing.Size(13, 15);
            this.lbl_acess.TabIndex = 2;
            this.lbl_acess.Text = "0";
            // 
            // lbl_typeAcess
            // 
            this.lbl_typeAcess.AutoSize = true;
            this.lbl_typeAcess.Location = new System.Drawing.Point(39, 11);
            this.lbl_typeAcess.Name = "lbl_typeAcess";
            this.lbl_typeAcess.Size = new System.Drawing.Size(47, 15);
            this.lbl_typeAcess.TabIndex = 1;
            this.lbl_typeAcess.Text = "Acesso:";
            // 
            // pb_ledLoggedIn
            // 
            this.pb_ledLoggedIn.Image = global::superGym.Properties.Resources.led_red;
            this.pb_ledLoggedIn.Location = new System.Drawing.Point(3, 3);
            this.pb_ledLoggedIn.Name = "pb_ledLoggedIn";
            this.pb_ledLoggedIn.Size = new System.Drawing.Size(30, 30);
            this.pb_ledLoggedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLoggedIn.TabIndex = 0;
            this.pb_ledLoggedIn.TabStop = false;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGym - Home - v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLoggedIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nameUser;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_acess;
        private System.Windows.Forms.Label lbl_typeAcess;
        public System.Windows.Forms.PictureBox pb_ledLoggedIn;
    }
}

