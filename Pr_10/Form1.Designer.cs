namespace GrabGraphicObjects
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_Vid = new System.Windows.Forms.Label();
            this.label_Shape = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(770, 514);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // label_Vid
            // 
            this.label_Vid.BackColor = System.Drawing.Color.LightGray;
            this.label_Vid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Vid.Location = new System.Drawing.Point(37, 389);
            this.label_Vid.Name = "label_Vid";
            this.label_Vid.Size = new System.Drawing.Size(157, 115);
            this.label_Vid.TabIndex = 1;
            this.label_Vid.Text = "Вид";
            this.label_Vid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Shape
            // 
            this.label_Shape.BackColor = System.Drawing.Color.LightGray;
            this.label_Shape.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Shape.Location = new System.Drawing.Point(321, 389);
            this.label_Shape.Name = "label_Shape";
            this.label_Shape.Size = new System.Drawing.Size(157, 115);
            this.label_Shape.TabIndex = 1;
            this.label_Shape.Text = "Форма";
            this.label_Shape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Info
            // 
            this.label_Info.BackColor = System.Drawing.Color.LightGray;
            this.label_Info.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Info.Location = new System.Drawing.Point(600, 389);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(157, 115);
            this.label_Info.TabIndex = 1;
            this.label_Info.Text = "Информация";
            this.label_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 538);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_Shape);
            this.Controls.Add(this.label_Vid);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label_Vid;
        private System.Windows.Forms.Label label_Shape;
        private System.Windows.Forms.Label label_Info;
    }
}

