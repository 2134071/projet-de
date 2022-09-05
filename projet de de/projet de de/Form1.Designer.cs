namespace projet_de_de
{
    partial class Form1
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
            this.btn_brasser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_brasser
            // 
            this.btn_brasser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_brasser.Location = new System.Drawing.Point(233, 143);
            this.btn_brasser.Name = "btn_brasser";
            this.btn_brasser.Size = new System.Drawing.Size(190, 140);
            this.btn_brasser.TabIndex = 0;
            this.btn_brasser.Text = "brasser";
            this.btn_brasser.UseVisualStyleBackColor = true;
            this.btn_brasser.Click += new System.EventHandler(this.btn_brasser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_brasser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_brasser;
    }
}