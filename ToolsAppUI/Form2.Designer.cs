namespace ToolsAppUI
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            button2 = new Button();
            button1 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Fredoka", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 53);
            button2.Name = "button2";
            button2.Size = new Size(143, 35);
            button2.TabIndex = 3;
            button2.Text = "App Installer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Fredoka", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 2;
            button1.Text = "Wallpapers";
            button1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(177, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 278);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
    }
}