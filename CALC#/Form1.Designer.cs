namespace CALC_
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
            CONSOLAJEAN = new TextBox();
            BTN1 = new Button();
            BTN3 = new Button();
            BTN2 = new Button();
            BTN5 = new Button();
            BTN6 = new Button();
            BTN4 = new Button();
            BTN8 = new Button();
            BTN9 = new Button();
            BTN7 = new Button();
            VACIAR = new Button();
            SIUU = new Button();
            CLEAR1 = new Button();
            RAIZ = new Button();
            POTENCIA = new Button();
            PORCENTAJE = new Button();
            MULT = new Button();
            SUMA = new Button();
            RESTA = new Button();
            IGUAL = new Button();
            BTN0 = new Button();
            BTNPUNTO = new Button();
            BTISQ = new Button();
            SuspendLayout();
            // 
            // CONSOLAJEAN
            // 
            CONSOLAJEAN.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            CONSOLAJEAN.Location = new Point(3, 26);
            CONSOLAJEAN.Multiline = true;
            CONSOLAJEAN.Name = "CONSOLAJEAN";
            CONSOLAJEAN.ReadOnly = true;
            CONSOLAJEAN.Size = new Size(367, 67);
            CONSOLAJEAN.TabIndex = 0;
            CONSOLAJEAN.Text = "0";
            CONSOLAJEAN.TextChanged += textBox1_TextChanged;
            // 
            // BTN1
            // 
            BTN1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN1.Location = new Point(12, 354);
            BTN1.Name = "BTN1";
            BTN1.Size = new Size(63, 63);
            BTN1.TabIndex = 1;
            BTN1.Text = "1";
            BTN1.UseVisualStyleBackColor = true;
            BTN1.Click += button1_Click;
            // 
            // BTN3
            // 
            BTN3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN3.Location = new Point(150, 354);
            BTN3.Name = "BTN3";
            BTN3.Size = new Size(63, 63);
            BTN3.TabIndex = 2;
            BTN3.Text = "3";
            BTN3.UseVisualStyleBackColor = true;
            BTN3.Click += button2_Click_1;
            // 
            // BTN2
            // 
            BTN2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN2.Location = new Point(81, 354);
            BTN2.Name = "BTN2";
            BTN2.Size = new Size(63, 63);
            BTN2.TabIndex = 3;
            BTN2.Text = "2";
            BTN2.UseVisualStyleBackColor = true;
            BTN2.Click += button3_Click;
            // 
            // BTN5
            // 
            BTN5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN5.Location = new Point(81, 272);
            BTN5.Name = "BTN5";
            BTN5.Size = new Size(63, 63);
            BTN5.TabIndex = 6;
            BTN5.Text = "5";
            BTN5.UseVisualStyleBackColor = true;
            BTN5.Click += button4_Click;
            // 
            // BTN6
            // 
            BTN6.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN6.Location = new Point(150, 272);
            BTN6.Name = "BTN6";
            BTN6.Size = new Size(63, 63);
            BTN6.TabIndex = 5;
            BTN6.Text = "6";
            BTN6.UseVisualStyleBackColor = true;
            // 
            // BTN4
            // 
            BTN4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN4.Location = new Point(12, 272);
            BTN4.Name = "BTN4";
            BTN4.Size = new Size(63, 63);
            BTN4.TabIndex = 4;
            BTN4.Text = "4";
            BTN4.UseVisualStyleBackColor = true;
            // 
            // BTN8
            // 
            BTN8.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN8.Location = new Point(81, 192);
            BTN8.Name = "BTN8";
            BTN8.Size = new Size(63, 63);
            BTN8.TabIndex = 9;
            BTN8.Text = "8";
            BTN8.UseVisualStyleBackColor = true;
            // 
            // BTN9
            // 
            BTN9.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN9.Location = new Point(150, 192);
            BTN9.Name = "BTN9";
            BTN9.Size = new Size(63, 63);
            BTN9.TabIndex = 8;
            BTN9.Text = "9";
            BTN9.UseVisualStyleBackColor = true;
            // 
            // BTN7
            // 
            BTN7.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN7.Location = new Point(12, 192);
            BTN7.Name = "BTN7";
            BTN7.Size = new Size(63, 63);
            BTN7.TabIndex = 7;
            BTN7.Text = "7";
            BTN7.UseVisualStyleBackColor = true;
            // 
            // VACIAR
            // 
            VACIAR.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            VACIAR.Location = new Point(81, 114);
            VACIAR.Name = "VACIAR";
            VACIAR.Size = new Size(78, 63);
            VACIAR.TabIndex = 12;
            VACIAR.Text = "C";
            VACIAR.UseVisualStyleBackColor = true;
            VACIAR.Click += VACIAR_Click;
            // 
            // SIUU
            // 
            SIUU.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            SIUU.Location = new Point(165, 114);
            SIUU.Name = "SIUU";
            SIUU.Size = new Size(63, 63);
            SIUU.TabIndex = 11;
            SIUU.Text = "<-";
            SIUU.UseVisualStyleBackColor = true;
            // 
            // CLEAR1
            // 
            CLEAR1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CLEAR1.Location = new Point(3, 114);
            CLEAR1.Name = "CLEAR1";
            CLEAR1.Size = new Size(76, 55);
            CLEAR1.TabIndex = 10;
            CLEAR1.Text = "CE";
            CLEAR1.UseVisualStyleBackColor = true;
            CLEAR1.Click += CLEAR1_Click;
            // 
            // RAIZ
            // 
            RAIZ.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            RAIZ.Location = new Point(227, 114);
            RAIZ.Name = "RAIZ";
            RAIZ.Size = new Size(63, 63);
            RAIZ.TabIndex = 14;
            RAIZ.Text = "√";
            RAIZ.UseVisualStyleBackColor = true;
            // 
            // POTENCIA
            // 
            POTENCIA.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            POTENCIA.Location = new Point(296, 114);
            POTENCIA.Name = "POTENCIA";
            POTENCIA.Size = new Size(63, 63);
            POTENCIA.TabIndex = 13;
            POTENCIA.Text = "^";
            POTENCIA.UseVisualStyleBackColor = true;
            POTENCIA.Click += button14_Click;
            // 
            // PORCENTAJE
            // 
            PORCENTAJE.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            PORCENTAJE.Location = new Point(227, 192);
            PORCENTAJE.Name = "PORCENTAJE";
            PORCENTAJE.Size = new Size(63, 63);
            PORCENTAJE.TabIndex = 16;
            PORCENTAJE.Text = "%";
            PORCENTAJE.UseVisualStyleBackColor = true;
            // 
            // MULT
            // 
            MULT.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            MULT.Location = new Point(296, 192);
            MULT.Name = "MULT";
            MULT.Size = new Size(63, 63);
            MULT.TabIndex = 15;
            MULT.Text = "X";
            MULT.UseVisualStyleBackColor = true;
            // 
            // SUMA
            // 
            SUMA.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            SUMA.Location = new Point(227, 272);
            SUMA.Name = "SUMA";
            SUMA.Size = new Size(63, 63);
            SUMA.TabIndex = 18;
            SUMA.Text = "+";
            SUMA.UseVisualStyleBackColor = true;
            // 
            // RESTA
            // 
            RESTA.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            RESTA.Location = new Point(296, 272);
            RESTA.Name = "RESTA";
            RESTA.Size = new Size(63, 63);
            RESTA.TabIndex = 17;
            RESTA.Text = "-";
            RESTA.UseVisualStyleBackColor = true;
            // 
            // IGUAL
            // 
            IGUAL.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            IGUAL.Location = new Point(227, 354);
            IGUAL.Name = "IGUAL";
            IGUAL.Size = new Size(132, 143);
            IGUAL.TabIndex = 19;
            IGUAL.Text = "=";
            IGUAL.UseVisualStyleBackColor = true;
            IGUAL.Click += button20_Click;
            // 
            // BTN0
            // 
            BTN0.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN0.Location = new Point(81, 434);
            BTN0.Name = "BTN0";
            BTN0.Size = new Size(63, 63);
            BTN0.TabIndex = 22;
            BTN0.Text = "0";
            BTN0.UseVisualStyleBackColor = true;
            BTN0.Click += button21_Click;
            // 
            // BTNPUNTO
            // 
            BTNPUNTO.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTNPUNTO.Location = new Point(150, 434);
            BTNPUNTO.Name = "BTNPUNTO";
            BTNPUNTO.Size = new Size(63, 63);
            BTNPUNTO.TabIndex = 21;
            BTNPUNTO.Text = ".";
            BTNPUNTO.UseVisualStyleBackColor = true;
            BTNPUNTO.Click += button22_Click;
            // 
            // BTISQ
            // 
            BTISQ.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTISQ.Location = new Point(12, 434);
            BTISQ.Name = "BTISQ";
            BTISQ.Size = new Size(63, 63);
            BTISQ.TabIndex = 20;
            BTISQ.Text = "±";
            BTISQ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 552);
            Controls.Add(BTN0);
            Controls.Add(BTNPUNTO);
            Controls.Add(BTISQ);
            Controls.Add(IGUAL);
            Controls.Add(SUMA);
            Controls.Add(RESTA);
            Controls.Add(PORCENTAJE);
            Controls.Add(MULT);
            Controls.Add(RAIZ);
            Controls.Add(POTENCIA);
            Controls.Add(VACIAR);
            Controls.Add(SIUU);
            Controls.Add(CLEAR1);
            Controls.Add(BTN8);
            Controls.Add(BTN9);
            Controls.Add(BTN7);
            Controls.Add(BTN5);
            Controls.Add(BTN6);
            Controls.Add(BTN4);
            Controls.Add(BTN2);
            Controls.Add(BTN3);
            Controls.Add(BTN1);
            Controls.Add(CONSOLAJEAN);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CONSOLAJEAN;
        private Button BTN1;
        private Button BTN3;
        private Button BTN2;
        private Button BTN5;
        private Button BTN6;
        private Button BTN4;
        private Button BTN8;
        private Button BTN9;
        private Button BTN7;
        private Button VACIAR;
        private Button SIUU;
        private Button CLEAR1;
        private Button RAIZ;
        private Button POTENCIA;
        private Button PORCENTAJE;
        private Button MULT;
        private Button SUMA;
        private Button RESTA;
        private Button IGUAL;
        private Button BTN0;
        private Button BTNPUNTO;
        private Button BTISQ;
    }
}