namespace test_DataBase
{
    partial class AddFormSoftwareInstallation
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxLicenseKey = new System.Windows.Forms.TextBox();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxInstallationDate = new System.Windows.Forms.TextBox();
            this.textBoxTechnicianIDSoftwareInstallation = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxClientIDSoftwareInstallation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Установка ПО";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(309, 15);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(267, 40);
            this.labelTitle.TabIndex = 37;
            this.labelTitle.Text = "Создание записи:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(422, 1018);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(303, 86);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(193, 790);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 20);
            this.label21.TabIndex = 51;
            this.label21.Text = "Лицензионный ключ:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(246, 730);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 20);
            this.label29.TabIndex = 50;
            this.label29.Text = "Название ПО:";
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLicenseKey.Location = new System.Drawing.Point(369, 771);
            this.textBoxLicenseKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.Size = new System.Drawing.Size(584, 45);
            this.textBoxLicenseKey.TabIndex = 49;
            // 
            // textBoxSoftwareName
            // 
            this.textBoxSoftwareName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSoftwareName.Location = new System.Drawing.Point(369, 711);
            this.textBoxSoftwareName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSoftwareName.Name = "textBoxSoftwareName";
            this.textBoxSoftwareName.Size = new System.Drawing.Size(584, 45);
            this.textBoxSoftwareName.TabIndex = 48;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(228, 675);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 20);
            this.label27.TabIndex = 47;
            this.label27.Text = "Дата установки:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(234, 620);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(127, 20);
            this.label28.TabIndex = 46;
            this.label28.Text = "Номер техника:";
            // 
            // textBoxInstallationDate
            // 
            this.textBoxInstallationDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstallationDate.Location = new System.Drawing.Point(369, 656);
            this.textBoxInstallationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInstallationDate.Name = "textBoxInstallationDate";
            this.textBoxInstallationDate.Size = new System.Drawing.Size(584, 45);
            this.textBoxInstallationDate.TabIndex = 45;
            // 
            // textBoxTechnicianIDSoftwareInstallation
            // 
            this.textBoxTechnicianIDSoftwareInstallation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTechnicianIDSoftwareInstallation.Location = new System.Drawing.Point(369, 601);
            this.textBoxTechnicianIDSoftwareInstallation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTechnicianIDSoftwareInstallation.Name = "textBoxTechnicianIDSoftwareInstallation";
            this.textBoxTechnicianIDSoftwareInstallation.Size = new System.Drawing.Size(584, 45);
            this.textBoxTechnicianIDSoftwareInstallation.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 565);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Номер клиента:";
            // 
            // textBoxClientIDSoftwareInstallation
            // 
            this.textBoxClientIDSoftwareInstallation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientIDSoftwareInstallation.Location = new System.Drawing.Point(369, 546);
            this.textBoxClientIDSoftwareInstallation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxClientIDSoftwareInstallation.Name = "textBoxClientIDSoftwareInstallation";
            this.textBoxClientIDSoftwareInstallation.Size = new System.Drawing.Size(584, 45);
            this.textBoxClientIDSoftwareInstallation.TabIndex = 42;
            // 
            // AddFormSoftwareInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 1122);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.textBoxLicenseKey);
            this.Controls.Add(this.textBoxSoftwareName);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.textBoxInstallationDate);
            this.Controls.Add(this.textBoxTechnicianIDSoftwareInstallation);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxClientIDSoftwareInstallation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFormSoftwareInstallation";
            this.Text = "Добавить установку ПО";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxLicenseKey;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxInstallationDate;
        private System.Windows.Forms.TextBox textBoxTechnicianIDSoftwareInstallation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxClientIDSoftwareInstallation;
    }
}