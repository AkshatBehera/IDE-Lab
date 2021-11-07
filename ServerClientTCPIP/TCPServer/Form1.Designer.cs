
namespace TCPServer
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTbx = new System.Windows.Forms.TextBox();
            this.displayTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(548, 358);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(139, 34);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "Send Message";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTbx
            // 
            this.inputTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTbx.Location = new System.Drawing.Point(68, 358);
            this.inputTbx.Name = "inputTbx";
            this.inputTbx.Size = new System.Drawing.Size(438, 29);
            this.inputTbx.TabIndex = 2;
            // 
            // displayTbx
            // 
            this.displayTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTbx.Location = new System.Drawing.Point(68, 65);
            this.displayTbx.Multiline = true;
            this.displayTbx.Name = "displayTbx";
            this.displayTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTbx.Size = new System.Drawing.Size(619, 270);
            this.displayTbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTbx);
            this.Controls.Add(this.inputTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTbx;
        private System.Windows.Forms.TextBox displayTbx;
    }
}

