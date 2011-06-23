namespace morrisonm48.EasyKin
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxXY = new System.Windows.Forms.ComboBox();
            this.tbxCoordinate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxBodyPart = new System.Windows.Forms.ComboBox();
            this.cbxPartModifier = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxButtonAction = new System.Windows.Forms.ComboBox();
            this.cbxPeriphButton = new System.Windows.Forms.ComboBox();
            this.cbxPeriph = new System.Windows.Forms.ComboBox();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbGeneratedCode = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveCode = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSealCode = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readmeToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // readmeToolStripMenuItem
            // 
            this.readmeToolStripMenuItem.Name = "readmeToolStripMenuItem";
            this.readmeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.readmeToolStripMenuItem.Text = "Readme";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxXY);
            this.groupBox1.Controls.Add(this.tbxCoordinate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxBodyPart);
            this.groupBox1.Controls.Add(this.cbxPartModifier);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "When you move your:";
            // 
            // cbxXY
            // 
            this.cbxXY.FormattingEnabled = true;
            this.cbxXY.Location = new System.Drawing.Point(6, 64);
            this.cbxXY.Name = "cbxXY";
            this.cbxXY.Size = new System.Drawing.Size(140, 21);
            this.cbxXY.TabIndex = 6;
            this.cbxXY.SelectedIndexChanged += new System.EventHandler(this.cbxXY_SelectedIndexChanged);
            // 
            // tbxCoordinate
            // 
            this.tbxCoordinate.Location = new System.Drawing.Point(152, 64);
            this.tbxCoordinate.Name = "tbxCoordinate";
            this.tbxCoordinate.Size = new System.Drawing.Size(140, 20);
            this.tbxCoordinate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Past this coordinate:";
            // 
            // cbxBodyPart
            // 
            this.cbxBodyPart.FormattingEnabled = true;
            this.cbxBodyPart.Location = new System.Drawing.Point(153, 20);
            this.cbxBodyPart.Name = "cbxBodyPart";
            this.cbxBodyPart.Size = new System.Drawing.Size(140, 21);
            this.cbxBodyPart.TabIndex = 1;
            this.cbxBodyPart.SelectionChangeCommitted += new System.EventHandler(this.cbxBodyPart_SelectionChangeCommitted);
            // 
            // cbxPartModifier
            // 
            this.cbxPartModifier.FormattingEnabled = true;
            this.cbxPartModifier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxPartModifier.Location = new System.Drawing.Point(7, 20);
            this.cbxPartModifier.Name = "cbxPartModifier";
            this.cbxPartModifier.Size = new System.Drawing.Size(140, 21);
            this.cbxPartModifier.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxButtonAction);
            this.groupBox2.Controls.Add(this.cbxPeriphButton);
            this.groupBox2.Controls.Add(this.cbxPeriph);
            this.groupBox2.Location = new System.Drawing.Point(378, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "The computer should think you did this:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To this button:";
            // 
            // cbxButtonAction
            // 
            this.cbxButtonAction.FormattingEnabled = true;
            this.cbxButtonAction.Location = new System.Drawing.Point(6, 20);
            this.cbxButtonAction.Name = "cbxButtonAction";
            this.cbxButtonAction.Size = new System.Drawing.Size(140, 21);
            this.cbxButtonAction.TabIndex = 2;
            // 
            // cbxPeriphButton
            // 
            this.cbxPeriphButton.DropDownHeight = 80;
            this.cbxPeriphButton.FormattingEnabled = true;
            this.cbxPeriphButton.IntegralHeight = false;
            this.cbxPeriphButton.Location = new System.Drawing.Point(152, 64);
            this.cbxPeriphButton.Name = "cbxPeriphButton";
            this.cbxPeriphButton.Size = new System.Drawing.Size(140, 21);
            this.cbxPeriphButton.TabIndex = 1;
            // 
            // cbxPeriph
            // 
            this.cbxPeriph.FormattingEnabled = true;
            this.cbxPeriph.Location = new System.Drawing.Point(6, 64);
            this.cbxPeriph.Name = "cbxPeriph";
            this.cbxPeriph.Size = new System.Drawing.Size(140, 21);
            this.cbxPeriph.TabIndex = 0;
            this.cbxPeriph.SelectedIndexChanged += new System.EventHandler(this.cbxPeriph_SelectedIndexChanged);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(20, 133);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(658, 23);
            this.btnGenerateCode.TabIndex = 3;
            this.btnGenerateCode.Text = "Automagic Code Generation Button!";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbGeneratedCode);
            this.groupBox3.Location = new System.Drawing.Point(13, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 300);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generated Code ( In C# )";
            // 
            // rtbGeneratedCode
            // 
            this.rtbGeneratedCode.Location = new System.Drawing.Point(7, 20);
            this.rtbGeneratedCode.Name = "rtbGeneratedCode";
            this.rtbGeneratedCode.ReadOnly = true;
            this.rtbGeneratedCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbGeneratedCode.Size = new System.Drawing.Size(652, 274);
            this.rtbGeneratedCode.TabIndex = 0;
            this.rtbGeneratedCode.Text = "";
            // 
            // btnSaveCode
            // 
            this.btnSaveCode.Location = new System.Drawing.Point(550, 470);
            this.btnSaveCode.Name = "btnSaveCode";
            this.btnSaveCode.Size = new System.Drawing.Size(128, 23);
            this.btnSaveCode.TabIndex = 5;
            this.btnSaveCode.Text = "Save Code";
            this.btnSaveCode.UseVisualStyleBackColor = true;
            this.btnSaveCode.Click += new System.EventHandler(this.btnSaveCode_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(13, 470);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(128, 23);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore Orginal Code";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(147, 470);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(128, 23);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Delete Last Line";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSealCode
            // 
            this.btnSealCode.Location = new System.Drawing.Point(416, 470);
            this.btnSealCode.Name = "btnSealCode";
            this.btnSealCode.Size = new System.Drawing.Size(128, 23);
            this.btnSealCode.TabIndex = 8;
            this.btnSealCode.Text = "Finish Code";
            this.btnSealCode.UseVisualStyleBackColor = true;
            this.btnSealCode.Click += new System.EventHandler(this.btnSealCode_Click_1);
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnActivate.Location = new System.Drawing.Point(313, 470);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 23);
            this.btnActivate.TabIndex = 9;
            this.btnActivate.Text = "Start";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 505);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnSealCode);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSaveCode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "EasyKin Visual Kinect Programmer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBodyPart;
        private System.Windows.Forms.ComboBox cbxPartModifier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxPeriph;
        private System.Windows.Forms.ComboBox cbxPeriphButton;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxButtonAction;
        private System.Windows.Forms.TextBox tbxCoordinate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveCode;
        private System.Windows.Forms.RichTextBox rtbGeneratedCode;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSealCode;
        private System.Windows.Forms.ComboBox cbxXY;
        private System.Windows.Forms.Button btnActivate;
    }
}

