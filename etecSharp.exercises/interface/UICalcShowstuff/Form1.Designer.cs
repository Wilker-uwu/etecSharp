﻿namespace WindowsFormsApplication1 {
    partial class UICalcShowstuff {
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
            this.btn7 = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnEql = new System.Windows.Forms.Button();
            this.btnOp = new System.Windows.Forms.Button();
            this.btnCl = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 62);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 32);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.writeButton);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOut.Location = new System.Drawing.Point(12, 12);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(233, 44);
            this.txtOut.TabIndex = 1;
            this.txtOut.Text = "0";
            this.txtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(54, 62);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(35, 32);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.writeButton);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(95, 62);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(35, 32);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.writeButton);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 100);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 32);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.writeButton);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(54, 100);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 32);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.writeButton);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(95, 100);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 32);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.writeButton);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 138);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 32);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.writeButton);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(54, 138);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 32);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.writeButton);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(95, 138);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 32);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.writeButton);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 176);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 32);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.writeButton);
            // 
            // btnSum
            // 
            this.btnSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSum.Location = new System.Drawing.Point(171, 62);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(35, 32);
            this.btnSum.TabIndex = 11;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.writeButton);
            // 
            // btnSub
            // 
            this.btnSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSub.Location = new System.Drawing.Point(212, 62);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(35, 32);
            this.btnSub.TabIndex = 12;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.writeButton);
            // 
            // btnMul
            // 
            this.btnMul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMul.Location = new System.Drawing.Point(171, 100);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(35, 32);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.writeButton);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiv.Location = new System.Drawing.Point(210, 100);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(35, 32);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.writeButton);
            // 
            // btnEql
            // 
            this.btnEql.Location = new System.Drawing.Point(54, 176);
            this.btnEql.Name = "btnEql";
            this.btnEql.Size = new System.Drawing.Size(76, 32);
            this.btnEql.TabIndex = 17;
            this.btnEql.Text = "=";
            this.btnEql.UseVisualStyleBackColor = true;
            this.btnEql.Click += new System.EventHandler(this.btnEql_Click);
            // 
            // btnOp
            // 
            this.btnOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOp.Location = new System.Drawing.Point(171, 138);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(35, 32);
            this.btnOp.TabIndex = 18;
            this.btnOp.Text = "(";
            this.btnOp.UseVisualStyleBackColor = true;
            this.btnOp.Click += new System.EventHandler(this.writeButton);
            // 
            // btnCl
            // 
            this.btnCl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCl.Location = new System.Drawing.Point(210, 138);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(35, 32);
            this.btnCl.TabIndex = 19;
            this.btnCl.Text = ")";
            this.btnCl.UseVisualStyleBackColor = true;
            this.btnCl.Click += new System.EventHandler(this.writeButton);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(171, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 32);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearOutput);
            // 
            // UICalcShowstuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 220);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCl);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.btnEql);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btn7);
            this.Name = "UICalcShowstuff";
            this.Text = "Calculator that shows the full operation and stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnEql;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnClear;

    }
}

