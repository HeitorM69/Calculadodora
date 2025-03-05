namespace Calculadodora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.numOper1 = new System.Windows.Forms.NumericUpDown();
            this.numOper2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btSegue = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).BeginInit();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(186, 117);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(64, 41);
            this.btSoma.TabIndex = 0;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(256, 117);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(64, 41);
            this.btSub.TabIndex = 1;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(396, 117);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(64, 41);
            this.btDiv.TabIndex = 2;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btMult
            // 
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.Location = new System.Drawing.Point(326, 117);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(64, 41);
            this.btMult.TabIndex = 3;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btIgual
            // 
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(281, 290);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(119, 55);
            this.btIgual.TabIndex = 4;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // numOper1
            // 
            this.numOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper1.Location = new System.Drawing.Point(326, 63);
            this.numOper1.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.numOper1.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.numOper1.Name = "numOper1";
            this.numOper1.Size = new System.Drawing.Size(120, 26);
            this.numOper1.TabIndex = 5;
            // 
            // numOper2
            // 
            this.numOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOper2.Location = new System.Drawing.Point(326, 227);
            this.numOper2.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.numOper2.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.numOper2.Name = "numOper2";
            this.numOper2.Size = new System.Drawing.Size(120, 26);
            this.numOper2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operador1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operador2";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(486, 127);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(21, 20);
            this.lblOper.TabIndex = 9;
            this.lblOper.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(0, 404);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(797, 37);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btSegue
            // 
            this.btSegue.Location = new System.Drawing.Point(186, 164);
            this.btSegue.Name = "btSegue";
            this.btSegue.Size = new System.Drawing.Size(64, 41);
            this.btSegue.TabIndex = 11;
            this.btSegue.Text = "Segue";
            this.btSegue.UseVisualStyleBackColor = true;
            this.btSegue.Click += new System.EventHandler(this.btSegue_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(256, 164);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(64, 41);
            this.btLimpa.TabIndex = 12;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btSegue);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOper2);
            this.Controls.Add(this.numOper1);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.NumericUpDown numOper1;
        private System.Windows.Forms.NumericUpDown numOper2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btSegue;
        private System.Windows.Forms.Button btLimpa;
    }
}

