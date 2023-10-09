namespace bölüm2
{
    partial class Form1
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
            this.btnTıkla = new System.Windows.Forms.Button();
            this.cbKirmizi = new System.Windows.Forms.CheckBox();
            this.lblYaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTıkla.Location = new System.Drawing.Point(52, 143);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(102, 58);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "tıkla";
            this.btnTıkla.UseVisualStyleBackColor = true;
            // 
            // cbKirmizi
            // 
            this.cbKirmizi.AutoSize = true;
            this.cbKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKirmizi.Location = new System.Drawing.Point(63, 97);
            this.cbKirmizi.Name = "cbKirmizi";
            this.cbKirmizi.Size = new System.Drawing.Size(81, 28);
            this.cbKirmizi.TabIndex = 1;
            this.cbKirmizi.Text = "kirmizi";
            this.cbKirmizi.UseVisualStyleBackColor = true;
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.Location = new System.Drawing.Point(75, 45);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(41, 24);
            this.lblYaz.TabIndex = 2;
            this.lblYaz.Text = "Yaz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 213);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.cbKirmizi);
            this.Controls.Add(this.btnTıkla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.CheckBox cbKirmizi;
        private System.Windows.Forms.Label lblYaz;
    }
}

