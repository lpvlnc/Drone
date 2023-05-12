namespace Arduino
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
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusDescription = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.Enabled = false;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.IntegralHeight = false;
            this.comboBoxCOM.Location = new System.Drawing.Point(172, 14);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCOM.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCOM.TabIndex = 0;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Enabled = false;
            this.trackBarSpeed.Location = new System.Drawing.Point(12, 83);
            this.trackBarSpeed.Maximum = 2000;
            this.trackBarSpeed.Minimum = 1000;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(300, 45);
            this.trackBarSpeed.TabIndex = 1;
            this.trackBarSpeed.Value = 1000;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            this.trackBarSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSpeed_MouseUp);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Encontrar dispositivos";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Location = new System.Drawing.Point(12, 41);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(300, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Conectar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 67);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusDescription
            // 
            this.labelStatusDescription.AutoSize = true;
            this.labelStatusDescription.ForeColor = System.Drawing.Color.Red;
            this.labelStatusDescription.Location = new System.Drawing.Point(58, 67);
            this.labelStatusDescription.Name = "labelStatusDescription";
            this.labelStatusDescription.Size = new System.Drawing.Size(77, 13);
            this.labelStatusDescription.TabIndex = 6;
            this.labelStatusDescription.Text = "Desconectado";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 115);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(63, 13);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Velocidade:";
            // 
            // labelSpeedDescription
            // 
            this.labelSpeedDescription.AutoSize = true;
            this.labelSpeedDescription.Location = new System.Drawing.Point(81, 115);
            this.labelSpeedDescription.Name = "labelSpeedDescription";
            this.labelSpeedDescription.Size = new System.Drawing.Size(31, 13);
            this.labelSpeedDescription.TabIndex = 8;
            this.labelSpeedDescription.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 138);
            this.Controls.Add(this.labelSpeedDescription);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelStatusDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.comboBoxCOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusDescription;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedDescription;
    }
}

