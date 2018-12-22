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
            this.flowLayoutPanelSierpinski = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSerpinski = new System.Windows.Forms.Button();
            this.flowLayoutPanelKoch = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonKoch = new System.Windows.Forms.Button();
            this.tableLayoutPanelKochItrs = new System.Windows.Forms.TableLayoutPanel();
            this.labelKochItrs = new System.Windows.Forms.Label();
            this.textBoxKochItrs = new System.Windows.Forms.TextBox();
            this.checkBoxKochAllIters = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonKochPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanelSierpinski.SuspendLayout();
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
            this.tableLayoutPanelTop.Controls.Add(this.flowLayoutPanelSierpinski, 0, 1);
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
            // flowLayoutPanelSierpinski
            // 
            this.flowLayoutPanelSierpinski.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanelSierpinski.AutoSize = true;
            this.flowLayoutPanelSierpinski.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelSierpinski.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelSierpinski.Controls.Add(this.buttonSerpinski);
            this.flowLayoutPanelSierpinski.Location = new System.Drawing.Point(461, 909);
            this.flowLayoutPanelSierpinski.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelSierpinski.Name = "flowLayoutPanelSierpinski";
            this.flowLayoutPanelSierpinski.Size = new System.Drawing.Size(190, 46);
            this.flowLayoutPanelSierpinski.TabIndex = 3;
            this.flowLayoutPanelSierpinski.WrapContents = false;
            // 
            // buttonSerpinski
            // 
            this.buttonSerpinski.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSerpinski.AutoSize = true;
            this.buttonSerpinski.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSerpinski.Location = new System.Drawing.Point(20, 2);
            this.buttonSerpinski.Margin = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.buttonSerpinski.Name = "buttonSerpinski";
            this.buttonSerpinski.Size = new System.Drawing.Size(150, 42);
            this.buttonSerpinski.TabIndex = 0;
            this.buttonSerpinski.Text = "Sierpinski";
            this.buttonSerpinski.UseVisualStyleBackColor = true;
            this.buttonSerpinski.Click += new System.EventHandler(this.OnSierpinskiClick);
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
            this.flowLayoutPanelSierpinski.ResumeLayout(false);
            this.flowLayoutPanelSierpinski.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSierpinski;
        private System.Windows.Forms.Button buttonSerpinski;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKoch;
        private System.Windows.Forms.Button buttonKoch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKochItrs;
        private System.Windows.Forms.Label labelKochItrs;
        private System.Windows.Forms.TextBox textBoxKochItrs;
        private System.Windows.Forms.CheckBox checkBoxKochAllIters;
        private System.Windows.Forms.Button buttonKochPlay;
    }
}

