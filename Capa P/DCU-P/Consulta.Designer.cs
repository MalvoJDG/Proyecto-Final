namespace Capa_P.DCU_P
{
    partial class Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dtaConsulta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(59, 106);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(364, 22);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dtaConsulta
            // 
            this.dtaConsulta.AllowUserToAddRows = false;
            this.dtaConsulta.AllowUserToDeleteRows = false;
            this.dtaConsulta.AllowUserToOrderColumns = true;
            this.dtaConsulta.AllowUserToResizeColumns = false;
            this.dtaConsulta.AllowUserToResizeRows = false;
            this.dtaConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dtaConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaConsulta.ColumnHeadersHeight = 29;
            this.dtaConsulta.Location = new System.Drawing.Point(59, 146);
            this.dtaConsulta.Name = "dtaConsulta";
            this.dtaConsulta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaConsulta.RowHeadersVisible = false;
            this.dtaConsulta.RowHeadersWidth = 51;
            this.dtaConsulta.RowTemplate.Height = 24;
            this.dtaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaConsulta.Size = new System.Drawing.Size(1153, 378);
            this.dtaConsulta.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 82);
            this.panel1.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 5;
            this.btnBack.ButtonText = "Volver";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(-7, 540);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Red;
            this.btnBack.OnHovercolor = System.Drawing.Color.Red;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(158, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Volver";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1043, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(939, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Papolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(1123, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cerrar Sesion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 5;
            this.btnGuardar.ButtonText = "Nueva Consulta";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = null;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(736, 15);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(118)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(118)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(161, 50);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Nueva Consulta";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 576);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtaConsulta);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consulta_FormClosed);
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dtaConsulta;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}