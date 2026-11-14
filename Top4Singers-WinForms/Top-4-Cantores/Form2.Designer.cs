namespace Top_4_Cantores
{
    partial class Frm_CentralCee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CentralCee));
            this.Btn_CentralCee = new System.Windows.Forms.Button();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Btn_Like = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CentralCee
            // 
            this.Btn_CentralCee.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_CentralCee.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CentralCee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_CentralCee.Location = new System.Drawing.Point(4, 500);
            this.Btn_CentralCee.Name = "Btn_CentralCee";
            this.Btn_CentralCee.Size = new System.Drawing.Size(258, 53);
            this.Btn_CentralCee.TabIndex = 1;
            this.Btn_CentralCee.Text = "Voltar";
            this.Btn_CentralCee.UseVisualStyleBackColor = false;
            this.Btn_CentralCee.Click += new System.EventHandler(this.Btn_CentralCee_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(334, 500);
            this.Txt_Nome.Multiline = true;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(450, 57);
            this.Txt_Nome.TabIndex = 5;
            this.Txt_Nome.TextChanged += new System.EventHandler(this.Txt_Nome_TextChanged_1);
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            this.Txt_Nome.Resize += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Btn_Like
            // 
            this.Btn_Like.BackgroundImage = global::Top_4_Cantores.Properties.Resources.Heart;
            this.Btn_Like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Like.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Like.Location = new System.Drawing.Point(258, 500);
            this.Btn_Like.Name = "Btn_Like";
            this.Btn_Like.Size = new System.Drawing.Size(80, 57);
            this.Btn_Like.TabIndex = 3;
            this.Btn_Like.UseVisualStyleBackColor = true;
            this.Btn_Like.Click += new System.EventHandler(this.Btn_Like_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(783, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comentar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Red;
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(783, 526);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(262, 27);
            this.Btn_Limpar.TabIndex = 7;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(4, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1041, 504);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Frm_CentralCee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 555);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Btn_Like);
            this.Controls.Add(this.Btn_CentralCee);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CentralCee";
            this.Text = "Central Cee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_CentralCee_FormClosed);
            this.Load += new System.EventHandler(this.Frm_CentralCee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_CentralCee;
        private System.Windows.Forms.Button Btn_Like;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Limpar;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}