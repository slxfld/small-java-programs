namespace Funktions_Zeichner
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.abstand_numeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bereich_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.hohe_numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bis_numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.von_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bereich_l = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbHoch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_ergebnise = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstand_numeric)).BeginInit();
            this.Bereich_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hohe_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bis_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.von_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sToolStripMenuItem.Text = "Speichern";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 370);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Bereich_panel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 109);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tbE);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbD);
            this.panel3.Controls.Add(this.tbC);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.tbHoch);
            this.panel3.Controls.Add(this.tbA);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbB);
            this.panel3.Controls.Add(this.bereich_l);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(317, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 104);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Funktion Zeichnen!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.hohe_numeric);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.abstand_numeric);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(157, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 103);
            this.panel4.TabIndex = 4;
            // 
            // abstand_numeric
            // 
            this.abstand_numeric.Location = new System.Drawing.Point(66, 25);
            this.abstand_numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.abstand_numeric.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.abstand_numeric.Name = "abstand_numeric";
            this.abstand_numeric.Size = new System.Drawing.Size(85, 20);
            this.abstand_numeric.TabIndex = 6;
            this.abstand_numeric.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.abstand_numeric.ValueChanged += new System.EventHandler(this.changed_numeric);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Abstand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Optionen";
            // 
            // Bereich_panel
            // 
            this.Bereich_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bereich_panel.Controls.Add(this.label3);
            this.Bereich_panel.Controls.Add(this.bis_numeric);
            this.Bereich_panel.Controls.Add(this.label2);
            this.Bereich_panel.Controls.Add(this.von_numeric);
            this.Bereich_panel.Controls.Add(this.label1);
            this.Bereich_panel.Location = new System.Drawing.Point(3, 3);
            this.Bereich_panel.Name = "Bereich_panel";
            this.Bereich_panel.Size = new System.Drawing.Size(148, 103);
            this.Bereich_panel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Höhe";
            // 
            // hohe_numeric
            // 
            this.hohe_numeric.Location = new System.Drawing.Point(66, 49);
            this.hohe_numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.hohe_numeric.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.hohe_numeric.Name = "hohe_numeric";
            this.hohe_numeric.Size = new System.Drawing.Size(85, 20);
            this.hohe_numeric.TabIndex = 6;
            this.hohe_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hohe_numeric.ValueChanged += new System.EventHandler(this.changed_numeric);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bis";
            // 
            // bis_numeric
            // 
            this.bis_numeric.Location = new System.Drawing.Point(45, 52);
            this.bis_numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.bis_numeric.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.bis_numeric.Name = "bis_numeric";
            this.bis_numeric.Size = new System.Drawing.Size(94, 20);
            this.bis_numeric.TabIndex = 4;
            this.bis_numeric.ValueChanged += new System.EventHandler(this.changed_numeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Von";
            // 
            // von_numeric
            // 
            this.von_numeric.Location = new System.Drawing.Point(45, 26);
            this.von_numeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.von_numeric.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.von_numeric.Name = "von_numeric";
            this.von_numeric.Size = new System.Drawing.Size(94, 20);
            this.von_numeric.TabIndex = 1;
            this.von_numeric.ValueChanged += new System.EventHandler(this.changed_numeric);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bereich";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Funktion Info";
            // 
            // bereich_l
            // 
            this.bereich_l.AutoSize = true;
            this.bereich_l.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bereich_l.Location = new System.Drawing.Point(3, 26);
            this.bereich_l.Name = "bereich_l";
            this.bereich_l.Size = new System.Drawing.Size(105, 15);
            this.bereich_l.TabIndex = 8;
            this.bereich_l.Text = "Bereich: [0;0]";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(155, 34);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(30, 20);
            this.tbB.TabIndex = 9;
            this.tbB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(3, 44);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(30, 20);
            this.tbA.TabIndex = 11;
            this.tbA.Text = "1";
            // 
            // tbHoch
            // 
            this.tbHoch.Location = new System.Drawing.Point(75, 44);
            this.tbHoch.Name = "tbHoch";
            this.tbHoch.Size = new System.Drawing.Size(30, 20);
            this.tbHoch.TabIndex = 12;
            this.tbHoch.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "b";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "^";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(155, 52);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(30, 20);
            this.tbC.TabIndex = 15;
            this.tbC.Text = "0";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(155, 71);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(30, 20);
            this.tbD.TabIndex = 16;
            this.tbD.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(191, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "c";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(191, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "d";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(215, 34);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(30, 20);
            this.tbE.TabIndex = 19;
            this.tbE.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(251, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "e";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(45, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "f(x)\'";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(93, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "f(x)\'\'";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Purple;
            this.label16.Location = new System.Drawing.Point(4, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 15);
            this.label16.TabIndex = 23;
            this.label16.Text = "f(x)\'\'\'";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(4, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "f(x)";
            // 
            // tb_ergebnise
            // 
            this.tb_ergebnise.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ergebnise.Location = new System.Drawing.Point(618, 27);
            this.tb_ergebnise.Multiline = true;
            this.tb_ergebnise.Name = "tb_ergebnise";
            this.tb_ergebnise.ReadOnly = true;
            this.tb_ergebnise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ergebnise.Size = new System.Drawing.Size(174, 367);
            this.tb_ergebnise.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(652, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "© 2018 Simon Lixenfeld";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 509);
            this.Controls.Add(this.tb_ergebnise);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(628, 548);
            this.Name = "Form1";
            this.Text = "f(x)Zeichner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abstand_numeric)).EndInit();
            this.Bereich_panel.ResumeLayout(false);
            this.Bereich_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hohe_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bis_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.von_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Bereich_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown bis_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown von_numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown abstand_numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown hohe_numeric;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bereich_l;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHoch;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_ergebnise;
        private System.Windows.Forms.Label label18;
    }
}

