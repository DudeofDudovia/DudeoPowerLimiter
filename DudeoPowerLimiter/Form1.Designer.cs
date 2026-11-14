namespace DudeoPowerLimiter
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
            Unlimit = new Button();
            ApplyLimit = new Button();
            set99 = new Button();
            SuspendLayout();
            // 
            // Unlimit
            // 
            Unlimit.Location = new Point(322, 210);
            Unlimit.Name = "Unlimit";
            Unlimit.Size = new Size(151, 29);
            Unlimit.TabIndex = 0;
            Unlimit.Text = "Unlimit CPU";
            Unlimit.UseVisualStyleBackColor = true;
            // 
            // ApplyLimit
            // 
            ApplyLimit.Location = new Point(322, 175);
            ApplyLimit.Name = "ApplyLimit";
            ApplyLimit.Size = new Size(151, 29);
            ApplyLimit.TabIndex = 1;
            ApplyLimit.Text = "Apply Limit";
            ApplyLimit.UseVisualStyleBackColor = true;
            // 
            // set99
            // 
            set99.Location = new Point(322, 140);
            set99.Name = "set99";
            set99.Size = new Size(151, 29);
            set99.TabIndex = 2;
            set99.Text = "Disable Turbo (99&)";
            set99.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 251);
            Controls.Add(set99);
            Controls.Add(ApplyLimit);
            Controls.Add(Unlimit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Unlimit;
        private Button ApplyLimit;
        private Button set99;
    }
}