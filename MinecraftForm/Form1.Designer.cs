namespace MinecraftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxNivel = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFecha = new TextBox();
            buttonCrear = new Button();
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            dataGridView1 = new DataGridView();
            buttonBuscarinventario = new Button();
            comboBoxRareza = new ComboBox();
            comboBoxTipo = new ComboBox();
            button1 = new Button();
            pictureBoxImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ControlDark;
            buttonBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(52, 13);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(86, 31);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(34, 80);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = SystemColors.InactiveCaption;
            textBoxId.Location = new Point(171, 77);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(114, 27);
            textBoxId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(34, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.InactiveCaption;
            textBoxNombre.Location = new Point(171, 112);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(114, 27);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxNivel
            // 
            textBoxNivel.BackColor = SystemColors.InactiveCaption;
            textBoxNivel.Location = new Point(171, 147);
            textBoxNivel.Margin = new Padding(3, 4, 3, 4);
            textBoxNivel.Name = "textBoxNivel";
            textBoxNivel.Size = new Size(114, 27);
            textBoxNivel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(34, 150);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Nivel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(34, 185);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de creacion:";
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.InactiveCaption;
            textBoxFecha.Location = new Point(171, 182);
            textBoxFecha.Margin = new Padding(3, 4, 3, 4);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(151, 27);
            textBoxFecha.TabIndex = 8;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = SystemColors.ControlDark;
            buttonCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCrear.Location = new Point(144, 13);
            buttonCrear.Margin = new Padding(3, 4, 3, 4);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(102, 31);
            buttonCrear.TabIndex = 9;
            buttonCrear.Text = "Crear Jugador";
            buttonCrear.UseVisualStyleBackColor = false;
            buttonCrear.Click += buttonCrear_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = SystemColors.ControlDark;
            buttonEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonEliminar.Location = new Point(258, 13);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(141, 31);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar Jugador";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = SystemColors.ControlDark;
            buttonActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonActualizar.Location = new Point(405, 13);
            buttonActualizar.Margin = new Padding(3, 4, 3, 4);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(152, 31);
            buttonActualizar.TabIndex = 11;
            buttonActualizar.Text = "Actualizar Jugador";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 96);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(588, 273);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonBuscarinventario
            // 
            buttonBuscarinventario.BackColor = Color.DarkGray;
            buttonBuscarinventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonBuscarinventario.Location = new Point(644, 377);
            buttonBuscarinventario.Margin = new Padding(3, 4, 3, 4);
            buttonBuscarinventario.Name = "buttonBuscarinventario";
            buttonBuscarinventario.Size = new Size(197, 31);
            buttonBuscarinventario.TabIndex = 13;
            buttonBuscarinventario.Text = "Buscar Inventario por ID";
            buttonBuscarinventario.UseVisualStyleBackColor = false;
            buttonBuscarinventario.Click += buttonBuscarinventario_Click;
            // 
            // comboBoxRareza
            // 
            comboBoxRareza.BackColor = SystemColors.InactiveCaption;
            comboBoxRareza.FormattingEnabled = true;
            comboBoxRareza.Location = new Point(765, 57);
            comboBoxRareza.Margin = new Padding(3, 4, 3, 4);
            comboBoxRareza.Name = "comboBoxRareza";
            comboBoxRareza.Size = new Size(138, 28);
            comboBoxRareza.TabIndex = 15;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = SystemColors.InactiveCaption;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(587, 57);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 28);
            comboBoxTipo.TabIndex = 16;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(616, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(246, 31);
            button1.TabIndex = 20;
            button1.Text = "Seleccione la opcion que deseas";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Transparent;
            pictureBoxImagen.Location = new Point(311, 244);
            pictureBoxImagen.Margin = new Padding(3, 4, 3, 4);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(122, 125);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 21;
            pictureBoxImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1056, 499);
            Controls.Add(pictureBoxImagen);
            Controls.Add(button1);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxRareza);
            Controls.Add(buttonBuscarinventario);
            Controls.Add(dataGridView1);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCrear);
            Controls.Add(textBoxFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxNivel);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxNivel;
        private Label label3;
        private Label label4;
        private TextBox textBoxFecha;
        private Button button2;
        private Button buttonBuscar;
        private Button buttonCrear;
        private Button buttonEliminar;
        private Button buttonActualizar;
        private DataGridView dataGridView1;
        private Button buttonBuscarinventario;
        private ComboBox comboBoxRareza;
        private ComboBox comboBoxTipo;
        private PictureBox pictureBoxImagen;
    }
}
