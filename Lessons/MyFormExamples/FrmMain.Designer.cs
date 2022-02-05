
namespace MyFormExamples
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
            this.TbxInputAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxInputModule = new System.Windows.Forms.TextBox();
            this.TbxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PbxThrowing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxThrowing)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnStart.Location = new System.Drawing.Point(217, 192);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(178, 62);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Нажми меня!";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TbxInputAngle
            // 
            this.TbxInputAngle.Location = new System.Drawing.Point(217, 4);
            this.TbxInputAngle.Name = "TbxInputAngle";
            this.TbxInputAngle.Size = new System.Drawing.Size(178, 34);
            this.TbxInputAngle.TabIndex = 1;
            this.TbxInputAngle.Text = "0";
            this.TbxInputAngle.TextChanged += new System.EventHandler(this.TbxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Стартовая кнопка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модуль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(35, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Угол";
            // 
            // TbxInputModule
            // 
            this.TbxInputModule.Location = new System.Drawing.Point(217, 51);
            this.TbxInputModule.Name = "TbxInputModule";
            this.TbxInputModule.Size = new System.Drawing.Size(178, 34);
            this.TbxInputModule.TabIndex = 5;
            this.TbxInputModule.Text = "0";
            this.TbxInputModule.TextChanged += new System.EventHandler(this.TbxInput_TextChanged);
            // 
            // TbxResult
            // 
            this.TbxResult.Location = new System.Drawing.Point(217, 103);
            this.TbxResult.Name = "TbxResult";
            this.TbxResult.Size = new System.Drawing.Size(178, 34);
            this.TbxResult.TabIndex = 7;
            this.TbxResult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вывод";
            // 
            // PbxThrowing
            // 
            this.PbxThrowing.Location = new System.Drawing.Point(401, 4);
            this.PbxThrowing.Name = "PbxThrowing";
            this.PbxThrowing.Size = new System.Drawing.Size(540, 471);
            this.PbxThrowing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxThrowing.TabIndex = 8;
            this.PbxThrowing.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(953, 487);
            this.Controls.Add(this.PbxThrowing);
            this.Controls.Add(this.TbxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxInputModule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxInputAngle);
            this.Controls.Add(this.BtnStart);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.PbxThrowing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox TbxInputAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxInputModule;
        private System.Windows.Forms.TextBox TbxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbxThrowing;
    }
}

