
namespace WindowsCars2
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
            this.allcars = new System.Windows.Forms.ListBox();
            this.carattributes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allcars
            // 
            this.allcars.FormattingEnabled = true;
            this.allcars.Location = new System.Drawing.Point(25, 35);
            this.allcars.Name = "allcars";
            this.allcars.Size = new System.Drawing.Size(157, 303);
            this.allcars.TabIndex = 0;
            this.allcars.SelectedIndexChanged += new System.EventHandler(this.allcars_SelectedIndexChanged);
            // 
            // carattributes
            // 
            this.carattributes.FormattingEnabled = true;
            this.carattributes.Location = new System.Drawing.Point(226, 38);
            this.carattributes.Name = "carattributes";
            this.carattributes.Size = new System.Drawing.Size(257, 186);
            this.carattributes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 571);
            this.Controls.Add(this.carattributes);
            this.Controls.Add(this.allcars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox allcars;
        private System.Windows.Forms.ListBox carattributes;
    }
}

