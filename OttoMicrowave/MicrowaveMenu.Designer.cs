namespace OttoMicrowave
{
    partial class MicrowaveMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicrowaveMenu));
            this.inputTime = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.turnOn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.inputPower = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.listQuickModes = new System.Windows.Forms.ListBox();
            this.labelOutPut = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelQuickMode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTime
            // 
            this.inputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTime.Location = new System.Drawing.Point(446, 38);
            this.inputTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputTime.Name = "inputTime";
            this.inputTime.Size = new System.Drawing.Size(284, 26);
            this.inputTime.TabIndex = 1;
            this.inputTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Insira o tempo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // turnOn
            // 
            this.turnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOn.Location = new System.Drawing.Point(56, 253);
            this.turnOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turnOn.Name = "turnOn";
            this.turnOn.Size = new System.Drawing.Size(124, 33);
            this.turnOn.TabIndex = 4;
            this.turnOn.Text = "Ligar / +30sec";
            this.turnOn.UseVisualStyleBackColor = true;
            this.turnOn.Click += new System.EventHandler(this.turnOn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(208, 253);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Pause / Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCad
            // 
            this.btnCad.AutoEllipsis = true;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Location = new System.Drawing.Point(446, 403);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(133, 33);
            this.btnCad.TabIndex = 8;
            this.btnCad.Text = "Cad. QuickMode";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoEllipsis = true;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(592, 403);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete QuickMode";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-2, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Direitos reservados: Leonardo Rizick @ 2023";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // inputPower
            // 
            this.inputPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPower.Location = new System.Drawing.Point(446, 108);
            this.inputPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPower.Name = "inputPower";
            this.inputPower.Size = new System.Drawing.Size(284, 26);
            this.inputPower.TabIndex = 11;
            this.inputPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNumber_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Insira a potencia: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(291, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelPower);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(294, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 61);
            this.panel1.TabIndex = 14;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPower.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(15, 35);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(18, 19);
            this.labelPower.TabIndex = 16;
            this.labelPower.Text = "1";
            this.labelPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Lime;
            this.labelTime.Location = new System.Drawing.Point(3, 6);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 19);
            this.labelTime.TabIndex = 15;
            this.labelTime.Text = "00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listQuickModes
            // 
            this.listQuickModes.FormattingEnabled = true;
            this.listQuickModes.Location = new System.Drawing.Point(446, 168);
            this.listQuickModes.Name = "listQuickModes";
            this.listQuickModes.Size = new System.Drawing.Size(284, 212);
            this.listQuickModes.TabIndex = 16;
            this.listQuickModes.Click += new System.EventHandler(this.listQuickModes_Click);
            this.listQuickModes.DoubleClick += new System.EventHandler(this.listQuickModes_DoubleClick);
            // 
            // labelOutPut
            // 
            this.labelOutPut.AutoSize = true;
            this.labelOutPut.Location = new System.Drawing.Point(53, 318);
            this.labelOutPut.MaximumSize = new System.Drawing.Size(300, 350);
            this.labelOutPut.Name = "labelOutPut";
            this.labelOutPut.Size = new System.Drawing.Size(41, 13);
            this.labelOutPut.TabIndex = 17;
            this.labelOutPut.Text = "label13";
            this.labelOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelQuickMode
            // 
            this.labelQuickMode.AutoSize = true;
            this.labelQuickMode.Location = new System.Drawing.Point(125, 38);
            this.labelQuickMode.Name = "labelQuickMode";
            this.labelQuickMode.Size = new System.Drawing.Size(41, 13);
            this.labelQuickMode.TabIndex = 19;
            this.labelQuickMode.Text = "label13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Duplo clique para editar programas";
            // 
            // MicrowaveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 449);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelQuickMode);
            this.Controls.Add(this.labelOutPut);
            this.Controls.Add(this.listQuickModes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inputPower);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.turnOn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputTime);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MicrowaveMenu";
            this.Text = "Microwave";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button turnOn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputPower;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ListBox listQuickModes;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelOutPut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelQuickMode;
        private System.Windows.Forms.Label label13;
    }
}

