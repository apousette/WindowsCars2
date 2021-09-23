
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
            this.menu = new System.Windows.Forms.ComboBox();
            this.CarsOfColor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // allcars
            // 
            this.allcars.FormattingEnabled = true;
            this.allcars.ItemHeight = 16;
            this.allcars.Location = new System.Drawing.Point(33, 43);
            this.allcars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allcars.Name = "allcars";
            this.allcars.Size = new System.Drawing.Size(208, 372);
            this.allcars.TabIndex = 0;
            this.allcars.SelectedIndexChanged += new System.EventHandler(this.allcars_SelectedIndexChanged);
            // 
            // carattributes
            // 
            this.carattributes.FormattingEnabled = true;
            this.carattributes.ItemHeight = 16;
            this.carattributes.Location = new System.Drawing.Point(301, 47);
            this.carattributes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carattributes.Name = "carattributes";
            this.carattributes.Size = new System.Drawing.Size(341, 228);
            this.carattributes.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(879, 52);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(196, 24);
            this.menu.TabIndex = 2;
            this.menu.SelectedIndexChanged += new System.EventHandler(this.menu_SelectedIndexChanged);
            // 
            // CarsOfColor
            // 
            this.CarsOfColor.FormattingEnabled = true;
            this.CarsOfColor.ItemHeight = 16;
            this.CarsOfColor.Location = new System.Drawing.Point(877, 105);
            this.CarsOfColor.Name = "CarsOfColor";
            this.CarsOfColor.Size = new System.Drawing.Size(197, 164);
            this.CarsOfColor.TabIndex = 3;
            this.CarsOfColor.SelectedIndexChanged += new System.EventHandler(this.CarsOfColor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.CarsOfColor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.carattributes);
            this.Controls.Add(this.allcars);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox allcars;
        private System.Windows.Forms.ListBox carattributes;
        private System.Windows.Forms.ComboBox menu;
        private System.Windows.Forms.ListBox CarsOfColor;
    }
}

