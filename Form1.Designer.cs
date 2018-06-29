namespace tx_formfield_editor
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
            this.textControl1 = new TXTextControl.TextControl();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formCheckBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formDropDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(25, 77);
            this.textControl1.Name = "textControl1";
            this.textControl1.PageMargins.Bottom = 79.03D;
            this.textControl1.PageMargins.Left = 79.03D;
            this.textControl1.PageMargins.Right = 79.03D;
            this.textControl1.PageMargins.Top = 79.03D;
            this.textControl1.Size = new System.Drawing.Size(983, 662);
            this.textControl1.TabIndex = 0;
            this.textControl1.UserNames = null;
            this.textControl1.TextFieldClicked += new TXTextControl.TextFieldEventHandler(this.textControl1_TextFieldClicked);
            // 
            // buttonBar1
            // 
            this.buttonBar1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 24);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(1008, 28);
            this.buttonBar1.TabIndex = 1;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 739);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(1008, 22);
            this.statusBar1.TabIndex = 2;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar1.Location = new System.Drawing.Point(0, 77);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(25, 662);
            this.rulerBar1.TabIndex = 3;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar2.Location = new System.Drawing.Point(0, 52);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(1008, 25);
            this.rulerBar2.TabIndex = 4;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formFieldsToolStripMenuItem
            // 
            this.formFieldsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formTextToolStripMenuItem,
            this.formCheckBoxToolStripMenuItem,
            this.formDropDownToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.formFieldsToolStripMenuItem.Name = "formFieldsToolStripMenuItem";
            this.formFieldsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.formFieldsToolStripMenuItem.Text = "Add FormField";
            // 
            // formTextToolStripMenuItem
            // 
            this.formTextToolStripMenuItem.Name = "formTextToolStripMenuItem";
            this.formTextToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.formTextToolStripMenuItem.Text = "FormText";
            this.formTextToolStripMenuItem.Click += new System.EventHandler(this.formTextToolStripMenuItem_Click);
            // 
            // formCheckBoxToolStripMenuItem
            // 
            this.formCheckBoxToolStripMenuItem.Name = "formCheckBoxToolStripMenuItem";
            this.formCheckBoxToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.formCheckBoxToolStripMenuItem.Text = "FormCheckBox";
            this.formCheckBoxToolStripMenuItem.Click += new System.EventHandler(this.formCheckBoxToolStripMenuItem_Click);
            // 
            // formDropDownToolStripMenuItem
            // 
            this.formDropDownToolStripMenuItem.Name = "formDropDownToolStripMenuItem";
            this.formDropDownToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.formDropDownToolStripMenuItem.Text = "FormDropDown";
            this.formDropDownToolStripMenuItem.Click += new System.EventHandler(this.formDropDownToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 761);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TX Text Control FormField Sample";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.RulerBar rulerBar2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formCheckBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formDropDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
    }
}

