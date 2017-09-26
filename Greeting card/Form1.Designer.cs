namespace Greeting_card
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
            this.cardButton = new System.Windows.Forms.Button();
            this.sureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardButton
            // 
            this.cardButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cardButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardButton.ForeColor = System.Drawing.Color.Cyan;
            this.cardButton.Location = new System.Drawing.Point(117, 121);
            this.cardButton.Name = "cardButton";
            this.cardButton.Size = new System.Drawing.Size(88, 44);
            this.cardButton.TabIndex = 0;
            this.cardButton.Text = "Go";
            this.cardButton.UseVisualStyleBackColor = false;
            this.cardButton.Click += new System.EventHandler(this.cardButton_Click);
            // 
            // sureButton
            // 
            this.sureButton.Font = new System.Drawing.Font("Papyrus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureButton.Location = new System.Drawing.Point(100, 62);
            this.sureButton.Name = "sureButton";
            this.sureButton.Size = new System.Drawing.Size(128, 149);
            this.sureButton.TabIndex = 1;
            this.sureButton.Text = "Are You Sure?";
            this.sureButton.UseVisualStyleBackColor = true;
            this.sureButton.Click += new System.EventHandler(this.Sure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(321, 301);
            this.Controls.Add(this.sureButton);
            this.Controls.Add(this.cardButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cardButton;
        private System.Windows.Forms.Button sureButton;
    }
}

