namespace CompraParcelada
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
            txtValorCompra = new TextBox();
            txtQtdeParcelas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalcular = new Button();
            lblValorParcelas = new Label();
            lblTotalCompra = new Label();
            SuspendLayout();
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(233, 58);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(80, 23);
            txtValorCompra.TabIndex = 0;
            // 
            // txtQtdeParcelas
            // 
            txtQtdeParcelas.Location = new Point(233, 100);
            txtQtdeParcelas.Name = "txtQtdeParcelas";
            txtQtdeParcelas.Size = new Size(55, 23);
            txtQtdeParcelas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 61);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor da compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 103);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Qtde. de parcelas:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(106, 167);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblValorParcelas
            // 
            lblValorParcelas.AutoSize = true;
            lblValorParcelas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorParcelas.Location = new Point(106, 278);
            lblValorParcelas.Name = "lblValorParcelas";
            lblValorParcelas.Size = new Size(151, 21);
            lblValorParcelas.TabIndex = 5;
            lblValorParcelas.Text = "Valor das parcelas:";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCompra.Location = new Point(106, 237);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(257, 21);
            lblTotalCompra.TabIndex = 6;
            lblTotalCompra.Text = "Valor final da compra com juros:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 381);
            Controls.Add(lblTotalCompra);
            Controls.Add(lblValorParcelas);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQtdeParcelas);
            Controls.Add(txtValorCompra);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra parcelada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorCompra;
        private TextBox txtQtdeParcelas;
        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private Label lblValorParcelas;
        private Label lblTotalCompra;
    }
}