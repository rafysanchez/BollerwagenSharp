namespace BollerwagenSharp
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aus = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.lbl_switch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aus
            // 
            this.btn_aus.Location = new System.Drawing.Point(150, 93);
            this.btn_aus.Name = "btn_aus";
            this.btn_aus.Size = new System.Drawing.Size(132, 75);
            this.btn_aus.TabIndex = 1;
            this.btn_aus.Text = "aus";
            this.btn_aus.UseVisualStyleBackColor = true;
            this.btn_aus.Click += new System.EventHandler(this.btn_aus_Click);
            // 
            // btn_an
            // 
            this.btn_an.Location = new System.Drawing.Point(150, 12);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(132, 75);
            this.btn_an.TabIndex = 2;
            this.btn_an.Text = "an";
            this.btn_an.UseVisualStyleBackColor = true;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click);
            // 
            // lbl_switch
            // 
            this.lbl_switch.AutoSize = true;
            this.lbl_switch.Location = new System.Drawing.Point(49, 51);
            this.lbl_switch.Name = "lbl_switch";
            this.lbl_switch.Size = new System.Drawing.Size(0, 13);
            this.lbl_switch.TabIndex = 3;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 405);
            this.Controls.Add(this.lbl_switch);
            this.Controls.Add(this.btn_an);
            this.Controls.Add(this.btn_aus);
            this.Name = "GUI";
            this.Text = "BollerwagenSharp";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aus;
        private System.Windows.Forms.Button btn_an;
        private System.Windows.Forms.Label lbl_switch;

    }
}

