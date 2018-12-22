namespace Fractal {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelSierp = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSierp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSierItrs = new System.Windows.Forms.Label();
            this.textBoxSierpItrs = new System.Windows.Forms.TextBox();
            this.buttonSierpPlay = new System.Windows.Forms.Button();
            this.flowLayoutPanelKoch = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonKoch = new System.Windows.Forms.Button();
            this.tableLayoutPanelKochItrs = new System.Windows.Forms.TableLayoutPanel();
            this.labelKochItrs = new System.Windows.Forms.Label();
            this.textBoxKochItrs = new System.Windows.Forms.TextBox();
            this.checkBoxKochAllIters = new System.Windows.Forms.CheckBox();
            this.buttonKochPlay = new System.Windows.Forms.Button();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelSierp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelKoch.SuspendLayout();
            this.tableLayoutPanelKochItrs.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelSierp, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelKoch, 0, 2);
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelButtons, 0, 3);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 5;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1112, 1077);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 901);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelSierp
            // 
            this.flowLayoutPanelSierp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelSierp.AutoSize = true;
            this.flowLayoutPanelSierp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSierp.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelSierp.Controls.Add(this.buttonSierp);
            this.flowLayoutPanelSierp.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelSierp.Controls.Add(this.buttonSierpPlay);
            this.flowLayoutPanelSierp.Location = new System.Drawing.Point(305, 909);
            this.flowLayoutPanelSierp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelSierp.Name = "flowLayoutPanelSierp";
            this.flowLayoutPanelSierp.Size = new System.Drawing.Size(502, 46);
            this.flowLayoutPanelSierp.TabIndex = 3;
            this.flowLayoutPanelSierp.WrapContents = false;
            // 
            // buttonSierp
            // 
            this.buttonSierp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSierp.AutoSize = true;
            this.buttonSierp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSierp.Location = new System.Drawing.Point(20, 2);
            this.buttonSierp.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.buttonSierp.Name = "buttonSierp";
            this.buttonSierp.Size = new System.Drawing.Size(150, 42);
            this.buttonSierp.TabIndex = 0;
            this.buttonSierp.Text = "Sierpinski";
            this.buttonSierp.UseVisualStyleBackColor = true;
            this.buttonSierp.Click += new System.EventHandler(this.OnSierpinskiClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelSierItrs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSierpItrs, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(193, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(205, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelSierItrs
            // 
            this.labelSierItrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSierItrs.AutoSize = true;
            this.labelSierItrs.BackColor = System.Drawing.SystemColors.Control;
            this.labelSierItrs.Location = new System.Drawing.Point(20, 2);
            this.labelSierItrs.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.labelSierItrs.Name = "labelSierItrs";
            this.labelSierItrs.Size = new System.Drawing.Size(61, 38);
            this.labelSierItrs.TabIndex = 0;
            this.labelSierItrs.Text = "Itrs:";
            this.labelSierItrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSierpItrs
            // 
            this.textBoxSierpItrs.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSierpItrs.Location = new System.Drawing.Point(85, 2);
            this.textBoxSierpItrs.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.textBoxSierpItrs.Name = "textBoxSierpItrs";
            this.textBoxSierpItrs.Size = new System.Drawing.Size(100, 38);
            this.textBoxSierpItrs.TabIndex = 1;
            this.textBoxSierpItrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSierpPlay
            // 
            this.buttonSierpPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSierpPlay.AutoSize = true;
            this.buttonSierpPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSierpPlay.Location = new System.Drawing.Point(411, 2);
            this.buttonSierpPlay.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.buttonSierpPlay.Name = "buttonSierpPlay";
            this.buttonSierpPlay.Size = new System.Drawing.Size(81, 42);
            this.buttonSierpPlay.TabIndex = 4;
            this.buttonSierpPlay.Text = "Play";
            this.buttonSierpPlay.UseVisualStyleBackColor = true;
            this.buttonSierpPlay.Click += new System.EventHandler(this.OnSierpPlayCkick);
            // 
            // flowLayoutPanelKoch
            // 
            this.flowLayoutPanelKoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelKoch.AutoSize = true;
            this.flowLayoutPanelKoch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelKoch.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelKoch.Controls.Add(this.buttonKoch);
            this.flowLayoutPanelKoch.Controls.Add(this.tableLayoutPanelKochItrs);
            this.flowLayoutPanelKoch.Controls.Add(this.buttonKochPlay);
            this.flowLayoutPanelKoch.Location = new System.Drawing.Point(210, 959);
            this.flowLayoutPanelKoch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelKoch.Name = "flowLayoutPanelKoch";
            this.flowLayoutPanelKoch.Size = new System.Drawing.Size(691, 46);
            this.flowLayoutPanelKoch.TabIndex = 4;
            this.flowLayoutPanelKoch.WrapContents = false;
            // 
            // buttonKoch
            // 
            this.buttonKoch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKoch.AutoSize = true;
            this.buttonKoch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKoch.Location = new System.Drawing.Point(20, 2);
            this.buttonKoch.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.buttonKoch.Name = "buttonKoch";
            this.buttonKoch.Size = new System.Drawing.Size(90, 42);
            this.buttonKoch.TabIndex = 0;
            this.buttonKoch.Text = "Koch";
            this.buttonKoch.UseVisualStyleBackColor = true;
            this.buttonKoch.Click += new System.EventHandler(this.OnKochClick);
            // 
            // tableLayoutPanelKochItrs
            // 
            this.tableLayoutPanelKochItrs.AutoSize = true;
            this.tableLayoutPanelKochItrs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelKochItrs.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelKochItrs.ColumnCount = 3;
            this.tableLayoutPanelKochItrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKochItrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelKochItrs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelKochItrs.Controls.Add(this.labelKochItrs, 0, 0);
            this.tableLayoutPanelKochItrs.Controls.Add(this.textBoxKochItrs, 1, 0);
            this.tableLayoutPanelKochItrs.Controls.Add(this.checkBoxKochAllIters, 2, 0);
            this.tableLayoutPanelKochItrs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelKochItrs.Location = new System.Drawing.Point(133, 2);
            this.tableLayoutPanelKochItrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelKochItrs.Name = "tableLayoutPanelKochItrs";
            this.tableLayoutPanelKochItrs.RowCount = 1;
            this.tableLayoutPanelKochItrs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelKochItrs.Size = new System.Drawing.Size(454, 42);
            this.tableLayoutPanelKochItrs.TabIndex = 2;
            // 
            // labelKochItrs
            // 
            this.labelKochItrs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKochItrs.AutoSize = true;
            this.labelKochItrs.BackColor = System.Drawing.SystemColors.Control;
            this.labelKochItrs.Location = new System.Drawing.Point(20, 2);
            this.labelKochItrs.Margin = new System.Windows.Forms.Padding(20, 2, 2, 2);
            this.labelKochItrs.Name = "labelKochItrs";
            this.labelKochItrs.Size = new System.Drawing.Size(61, 38);
            this.labelKochItrs.TabIndex = 0;
            this.labelKochItrs.Text = "Itrs:";
            this.labelKochItrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxKochItrs
            // 
            this.textBoxKochItrs.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxKochItrs.Location = new System.Drawing.Point(85, 2);
            this.textBoxKochItrs.Margin = new System.Windows.Forms.Padding(2, 2, 20, 2);
            this.textBoxKochItrs.Name = "textBoxKochItrs";
            this.textBoxKochItrs.Size = new System.Drawing.Size(100, 38);
            this.textBoxKochItrs.TabIndex = 1;
            this.textBoxKochItrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxKochAllIters
            // 
            this.checkBoxKochAllIters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxKochAllIters.AutoSize = true;
            this.checkBoxKochAllIters.Location = new System.Drawing.Point(225, 2);
            this.checkBoxKochAllIters.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.checkBoxKochAllIters.Name = "checkBoxKochAllIters";
            this.checkBoxKochAllIters.Size = new System.Drawing.Size(209, 38);
            this.checkBoxKochAllIters.TabIndex = 5;
            this.checkBoxKochAllIters.Text = "Show All Itrs";
            this.checkBoxKochAllIters.UseVisualStyleBackColor = true;
            // 
            // buttonKochPlay
            // 
            this.buttonKochPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKochPlay.AutoSize = true;
            this.buttonKochPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKochPlay.Location = new System.Drawing.Point(600, 2);
            this.buttonKochPlay.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.buttonKochPlay.Name = "buttonKochPlay";
            this.buttonKochPlay.Size = new System.Drawing.Size(81, 42);
            this.buttonKochPlay.TabIndex = 3;
            this.buttonKochPlay.Text = "Play";
            this.buttonKochPlay.UseVisualStyleBackColor = true;
            this.buttonKochPlay.Click += new System.EventHandler(this.OnKochPlayCkick);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonQuit);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(497, 1009);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(118, 46);
            this.flowLayoutPanelButtons.TabIndex = 2;
            this.flowLayoutPanelButtons.WrapContents = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.AutoSize = true;
            this.buttonQuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonQuit.Location = new System.Drawing.Point(20, 2);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(78, 42);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.OnQuitClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 1077);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Name = "Form1";
            this.Text = "Fractals";
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanelSierp.ResumeLayout(false);
            this.flowLayoutPanelSierp.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelKoch.ResumeLayout(false);
            this.flowLayoutPanelKoch.PerformLayout();
            this.tableLayoutPanelKochItrs.ResumeLayout(false);
            this.tableLayoutPanelKochItrs.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSierp;
        private System.Windows.Forms.Button buttonSierp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKoch;
        private System.Windows.Forms.Button buttonKoch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKochItrs;
        private System.Windows.Forms.Label labelKochItrs;
        private System.Windows.Forms.TextBox textBoxKochItrs;
        private System.Windows.Forms.CheckBox checkBoxKochAllIters;
        private System.Windows.Forms.Button buttonKochPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSierItrs;
        private System.Windows.Forms.TextBox textBoxSierpItrs;
        private System.Windows.Forms.Button buttonSierpPlay;
    }
}

