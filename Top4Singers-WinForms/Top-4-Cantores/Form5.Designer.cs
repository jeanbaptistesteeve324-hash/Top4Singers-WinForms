namespace Top_4_Cantores
{
    partial class Frm_CardiB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CardiB));
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Avaliar = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Btn_Like = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Avaliar
            // 
            this.Btn_Avaliar.BackColor = System.Drawing.Color.Green;
            this.Btn_Avaliar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Avaliar.Location = new System.Drawing.Point(783, 558);
            this.Btn_Avaliar.Name = "Btn_Avaliar";
            this.Btn_Avaliar.Size = new System.Drawing.Size(280, 31);
            this.Btn_Avaliar.TabIndex = 2;
            this.Btn_Avaliar.Text = "Comentar";
            this.Btn_Avaliar.UseVisualStyleBackColor = false;
            this.Btn_Avaliar.Click += new System.EventHandler(this.Btn_Avaliar_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, -1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1064, 563);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Btn_Like
            // 
            this.Btn_Like.BackgroundImage = global::Top_4_Cantores.Properties.Resources.Heart;
            this.Btn_Like.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Like.Location = new System.Drawing.Point(253, 558);
            this.Btn_Like.Name = "Btn_Like";
            this.Btn_Like.Size = new System.Drawing.Size(80, 55);
            this.Btn_Like.TabIndex = 3;
            this.Btn_Like.UseVisualStyleBackColor = true;
            this.Btn_Like.Click += new System.EventHandler(this.Btn_Like_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Red;
            this.Btn_Limpar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.Location = new System.Drawing.Point(783, 585);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(280, 30);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.Location = new System.Drawing.Point(328, 558);
            this.Txt_Nome.Multiline = true;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(459, 55);
            this.Txt_Nome.TabIndex = 6;
            this.Txt_Nome.TextChanged += new System.EventHandler(this.Txt_Nome_TextChanged);
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Frm_CardiB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 613);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Like);
            this.Controls.Add(this.Btn_Avaliar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CardiB";
            this.Text = "Cardi B";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_CardiB_FormClosed);
            this.Load += new System.EventHandler(this.Frm_CardiB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Avaliar;
        private System.Windows.Forms.Button Btn_Like;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.TextBox Txt_Nome;
    }
}