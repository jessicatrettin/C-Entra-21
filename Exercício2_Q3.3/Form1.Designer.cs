
namespace Exercício2_Q3._3
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
            this.textAltura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBtnFeminino = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura (cm)";
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(72, 182);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(185, 27);
            this.textAltura.TabIndex = 1;
            this.textAltura.TextChanged += new System.EventHandler(this.textAltura_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular peso ideal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalcularPesoIdeal);
            // 
            // radioBtnFeminino
            // 
            this.radioBtnFeminino.AutoSize = true;
            this.radioBtnFeminino.Location = new System.Drawing.Point(6, 29);
            this.radioBtnFeminino.Name = "radioBtnFeminino";
            this.radioBtnFeminino.Size = new System.Drawing.Size(91, 24);
            this.radioBtnFeminino.TabIndex = 3;
            this.radioBtnFeminino.TabStop = true;
            this.radioBtnFeminino.Text = "Feminino";
            this.radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(6, 59);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(97, 24);
            this.radioBtnMasculino.TabIndex = 4;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFeminino);
            this.groupBox1.Controls.Add(this.radioBtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(66, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnFeminino;
    }
}

