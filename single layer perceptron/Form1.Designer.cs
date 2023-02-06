namespace single_layer_perceptron
{
    partial class Perceptron
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perceptron));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MAIN = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.directory = new System.Windows.Forms.Label();
            this.trainingdes = new System.Windows.Forms.Label();
            this.starttrain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.logicGate = new System.Windows.Forms.ComboBox();
            this.loadData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GUIDE = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PROCESS = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.MAIN.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GUIDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PROCESS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MAIN);
            this.tabControl1.Controls.Add(this.GUIDE);
            this.tabControl1.Controls.Add(this.PROCESS);
            this.tabControl1.Location = new System.Drawing.Point(-4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 524);
            this.tabControl1.TabIndex = 14;
            // 
            // MAIN
            // 
            this.MAIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MAIN.BackgroundImage")));
            this.MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MAIN.Controls.Add(this.groupBox2);
            this.MAIN.Controls.Add(this.groupBox1);
            this.MAIN.Controls.Add(this.label5);
            this.MAIN.Controls.Add(this.logicGate);
            this.MAIN.Controls.Add(this.loadData);
            this.MAIN.Controls.Add(this.label1);
            this.MAIN.Controls.Add(this.pictureBox2);
            this.MAIN.Location = new System.Drawing.Point(4, 29);
            this.MAIN.Name = "MAIN";
            this.MAIN.Padding = new System.Windows.Forms.Padding(3);
            this.MAIN.Size = new System.Drawing.Size(848, 491);
            this.MAIN.TabIndex = 0;
            this.MAIN.Text = "MAIN";
            this.MAIN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.directory);
            this.groupBox2.Controls.Add(this.trainingdes);
            this.groupBox2.Controls.Add(this.starttrain);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(440, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 211);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRAINING";
            // 
            // directory
            // 
            this.directory.AutoSize = true;
            this.directory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.directory.Location = new System.Drawing.Point(16, 141);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(354, 51);
            this.directory.TabIndex = 3;
            this.directory.Text = "To see the detailed process open \"output.csv\"\r\nin \"single layer perceptron\\bin\\De" +
    "bug\\net6.0-windows\"\r\n directory\r\n";
            this.directory.Visible = false;
            // 
            // trainingdes
            // 
            this.trainingdes.AutoSize = true;
            this.trainingdes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trainingdes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trainingdes.ForeColor = System.Drawing.SystemColors.Control;
            this.trainingdes.Location = new System.Drawing.Point(12, 44);
            this.trainingdes.Name = "trainingdes";
            this.trainingdes.Size = new System.Drawing.Size(63, 25);
            this.trainingdes.TabIndex = 2;
            this.trainingdes.Text = "label6";
            this.trainingdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trainingdes.Visible = false;
            // 
            // starttrain
            // 
            this.starttrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.starttrain.Font = new System.Drawing.Font("Josefin Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.starttrain.Location = new System.Drawing.Point(117, 82);
            this.starttrain.Name = "starttrain";
            this.starttrain.Size = new System.Drawing.Size(146, 44);
            this.starttrain.TabIndex = 1;
            this.starttrain.Text = "START";
            this.starttrain.UseVisualStyleBackColor = false;
            this.starttrain.Click += new System.EventHandler(this.starttrain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.testOutput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.input2);
            this.groupBox1.Controls.Add(this.input1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.testData);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 209);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEST";
            // 
            // testOutput
            // 
            this.testOutput.Location = new System.Drawing.Point(205, 163);
            this.testOutput.Name = "testOutput";
            this.testOutput.Size = new System.Drawing.Size(125, 27);
            this.testOutput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "OUTPUT";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(206, 59);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(125, 27);
            this.input2.TabIndex = 6;
            this.input2.Text = "0";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(206, 26);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(125, 27);
            this.input1.TabIndex = 5;
            this.input1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input 2: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input 1: ";
            // 
            // testData
            // 
            this.testData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.testData.Font = new System.Drawing.Font("Josefin Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.testData.Location = new System.Drawing.Point(218, 106);
            this.testData.Name = "testData";
            this.testData.Size = new System.Drawing.Size(112, 35);
            this.testData.TabIndex = 2;
            this.testData.Text = "TEST";
            this.testData.UseVisualStyleBackColor = false;
            this.testData.Click += new System.EventHandler(this.testData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(291, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Choose a logic";
            // 
            // logicGate
            // 
            this.logicGate.AllowDrop = true;
            this.logicGate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logicGate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.logicGate.FormattingEnabled = true;
            this.logicGate.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.logicGate.Location = new System.Drawing.Point(436, 213);
            this.logicGate.Name = "logicGate";
            this.logicGate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logicGate.Size = new System.Drawing.Size(82, 28);
            this.logicGate.TabIndex = 16;
            this.logicGate.Text = "AND";
            // 
            // loadData
            // 
            this.loadData.AutoSize = true;
            this.loadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadData.Font = new System.Drawing.Font("Josefin Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadData.ForeColor = System.Drawing.Color.White;
            this.loadData.Location = new System.Drawing.Point(30, 216);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(116, 33);
            this.loadData.TabIndex = 15;
            this.loadData.Text = "LOAD DATA";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Two Input Perceptron (AND/OR LOGIC)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(301, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // GUIDE
            // 
            this.GUIDE.Controls.Add(this.pictureBox1);
            this.GUIDE.Location = new System.Drawing.Point(4, 29);
            this.GUIDE.Name = "GUIDE";
            this.GUIDE.Padding = new System.Windows.Forms.Padding(3);
            this.GUIDE.Size = new System.Drawing.Size(848, 491);
            this.GUIDE.TabIndex = 1;
            this.GUIDE.Text = "GUIDE";
            this.GUIDE.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PROCESS
            // 
            this.PROCESS.Controls.Add(this.label6);
            this.PROCESS.Controls.Add(this.pictureBox3);
            this.PROCESS.Location = new System.Drawing.Point(4, 29);
            this.PROCESS.Name = "PROCESS";
            this.PROCESS.Size = new System.Drawing.Size(848, 491);
            this.PROCESS.TabIndex = 2;
            this.PROCESS.Text = "PROCESS";
            this.PROCESS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(239, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "SINGLE LAYER PERCEPTRON PROCESS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(79, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(664, 394);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 509);
            this.panel1.TabIndex = 13;
            // 
            // Perceptron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 510);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 557);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(865, 557);
            this.Name = "Perceptron";
            this.Text = "Perceptron";
            this.tabControl1.ResumeLayout(false);
            this.MAIN.ResumeLayout(false);
            this.MAIN.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GUIDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PROCESS.ResumeLayout(false);
            this.PROCESS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage MAIN;
        private GroupBox groupBox2;
        private Label directory;
        private Label trainingdes;
        private Button starttrain;
        private GroupBox groupBox1;
        private TextBox testOutput;
        private Label label4;
        private TextBox input2;
        private TextBox input1;
        private Label label3;
        private Label label2;
        private Button testData;
        private Label label5;
        private ComboBox logicGate;
        private Button loadData;
        private Label label1;
        private PictureBox pictureBox2;
        private TabPage GUIDE;
        private PictureBox pictureBox1;
        private TabPage PROCESS;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox3;
    }
}