namespace PictureViewer1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stretchCkBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showPictureButton = new System.Windows.Forms.Button();
            this.clearPictureButton = new System.Windows.Forms.Button();
            this.setBgColorButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.21053F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stretchCkBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // stretchCkBox
            // 
            this.stretchCkBox.AutoSize = true;
            this.stretchCkBox.Location = new System.Drawing.Point(3, 408);
            this.stretchCkBox.Name = "stretchCkBox";
            this.stretchCkBox.Size = new System.Drawing.Size(70, 20);
            this.stretchCkBox.TabIndex = 1;
            this.stretchCkBox.Text = "Stretch";
            this.stretchCkBox.UseVisualStyleBackColor = true;
            this.stretchCkBox.CheckedChanged += new System.EventHandler(this.stretchCkBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showPictureButton);
            this.flowLayoutPanel1.Controls.Add(this.clearPictureButton);
            this.flowLayoutPanel1.Controls.Add(this.setBgColorButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(129, 408);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(668, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showPictureButton
            // 
            this.showPictureButton.Location = new System.Drawing.Point(3, 3);
            this.showPictureButton.Name = "showPictureButton";
            this.showPictureButton.Size = new System.Drawing.Size(156, 23);
            this.showPictureButton.TabIndex = 0;
            this.showPictureButton.Text = "Показать рисунок";
            this.showPictureButton.UseVisualStyleBackColor = true;
            this.showPictureButton.Click += new System.EventHandler(this.showPictureButton_Click);
            // 
            // clearPictureButton
            // 
            this.clearPictureButton.Location = new System.Drawing.Point(165, 3);
            this.clearPictureButton.Name = "clearPictureButton";
            this.clearPictureButton.Size = new System.Drawing.Size(156, 23);
            this.clearPictureButton.TabIndex = 1;
            this.clearPictureButton.Text = "Очистить рисунок";
            this.clearPictureButton.UseVisualStyleBackColor = true;
            this.clearPictureButton.Click += new System.EventHandler(this.erasePictureButton_Click);
            // 
            // setBgColorButton
            // 
            this.setBgColorButton.Location = new System.Drawing.Point(327, 3);
            this.setBgColorButton.Name = "setBgColorButton";
            this.setBgColorButton.Size = new System.Drawing.Size(156, 23);
            this.setBgColorButton.TabIndex = 2;
            this.setBgColorButton.Text = "Установить цвет фона";
            this.setBgColorButton.UseVisualStyleBackColor = true;
            this.setBgColorButton.Click += new System.EventHandler(this.setBgColorButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(489, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Выбор файла изображения";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Средство просмотра изображений";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox stretchCkBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showPictureButton;
        private System.Windows.Forms.Button clearPictureButton;
        private System.Windows.Forms.Button setBgColorButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

