namespace _2PoliticasStock
{
    partial class FormPrincipal
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
            groupBoxPolitica = new GroupBox();
            labelCantidadPedido = new Label();
            labelTipoPolitica = new Label();
            comboBoxPolitica = new ComboBox();
            textBoxCantPedido = new TextBox();
            groupBoxDemanda = new GroupBox();
            dataGridViewDemanda = new DataGridView();
            groupBoxDemora = new GroupBox();
            dataGridViewDemora = new DataGridView();
            groupBoxCosto = new GroupBox();
            dataGridViewCosto = new DataGridView();
            label3 = new Label();
            groupBoxParametros = new GroupBox();
            labelCantMostrar = new Label();
            textBoxCantDias = new TextBox();
            textBoxCantAMostrar = new TextBox();
            textBoxMostrarDesde = new TextBox();
            labelMostrar = new Label();
            label1 = new Label();
            buttonSimular = new Button();
            groupBoxPolitica.SuspendLayout();
            groupBoxDemanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDemanda).BeginInit();
            groupBoxDemora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDemora).BeginInit();
            groupBoxCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCosto).BeginInit();
            groupBoxParametros.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPolitica
            // 
            groupBoxPolitica.Controls.Add(labelCantidadPedido);
            groupBoxPolitica.Controls.Add(labelTipoPolitica);
            groupBoxPolitica.Controls.Add(comboBoxPolitica);
            groupBoxPolitica.Controls.Add(textBoxCantPedido);
            groupBoxPolitica.Location = new Point(18, 66);
            groupBoxPolitica.Name = "groupBoxPolitica";
            groupBoxPolitica.Size = new Size(276, 144);
            groupBoxPolitica.TabIndex = 0;
            groupBoxPolitica.TabStop = false;
            groupBoxPolitica.Text = "Politica";
            // 
            // labelCantidadPedido
            // 
            labelCantidadPedido.AutoSize = true;
            labelCantidadPedido.Location = new Point(6, 73);
            labelCantidadPedido.Name = "labelCantidadPedido";
            labelCantidadPedido.Size = new Size(139, 20);
            labelCantidadPedido.TabIndex = 1;
            labelCantidadPedido.Text = "Cantidad (Decenas)";
            // 
            // labelTipoPolitica
            // 
            labelTipoPolitica.AutoSize = true;
            labelTipoPolitica.Location = new Point(6, 32);
            labelTipoPolitica.Name = "labelTipoPolitica";
            labelTipoPolitica.Size = new Size(93, 20);
            labelTipoPolitica.TabIndex = 3;
            labelTipoPolitica.Text = "Tipo política";
            // 
            // comboBoxPolitica
            // 
            comboBoxPolitica.FormattingEnabled = true;
            comboBoxPolitica.Location = new Point(154, 29);
            comboBoxPolitica.Name = "comboBoxPolitica";
            comboBoxPolitica.Size = new Size(116, 28);
            comboBoxPolitica.TabIndex = 2;
            comboBoxPolitica.SelectedIndexChanged += comboBoxPolitica_SelectedIndexChanged;
            // 
            // textBoxCantPedido
            // 
            textBoxCantPedido.Location = new Point(154, 70);
            textBoxCantPedido.Name = "textBoxCantPedido";
            textBoxCantPedido.Size = new Size(116, 27);
            textBoxCantPedido.TabIndex = 1;
            // 
            // groupBoxDemanda
            // 
            groupBoxDemanda.Controls.Add(dataGridViewDemanda);
            groupBoxDemanda.Location = new Point(18, 216);
            groupBoxDemanda.Name = "groupBoxDemanda";
            groupBoxDemanda.Size = new Size(757, 150);
            groupBoxDemanda.TabIndex = 1;
            groupBoxDemanda.TabStop = false;
            groupBoxDemanda.Text = "Demanda";
            // 
            // dataGridViewDemanda
            // 
            dataGridViewDemanda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDemanda.Location = new Point(6, 26);
            dataGridViewDemanda.Name = "dataGridViewDemanda";
            dataGridViewDemanda.RowHeadersWidth = 51;
            dataGridViewDemanda.RowTemplate.Height = 29;
            dataGridViewDemanda.Size = new Size(745, 118);
            dataGridViewDemanda.TabIndex = 2;
            // 
            // groupBoxDemora
            // 
            groupBoxDemora.Controls.Add(dataGridViewDemora);
            groupBoxDemora.Location = new Point(18, 372);
            groupBoxDemora.Name = "groupBoxDemora";
            groupBoxDemora.Size = new Size(757, 150);
            groupBoxDemora.TabIndex = 3;
            groupBoxDemora.TabStop = false;
            groupBoxDemora.Text = "Demora";
            // 
            // dataGridViewDemora
            // 
            dataGridViewDemora.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewDemora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDemora.Location = new Point(6, 24);
            dataGridViewDemora.Name = "dataGridViewDemora";
            dataGridViewDemora.RowHeadersWidth = 51;
            dataGridViewDemora.RowTemplate.Height = 29;
            dataGridViewDemora.Size = new Size(745, 118);
            dataGridViewDemora.TabIndex = 2;
            // 
            // groupBoxCosto
            // 
            groupBoxCosto.Controls.Add(dataGridViewCosto);
            groupBoxCosto.Location = new Point(18, 528);
            groupBoxCosto.Name = "groupBoxCosto";
            groupBoxCosto.Size = new Size(757, 150);
            groupBoxCosto.TabIndex = 4;
            groupBoxCosto.TabStop = false;
            groupBoxCosto.Text = "Costo";
            // 
            // dataGridViewCosto
            // 
            dataGridViewCosto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCosto.Location = new Point(6, 24);
            dataGridViewCosto.Name = "dataGridViewCosto";
            dataGridViewCosto.RowHeadersWidth = 51;
            dataGridViewCosto.RowTemplate.Height = 29;
            dataGridViewCosto.Size = new Size(745, 118);
            dataGridViewCosto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(554, 54);
            label3.TabIndex = 5;
            label3.Text = "Simulacion Dos Políticas Stock";
            // 
            // groupBoxParametros
            // 
            groupBoxParametros.Controls.Add(labelCantMostrar);
            groupBoxParametros.Controls.Add(textBoxCantDias);
            groupBoxParametros.Controls.Add(textBoxCantAMostrar);
            groupBoxParametros.Controls.Add(textBoxMostrarDesde);
            groupBoxParametros.Controls.Add(labelMostrar);
            groupBoxParametros.Controls.Add(label1);
            groupBoxParametros.Location = new Point(300, 66);
            groupBoxParametros.Name = "groupBoxParametros";
            groupBoxParametros.Size = new Size(272, 144);
            groupBoxParametros.TabIndex = 6;
            groupBoxParametros.TabStop = false;
            groupBoxParametros.Text = "Parametros Simulacion";
            // 
            // labelCantMostrar
            // 
            labelCantMostrar.AutoSize = true;
            labelCantMostrar.Location = new Point(16, 106);
            labelCantMostrar.Name = "labelCantMostrar";
            labelCantMostrar.Size = new Size(136, 20);
            labelCantMostrar.TabIndex = 5;
            labelCantMostrar.Text = "Cantidad a mostrar";
            // 
            // textBoxCantDias
            // 
            textBoxCantDias.Location = new Point(173, 34);
            textBoxCantDias.Name = "textBoxCantDias";
            textBoxCantDias.Size = new Size(74, 27);
            textBoxCantDias.TabIndex = 4;
            // 
            // textBoxCantAMostrar
            // 
            textBoxCantAMostrar.Location = new Point(173, 106);
            textBoxCantAMostrar.Name = "textBoxCantAMostrar";
            textBoxCantAMostrar.Size = new Size(74, 27);
            textBoxCantAMostrar.TabIndex = 3;
            // 
            // textBoxMostrarDesde
            // 
            textBoxMostrarDesde.Location = new Point(173, 70);
            textBoxMostrarDesde.Name = "textBoxMostrarDesde";
            textBoxMostrarDesde.Size = new Size(74, 27);
            textBoxMostrarDesde.TabIndex = 2;
            // 
            // labelMostrar
            // 
            labelMostrar.AutoSize = true;
            labelMostrar.Location = new Point(16, 73);
            labelMostrar.Name = "labelMostrar";
            labelMostrar.Size = new Size(104, 20);
            labelMostrar.TabIndex = 1;
            labelMostrar.Text = "Mostrar desde";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad Días";
            // 
            // buttonSimular
            // 
            buttonSimular.Location = new Point(664, 107);
            buttonSimular.Name = "buttonSimular";
            buttonSimular.Size = new Size(105, 56);
            buttonSimular.TabIndex = 7;
            buttonSimular.Text = "MATRIX";
            buttonSimular.UseVisualStyleBackColor = true;
            buttonSimular.Click += buttonSimular_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 692);
            Controls.Add(buttonSimular);
            Controls.Add(groupBoxParametros);
            Controls.Add(label3);
            Controls.Add(groupBoxCosto);
            Controls.Add(groupBoxDemora);
            Controls.Add(groupBoxDemanda);
            Controls.Add(groupBoxPolitica);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_onLoad;
            groupBoxPolitica.ResumeLayout(false);
            groupBoxPolitica.PerformLayout();
            groupBoxDemanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDemanda).EndInit();
            groupBoxDemora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDemora).EndInit();
            groupBoxCosto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCosto).EndInit();
            groupBoxParametros.ResumeLayout(false);
            groupBoxParametros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPolitica;
        private Label labelCantidadPedido;
        private Label labelTipoPolitica;
        private ComboBox comboBoxPolitica;
        private TextBox textBoxCantPedido;
        private GroupBox groupBoxDemanda;
        private DataGridView dataGridViewDemanda;
        private GroupBox groupBoxDemora;
        private DataGridView dataGridViewDemora;
        private GroupBox groupBoxCosto;
        private DataGridView dataGridViewCosto;
        private Label label3;
        private GroupBox groupBoxParametros;
        private Label label1;
        private Label labelCantMostrar;
        private TextBox textBoxCantDias;
        private TextBox textBoxCantAMostrar;
        private TextBox textBoxMostrarDesde;
        private Label labelMostrar;
        private Button buttonSimular;
        private DataGridView dataGridViewDemandaProbAC;
    }
}