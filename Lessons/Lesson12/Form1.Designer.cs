
namespace Lesson12
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
            this.PbxVis = new System.Windows.Forms.PictureBox();
            this.BtnInit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxVis)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 69);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(105, 46);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Запуск!";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PbxVis
            // 
            this.PbxVis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PbxVis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxVis.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PbxVis.Location = new System.Drawing.Point(150, 12);
            this.PbxVis.Name = "PbxVis";
            this.PbxVis.Size = new System.Drawing.Size(709, 536);
            this.PbxVis.TabIndex = 1;
            this.PbxVis.TabStop = false;
            this.PbxVis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CursorClick);
            this.PbxVis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CursorMove);
            // 
            // BtnInit
            // 
            this.BtnInit.Location = new System.Drawing.Point(12, 12);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(105, 51);
            this.BtnInit.TabIndex = 2;
            this.BtnInit.Text = "Генерация поля";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 244);
            this.listBox1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 560);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.PbxVis);
            this.Controls.Add(this.BtnStart);
            this.Name = "FrmMain";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.PbxVis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox PbxVis;
        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

