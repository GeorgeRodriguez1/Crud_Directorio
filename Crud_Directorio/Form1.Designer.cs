namespace Crud_Directorio
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.cardId = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.currentPosition = new System.Windows.Forms.TextBox();
            this.officeNumber = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Empleados ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre y Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono Empresarial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 452);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cargo Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de Oficina ";
            // 
            // profileImage
            // 
            this.profileImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileImage.Location = new System.Drawing.Point(902, 18);
            this.profileImage.Margin = new System.Windows.Forms.Padding(4);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(297, 292);
            this.profileImage.TabIndex = 6;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.profileImage_Click);
            // 
            // cardId
            // 
            this.cardId.Location = new System.Drawing.Point(572, 198);
            this.cardId.Margin = new System.Windows.Forms.Padding(4);
            this.cardId.Name = "cardId";
            this.cardId.Size = new System.Drawing.Size(309, 29);
            this.cardId.TabIndex = 7;
            this.cardId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardId_KeyPress);
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(572, 284);
            this.fullName.Margin = new System.Windows.Forms.Padding(4);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(309, 29);
            this.fullName.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(572, 363);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(309, 29);
            this.phone.TabIndex = 9;
            // 
            // currentPosition
            // 
            this.currentPosition.Location = new System.Drawing.Point(572, 452);
            this.currentPosition.Margin = new System.Windows.Forms.Padding(4);
            this.currentPosition.Name = "currentPosition";
            this.currentPosition.Size = new System.Drawing.Size(309, 29);
            this.currentPosition.TabIndex = 10;
            // 
            // officeNumber
            // 
            this.officeNumber.Location = new System.Drawing.Point(572, 532);
            this.officeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.officeNumber.Name = "officeNumber";
            this.officeNumber.Size = new System.Drawing.Size(309, 29);
            this.officeNumber.TabIndex = 11;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.save.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(212, 648);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 48);
            this.save.TabIndex = 12;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.delete.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(417, 648);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 48);
            this.delete.TabIndex = 13;
            this.delete.Text = "Borrar";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(646, 648);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 48);
            this.clear.TabIndex = 14;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.update.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(866, 648);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(180, 48);
            this.update.TabIndex = 15;
            this.update.Text = "Actualizar";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1231, 770);
            this.Controls.Add(this.update);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.officeNumber);
            this.Controls.Add(this.currentPosition);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.cardId);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Directorio ";
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
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
        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.TextBox cardId;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox currentPosition;
        private System.Windows.Forms.TextBox officeNumber;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
    }
}

