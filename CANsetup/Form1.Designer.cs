namespace Kv_DeviceDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kvaserSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCANMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sWVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kvaserDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configHintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CANstatus_cB = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SWversLbl = new System.Windows.Forms.Label();
            this.GUItimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.updateIntervalLbl = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kvaserSetupToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(606, 33);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kvaserSetupToolStripMenuItem
            // 
            this.kvaserSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createANewConfigToolStripMenuItem,
            this.viewCANMappingToolStripMenuItem});
            this.kvaserSetupToolStripMenuItem.Name = "kvaserSetupToolStripMenuItem";
            this.kvaserSetupToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.kvaserSetupToolStripMenuItem.Text = "Configuration";
            // 
            // createANewConfigToolStripMenuItem
            // 
            this.createANewConfigToolStripMenuItem.Name = "createANewConfigToolStripMenuItem";
            this.createANewConfigToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.createANewConfigToolStripMenuItem.Text = "Create a New Config";
            this.createANewConfigToolStripMenuItem.Click += new System.EventHandler(this.createANewConfigToolStripMenuItem_Click);
            // 
            // viewCANMappingToolStripMenuItem
            // 
            this.viewCANMappingToolStripMenuItem.Name = "viewCANMappingToolStripMenuItem";
            this.viewCANMappingToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.viewCANMappingToolStripMenuItem.Text = "View CAN Mapping";
            this.viewCANMappingToolStripMenuItem.Click += new System.EventHandler(this.viewCANMappingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sWVersionToolStripMenuItem,
            this.kvaserDriverToolStripMenuItem,
            this.configHintsToolStripMenuItem,
            this.releaseNotesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // sWVersionToolStripMenuItem
            // 
            this.sWVersionToolStripMenuItem.Name = "sWVersionToolStripMenuItem";
            this.sWVersionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sWVersionToolStripMenuItem.Text = "SW Version";
            this.sWVersionToolStripMenuItem.Click += new System.EventHandler(this.sWVersionToolStripMenuItem_Click_1);
            // 
            // kvaserDriverToolStripMenuItem
            // 
            this.kvaserDriverToolStripMenuItem.Name = "kvaserDriverToolStripMenuItem";
            this.kvaserDriverToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kvaserDriverToolStripMenuItem.Text = "Kvaser Driver";
            this.kvaserDriverToolStripMenuItem.Click += new System.EventHandler(this.kvaserDriverToolStripMenuItem_Click);
            // 
            // configHintsToolStripMenuItem
            // 
            this.configHintsToolStripMenuItem.Name = "configHintsToolStripMenuItem";
            this.configHintsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.configHintsToolStripMenuItem.Text = "Config Hints";
            this.configHintsToolStripMenuItem.Click += new System.EventHandler(this.configHintsToolStripMenuItem_Click_1);
            // 
            // releaseNotesToolStripMenuItem
            // 
            this.releaseNotesToolStripMenuItem.Name = "releaseNotesToolStripMenuItem";
            this.releaseNotesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.releaseNotesToolStripMenuItem.Text = "Release Notes";
            this.releaseNotesToolStripMenuItem.Click += new System.EventHandler(this.releaseNotesToolStripMenuItem_Click);
            // 
            // CANstatus_cB
            // 
            this.CANstatus_cB.AutoSize = true;
            this.CANstatus_cB.Enabled = false;
            this.CANstatus_cB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANstatus_cB.Location = new System.Drawing.Point(21, 72);
            this.CANstatus_cB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CANstatus_cB.Name = "CANstatus_cB";
            this.CANstatus_cB.Size = new System.Drawing.Size(164, 21);
            this.CANstatus_cB.TabIndex = 55;
            this.CANstatus_cB.Text = "CAN HW Status";
            this.CANstatus_cB.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 291);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(535, 318);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // SWversLbl
            // 
            this.SWversLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SWversLbl.AutoSize = true;
            this.SWversLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWversLbl.Location = new System.Drawing.Point(18, 645);
            this.SWversLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SWversLbl.Name = "SWversLbl";
            this.SWversLbl.Size = new System.Drawing.Size(51, 15);
            this.SWversLbl.TabIndex = 56;
            this.SWversLbl.Text = "SWvers:";
            // 
            // GUItimer
            // 
            this.GUItimer.Interval = 200;
            this.GUItimer.Tick += new System.EventHandler(this.GUItimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 57;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateIntervalLbl
            // 
            this.updateIntervalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateIntervalLbl.AutoSize = true;
            this.updateIntervalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateIntervalLbl.Location = new System.Drawing.Point(279, 645);
            this.updateIntervalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateIntervalLbl.Name = "updateIntervalLbl";
            this.updateIntervalLbl.Size = new System.Drawing.Size(108, 15);
            this.updateIntervalLbl.TabIndex = 58;
            this.updateIntervalLbl.Text = "GUI Timer Interval:";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 662);
            this.Controls.Add(this.updateIntervalLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SWversLbl);
            this.Controls.Add(this.CANstatus_cB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAN Demo Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kvaserSetupToolStripMenuItem;
        private System.Windows.Forms.CheckBox CANstatus_cB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label SWversLbl;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sWVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kvaserDriverToolStripMenuItem;
        private System.Windows.Forms.Timer GUItimer;
        private System.Windows.Forms.ToolStripMenuItem createANewConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCANMappingToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label updateIntervalLbl;
        private System.Windows.Forms.ToolStripMenuItem configHintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

