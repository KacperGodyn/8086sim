namespace _8086
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.TextBox();
            this.AH = new System.Windows.Forms.TextBox();
            this.BL = new System.Windows.Forms.TextBox();
            this.BH = new System.Windows.Forms.TextBox();
            this.CL = new System.Windows.Forms.TextBox();
            this.CH = new System.Windows.Forms.TextBox();
            this.DL = new System.Windows.Forms.TextBox();
            this.DH = new System.Windows.Forms.TextBox();
            this.functions = new System.Windows.Forms.ComboBox();
            this.firstreg = new System.Windows.Forms.ComboBox();
            this.secondreg = new System.Windows.Forms.ComboBox();
            this.execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "AL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "AH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "BL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "BH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "CL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "CH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "DL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "DH";
            // 
            // AL
            // 
            this.AL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AL.Location = new System.Drawing.Point(49, 6);
            this.AL.MaxLength = 2;
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(36, 23);
            this.AL.TabIndex = 1;
            this.AL.TextChanged += new System.EventHandler(this.AL_TextChanged);
            // 
            // AH
            // 
            this.AH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AH.Location = new System.Drawing.Point(121, 6);
            this.AH.MaxLength = 2;
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(36, 23);
            this.AH.TabIndex = 1;
            this.AH.TextChanged += new System.EventHandler(this.AH_TextChanged);
            // 
            // BL
            // 
            this.BL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BL.Location = new System.Drawing.Point(49, 43);
            this.BL.MaxLength = 2;
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(36, 23);
            this.BL.TabIndex = 1;
            this.BL.TextChanged += new System.EventHandler(this.BL_TextChanged);
            // 
            // BH
            // 
            this.BH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BH.Location = new System.Drawing.Point(121, 43);
            this.BH.MaxLength = 2;
            this.BH.Name = "BH";
            this.BH.Size = new System.Drawing.Size(36, 23);
            this.BH.TabIndex = 1;
            this.BH.TextChanged += new System.EventHandler(this.BH_TextChanged);
            // 
            // CL
            // 
            this.CL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CL.Location = new System.Drawing.Point(49, 78);
            this.CL.MaxLength = 2;
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(36, 23);
            this.CL.TabIndex = 1;
            this.CL.TextChanged += new System.EventHandler(this.CL_TextChanged);
            // 
            // CH
            // 
            this.CH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CH.Location = new System.Drawing.Point(121, 78);
            this.CH.MaxLength = 2;
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(36, 23);
            this.CH.TabIndex = 1;
            this.CH.TextChanged += new System.EventHandler(this.CH_TextChanged);
            // 
            // DL
            // 
            this.DL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DL.Location = new System.Drawing.Point(49, 113);
            this.DL.MaxLength = 2;
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(36, 23);
            this.DL.TabIndex = 1;
            this.DL.TextChanged += new System.EventHandler(this.DL_TextChanged);
            // 
            // DH
            // 
            this.DH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DH.Location = new System.Drawing.Point(121, 113);
            this.DH.MaxLength = 2;
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(36, 23);
            this.DH.TabIndex = 1;
            this.DH.TextChanged += new System.EventHandler(this.DH_TextChanged);
            // 
            // functions
            // 
            this.functions.FormattingEnabled = true;
            this.functions.Items.AddRange(new object[] {
            "MOV",
            "XCHG",
            "AND",
            "NAND",
            "OR",
            "NOR",
            "XOR",
            "XNOR",
            "INC",
            "DEC",
            "NOT"});
            this.functions.Location = new System.Drawing.Point(12, 163);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(152, 23);
            this.functions.TabIndex = 2;
            // 
            // firstreg
            // 
            this.firstreg.FormattingEnabled = true;
            this.firstreg.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.firstreg.Location = new System.Drawing.Point(170, 163);
            this.firstreg.Name = "firstreg";
            this.firstreg.Size = new System.Drawing.Size(73, 23);
            this.firstreg.TabIndex = 2;
            // 
            // secondreg
            // 
            this.secondreg.FormattingEnabled = true;
            this.secondreg.Items.AddRange(new object[] {
            "AL",
            "AH",
            "BL",
            "BH",
            "CL",
            "CH",
            "DL",
            "DH"});
            this.secondreg.Location = new System.Drawing.Point(249, 163);
            this.secondreg.Name = "secondreg";
            this.secondreg.Size = new System.Drawing.Size(73, 23);
            this.secondreg.TabIndex = 2;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(167, 78);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(155, 61);
            this.execute.TabIndex = 3;
            this.execute.Text = "EXECUTE";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 236);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.secondreg);
            this.Controls.Add(this.firstreg);
            this.Controls.Add(this.functions);
            this.Controls.Add(this.DH);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.CH);
            this.Controls.Add(this.CL);
            this.Controls.Add(this.BH);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.AH);
            this.Controls.Add(this.AL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "8086";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox AL;
        private TextBox AH;
        private TextBox BL;
        private TextBox BH;
        private TextBox CL;
        private TextBox CH;
        private TextBox DL;
        private TextBox DH;
        private ComboBox functions;
        private ComboBox firstreg;
        private ComboBox secondreg;
        private Button execute;
    }
}