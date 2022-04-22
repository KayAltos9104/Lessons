
namespace Lesson15
{
    partial class FrmMain
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnAsyncDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(123, 49);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Аноним";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnAsyncDemo
            // 
            this.BtnAsyncDemo.Location = new System.Drawing.Point(12, 67);
            this.BtnAsyncDemo.Name = "BtnAsyncDemo";
            this.BtnAsyncDemo.Size = new System.Drawing.Size(123, 69);
            this.BtnAsyncDemo.TabIndex = 1;
            this.BtnAsyncDemo.Text = "Асинхронь";
            this.BtnAsyncDemo.UseVisualStyleBackColor = true;
            this.BtnAsyncDemo.Click += new System.EventHandler(this.BtnAsyncDemo_ClickAsync);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 536);
            this.Controls.Add(this.BtnAsyncDemo);
            this.Controls.Add(this.BtnStart);
            this.Name = "FrmMain";
            this.Text = "Лямбда и анонимные";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnAsyncDemo;
    }
}

