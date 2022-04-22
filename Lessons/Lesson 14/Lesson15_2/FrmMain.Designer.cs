namespace Lesson15_2
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnInit = new System.Windows.Forms.Button();
            this.PbxField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxField)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInit
            // 
            this.BtnInit.Location = new System.Drawing.Point(12, 12);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(145, 61);
            this.BtnInit.TabIndex = 0;
            this.BtnInit.Text = "Старт";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // PbxField
            // 
            this.PbxField.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PbxField.Location = new System.Drawing.Point(163, 12);
            this.PbxField.Name = "PbxField";
            this.PbxField.Size = new System.Drawing.Size(607, 502);
            this.PbxField.TabIndex = 1;
            this.PbxField.TabStop = false;
            this.PbxField.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintMap);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 526);
            this.Controls.Add(this.PbxField);
            this.Controls.Add(this.BtnInit);
            this.Name = "FrmMain";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.PbxField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.PictureBox PbxField;
    }
}

