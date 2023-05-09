namespace _2PoliticasStock
{
    partial class FormTablaSimulacion
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
            dataGridViewSimulacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSimulacion).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSimulacion
            // 
            dataGridViewSimulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSimulacion.Location = new Point(4, 3);
            dataGridViewSimulacion.Name = "dataGridViewSimulacion";
            dataGridViewSimulacion.RowHeadersWidth = 51;
            dataGridViewSimulacion.RowTemplate.Height = 29;
            dataGridViewSimulacion.Size = new Size(1388, 775);
            dataGridViewSimulacion.TabIndex = 0;
            // 
            // FormTablaSimulacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 779);
            Controls.Add(dataGridViewSimulacion);
            Name = "FormTablaSimulacion";
            Text = "TablaSimulacion";
            Load += FormTablaSimulacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSimulacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridViewSimulacion;
    }
}