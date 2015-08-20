namespace Backuper4000
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePathButton = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationPathTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.destinationPathButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourcePathButton
            // 
            this.sourcePathButton.Location = new System.Drawing.Point(251, 23);
            this.sourcePathButton.Name = "sourcePathButton";
            this.sourcePathButton.Size = new System.Drawing.Size(75, 22);
            this.sourcePathButton.TabIndex = 1;
            this.sourcePathButton.Text = "Обзор";
            this.sourcePathButton.UseVisualStyleBackColor = true;
            this.sourcePathButton.Click += new System.EventHandler(this.sourcePathButton_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Location = new System.Drawing.Point(12, 25);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(233, 20);
            this.sourcePathTextBox.TabIndex = 1;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 9);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(43, 13);
            this.sourceLabel.TabIndex = 2;
            this.sourceLabel.Text = "Откуда";
            // 
            // destinationPathTextBox
            // 
            this.destinationPathTextBox.Location = new System.Drawing.Point(12, 76);
            this.destinationPathTextBox.Name = "destinationPathTextBox";
            this.destinationPathTextBox.Size = new System.Drawing.Size(233, 20);
            this.destinationPathTextBox.TabIndex = 3;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(9, 60);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(31, 13);
            this.destinationLabel.TabIndex = 4;
            this.destinationLabel.Text = "Куда";
            // 
            // destinationPathButton
            // 
            this.destinationPathButton.Location = new System.Drawing.Point(251, 74);
            this.destinationPathButton.Name = "destinationPathButton";
            this.destinationPathButton.Size = new System.Drawing.Size(75, 22);
            this.destinationPathButton.TabIndex = 5;
            this.destinationPathButton.Text = "Обзор";
            this.destinationPathButton.UseVisualStyleBackColor = true;
            this.destinationPathButton.Click += new System.EventHandler(this.destinationPathButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.AcceptsReturn = true;
            this.logTextBox.AcceptsTab = true;
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.CausesValidation = false;
            this.logTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.logTextBox.Enabled = false;
            this.logTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.logTextBox.Location = new System.Drawing.Point(374, 25);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.ShortcutsEnabled = false;
            this.logTextBox.Size = new System.Drawing.Size(217, 212);
            this.logTextBox.TabIndex = 6;
            this.logTextBox.TabStop = false;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(467, 9);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 13);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Логи";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 119);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(127, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Начать копирование";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 249);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.destinationPathButton);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationPathTextBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.sourcePathButton);
            this.MinimumSize = new System.Drawing.Size(619, 288);
            this.Name = "MainWindow";
            this.Text = "Backuper 4000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourcePathButton;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox destinationPathTextBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Button destinationPathButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button startButton;
    }
}

