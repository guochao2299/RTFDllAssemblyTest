namespace RTFDllAssemblyTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRtfDomParser = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRtfContent = new System.Windows.Forms.RichTextBox();
            this.tvRtfStruct = new System.Windows.Forms.TreeView();
            this.btnFromClipBoard = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tpDotNetRtfWriter = new System.Windows.Forms.TabPage();
            this.btnCreateRtfContent = new System.Windows.Forms.Button();
            this.txtRtfWrtterResult = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tpRtfDomParser.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpDotNetRtfWriter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRtfDomParser);
            this.tabControl1.Controls.Add(this.tpDotNetRtfWriter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRtfDomParser
            // 
            this.tpRtfDomParser.Controls.Add(this.splitContainer1);
            this.tpRtfDomParser.Location = new System.Drawing.Point(4, 22);
            this.tpRtfDomParser.Name = "tpRtfDomParser";
            this.tpRtfDomParser.Padding = new System.Windows.Forms.Padding(3);
            this.tpRtfDomParser.Size = new System.Drawing.Size(876, 560);
            this.tpRtfDomParser.TabIndex = 0;
            this.tpRtfDomParser.Text = "RtfDomParser";
            this.tpRtfDomParser.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tvRtfStruct);
            this.splitContainer1.Panel2.Controls.Add(this.btnFromClipBoard);
            this.splitContainer1.Panel2.Controls.Add(this.btnProcess);
            this.splitContainer1.Size = new System.Drawing.Size(870, 554);
            this.splitContainer1.SplitterDistance = 533;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRtfContent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RTF内容";
            // 
            // txtRtfContent
            // 
            this.txtRtfContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRtfContent.Location = new System.Drawing.Point(3, 17);
            this.txtRtfContent.Name = "txtRtfContent";
            this.txtRtfContent.Size = new System.Drawing.Size(527, 534);
            this.txtRtfContent.TabIndex = 0;
            this.txtRtfContent.Text = "";
            // 
            // tvRtfStruct
            // 
            this.tvRtfStruct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvRtfStruct.Location = new System.Drawing.Point(0, 57);
            this.tvRtfStruct.Name = "tvRtfStruct";
            this.tvRtfStruct.ShowNodeToolTips = true;
            this.tvRtfStruct.Size = new System.Drawing.Size(333, 497);
            this.tvRtfStruct.TabIndex = 1;
            // 
            // btnFromClipBoard
            // 
            this.btnFromClipBoard.Location = new System.Drawing.Point(162, 15);
            this.btnFromClipBoard.Name = "btnFromClipBoard";
            this.btnFromClipBoard.Size = new System.Drawing.Size(148, 23);
            this.btnFromClipBoard.TabIndex = 0;
            this.btnFromClipBoard.Text = "分析剪切板中的rtf内容";
            this.btnFromClipBoard.UseVisualStyleBackColor = true;
            this.btnFromClipBoard.Click += new System.EventHandler(this.btnFromClipBoard_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(23, 15);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(100, 23);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "分析RTF内容";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tpDotNetRtfWriter
            // 
            this.tpDotNetRtfWriter.Controls.Add(this.txtRtfWrtterResult);
            this.tpDotNetRtfWriter.Controls.Add(this.btnCreateRtfContent);
            this.tpDotNetRtfWriter.Location = new System.Drawing.Point(4, 22);
            this.tpDotNetRtfWriter.Name = "tpDotNetRtfWriter";
            this.tpDotNetRtfWriter.Padding = new System.Windows.Forms.Padding(3);
            this.tpDotNetRtfWriter.Size = new System.Drawing.Size(876, 560);
            this.tpDotNetRtfWriter.TabIndex = 1;
            this.tpDotNetRtfWriter.Text = "DotNetRtfWriter";
            this.tpDotNetRtfWriter.UseVisualStyleBackColor = true;
            // 
            // btnCreateRtfContent
            // 
            this.btnCreateRtfContent.Location = new System.Drawing.Point(729, 6);
            this.btnCreateRtfContent.Name = "btnCreateRtfContent";
            this.btnCreateRtfContent.Size = new System.Drawing.Size(109, 23);
            this.btnCreateRtfContent.TabIndex = 0;
            this.btnCreateRtfContent.Text = "生成RTF格式内容";
            this.btnCreateRtfContent.UseVisualStyleBackColor = true;
            this.btnCreateRtfContent.Click += new System.EventHandler(this.btnCreateRtfContent_Click);
            // 
            // txtRtfWrtterResult
            // 
            this.txtRtfWrtterResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtRtfWrtterResult.Location = new System.Drawing.Point(3, 3);
            this.txtRtfWrtterResult.Name = "txtRtfWrtterResult";
            this.txtRtfWrtterResult.Size = new System.Drawing.Size(679, 554);
            this.txtRtfWrtterResult.TabIndex = 1;
            this.txtRtfWrtterResult.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpRtfDomParser.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tpDotNetRtfWriter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRtfDomParser;
        private System.Windows.Forms.TabPage tpDotNetRtfWriter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtRtfContent;
        private System.Windows.Forms.TreeView tvRtfStruct;
        private System.Windows.Forms.Button btnFromClipBoard;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCreateRtfContent;
        private System.Windows.Forms.RichTextBox txtRtfWrtterResult;
    }
}

