namespace bibliotecasql
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtgenerol = new System.Windows.Forms.TextBox();
            this.btnAddLivro = new System.Windows.Forms.Button();
            this.btnUpdateLivro = new System.Windows.Forms.Button();
            this.btnDeleteLivro = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.btnDeleteImagem = new System.Windows.Forms.Button();
            this.btnGravaImagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvlivro = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlivro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Num Pág.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género";
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(103, 45);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(103, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(103, 135);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txteditora
            // 
            this.txteditora.Location = new System.Drawing.Point(103, 180);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(100, 20);
            this.txteditora.TabIndex = 9;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(103, 225);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 10;
            // 
            // txtgenerol
            // 
            this.txtgenerol.Location = new System.Drawing.Point(103, 270);
            this.txtgenerol.Name = "txtgenerol";
            this.txtgenerol.Size = new System.Drawing.Size(100, 20);
            this.txtgenerol.TabIndex = 11;
            // 
            // btnAddLivro
            // 
            this.btnAddLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLivro.BackgroundImage")));
            this.btnAddLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLivro.Location = new System.Drawing.Point(232, 35);
            this.btnAddLivro.Name = "btnAddLivro";
            this.btnAddLivro.Size = new System.Drawing.Size(143, 40);
            this.btnAddLivro.TabIndex = 12;
            this.btnAddLivro.UseVisualStyleBackColor = true;
            this.btnAddLivro.Click += new System.EventHandler(this.btnAddLivro_Click);
            // 
            // btnUpdateLivro
            // 
            this.btnUpdateLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateLivro.BackgroundImage")));
            this.btnUpdateLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateLivro.Location = new System.Drawing.Point(232, 81);
            this.btnUpdateLivro.Name = "btnUpdateLivro";
            this.btnUpdateLivro.Size = new System.Drawing.Size(143, 40);
            this.btnUpdateLivro.TabIndex = 13;
            this.btnUpdateLivro.UseVisualStyleBackColor = true;
            this.btnUpdateLivro.Click += new System.EventHandler(this.btnUpdateLivro_Click);
            // 
            // btnDeleteLivro
            // 
            this.btnDeleteLivro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteLivro.BackgroundImage")));
            this.btnDeleteLivro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteLivro.Location = new System.Drawing.Point(232, 127);
            this.btnDeleteLivro.Name = "btnDeleteLivro";
            this.btnDeleteLivro.Size = new System.Drawing.Size(143, 40);
            this.btnDeleteLivro.TabIndex = 14;
            this.btnDeleteLivro.UseVisualStyleBackColor = true;
            this.btnDeleteLivro.Click += new System.EventHandler(this.btnDeleteLivro_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(232, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 40);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddImagem.BackgroundImage")));
            this.btnAddImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddImagem.Location = new System.Drawing.Point(231, 289);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(44, 43);
            this.btnAddImagem.TabIndex = 16;
            this.btnAddImagem.UseVisualStyleBackColor = true;
            this.btnAddImagem.Click += new System.EventHandler(this.btnAddImagem_Click);
            // 
            // btnDeleteImagem
            // 
            this.btnDeleteImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteImagem.BackgroundImage")));
            this.btnDeleteImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteImagem.Location = new System.Drawing.Point(281, 289);
            this.btnDeleteImagem.Name = "btnDeleteImagem";
            this.btnDeleteImagem.Size = new System.Drawing.Size(44, 43);
            this.btnDeleteImagem.TabIndex = 17;
            this.btnDeleteImagem.UseVisualStyleBackColor = true;
            this.btnDeleteImagem.Click += new System.EventHandler(this.btnDeleteImagem_Click);
            // 
            // btnGravaImagem
            // 
            this.btnGravaImagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGravaImagem.BackgroundImage")));
            this.btnGravaImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGravaImagem.Location = new System.Drawing.Point(331, 289);
            this.btnGravaImagem.Name = "btnGravaImagem";
            this.btnGravaImagem.Size = new System.Drawing.Size(44, 43);
            this.btnGravaImagem.TabIndex = 18;
            this.btnGravaImagem.UseVisualStyleBackColor = true;
            this.btnGravaImagem.Click += new System.EventHandler(this.btnGravaImagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(231, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 64);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dgvlivro
            // 
            this.dgvlivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlivro.Location = new System.Drawing.Point(398, 35);
            this.dgvlivro.Name = "dgvlivro";
            this.dgvlivro.Size = new System.Drawing.Size(305, 248);
            this.dgvlivro.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(659, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 43);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 366);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvlivro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGravaImagem);
            this.Controls.Add(this.btnDeleteImagem);
            this.Controls.Add(this.btnAddImagem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeleteLivro);
            this.Controls.Add(this.btnUpdateLivro);
            this.Controls.Add(this.btnAddLivro);
            this.Controls.Add(this.txtgenerol);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txteditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtgenerol;
        private System.Windows.Forms.Button btnAddLivro;
        private System.Windows.Forms.Button btnUpdateLivro;
        private System.Windows.Forms.Button btnDeleteLivro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddImagem;
        private System.Windows.Forms.Button btnDeleteImagem;
        private System.Windows.Forms.Button btnGravaImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvlivro;
        private System.Windows.Forms.Button btnRefresh;
    }
}