
namespace LeeftijdControle
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
            this.chbKeuze = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblGeboorteDag = new System.Windows.Forms.Label();
            this.dtpGeboorteDag = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // chbKeuze
            // 
            this.chbKeuze.AutoSize = true;
            this.chbKeuze.Location = new System.Drawing.Point(43, 63);
            this.chbKeuze.Name = "chbKeuze";
            this.chbKeuze.Size = new System.Drawing.Size(78, 21);
            this.chbKeuze.TabIndex = 0;
            this.chbKeuze.Text = "pasport";
            this.chbKeuze.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(686, 399);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "controle ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblGeboorteDag
            // 
            this.lblGeboorteDag.AutoSize = true;
            this.lblGeboorteDag.Location = new System.Drawing.Point(339, 63);
            this.lblGeboorteDag.Name = "lblGeboorteDag";
            this.lblGeboorteDag.Size = new System.Drawing.Size(166, 17);
            this.lblGeboorteDag.TabIndex = 2;
            this.lblGeboorteDag.Text = "Wat is uw GeboorteDag?";
            // 
            // dtpGeboorteDag
            // 
            this.dtpGeboorteDag.Location = new System.Drawing.Point(542, 63);
            this.dtpGeboorteDag.Name = "dtpGeboorteDag";
            this.dtpGeboorteDag.Size = new System.Drawing.Size(246, 22);
            this.dtpGeboorteDag.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpGeboorteDag);
            this.Controls.Add(this.lblGeboorteDag);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.chbKeuze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbKeuze;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblGeboorteDag;
        private System.Windows.Forms.DateTimePicker dtpGeboorteDag;
    }
}

