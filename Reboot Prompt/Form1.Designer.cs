
namespace Reboot_Prompt
{
    partial class RebootPrompt
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
            this.RebootBtn = new System.Windows.Forms.Button();
            this.LaterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your computer needs to reboot. Please save your work now.";
            // 
            // RebootBtn
            // 
            this.RebootBtn.Location = new System.Drawing.Point(12, 83);
            this.RebootBtn.Name = "RebootBtn";
            this.RebootBtn.Size = new System.Drawing.Size(100, 25);
            this.RebootBtn.TabIndex = 1;
            this.RebootBtn.Text = "Reboot Now";
            this.RebootBtn.UseVisualStyleBackColor = true;
            this.RebootBtn.Click += new System.EventHandler(this.RebootBtn_Click);
            // 
            // LaterBtn
            // 
            this.LaterBtn.Location = new System.Drawing.Point(188, 83);
            this.LaterBtn.Name = "LaterBtn";
            this.LaterBtn.Size = new System.Drawing.Size(100, 25);
            this.LaterBtn.TabIndex = 2;
            this.LaterBtn.Text = "Reboot Later";
            this.LaterBtn.UseVisualStyleBackColor = true;
            this.LaterBtn.Click += new System.EventHandler(this.LaterBtn_Click);
            // 
            // RebootPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.ControlBox = false;
            this.Controls.Add(this.LaterBtn);
            this.Controls.Add(this.RebootBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RebootPrompt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reboot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RebootBtn;
        private System.Windows.Forms.Button LaterBtn;
    }
}

