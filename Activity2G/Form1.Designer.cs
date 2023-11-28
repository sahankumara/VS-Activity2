namespace Activity2G
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarkSubject1 = new System.Windows.Forms.TextBox();
            this.txtMarkSubject2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelMark = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average";
            // 
            // txtMarkSubject1
            // 
            this.txtMarkSubject1.Location = new System.Drawing.Point(113, 34);
            this.txtMarkSubject1.Name = "txtMarkSubject1";
            this.txtMarkSubject1.Size = new System.Drawing.Size(100, 20);
            this.txtMarkSubject1.TabIndex = 3;
            this.txtMarkSubject1.Text = "0";
            this.txtMarkSubject1.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarkSubject1_Validating);
            // 
            // txtMarkSubject2
            // 
            this.txtMarkSubject2.Location = new System.Drawing.Point(113, 73);
            this.txtMarkSubject2.Name = "txtMarkSubject2";
            this.txtMarkSubject2.Size = new System.Drawing.Size(100, 20);
            this.txtMarkSubject2.TabIndex = 4;
            this.txtMarkSubject2.Text = "0";
            this.txtMarkSubject2.TextChanged += new System.EventHandler(this.txtMarkSubject2_TextChanged);
            this.txtMarkSubject2.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarkSubject1_Validating);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(113, 102);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "0";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(113, 146);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(100, 23);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(229, 102);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(0, 13);
            this.labelMark.TabIndex = 7;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 219);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMarkSubject2);
            this.Controls.Add(this.txtMarkSubject1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aggregate Function-Average";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarkSubject1;
        private System.Windows.Forms.TextBox txtMarkSubject2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

