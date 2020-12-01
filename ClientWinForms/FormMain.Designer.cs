namespace ClientWinForms
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewWeatherData = new System.Windows.Forms.DataGridView();
            this.buttonGetWeatherData = new System.Windows.Forms.Button();
            this.buttonGetByName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddCityName = new System.Windows.Forms.TextBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.textBoxDeleteByName = new System.Windows.Forms.TextBox();
            this.buttonDeleteByName = new System.Windows.Forms.Button();
            this.textBoxAddCityTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGiveException = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeatherData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWeatherData
            // 
            this.dataGridViewWeatherData.AllowUserToAddRows = false;
            this.dataGridViewWeatherData.AllowUserToDeleteRows = false;
            this.dataGridViewWeatherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeatherData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWeatherData.Name = "dataGridViewWeatherData";
            this.dataGridViewWeatherData.ReadOnly = true;
            this.dataGridViewWeatherData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWeatherData.Size = new System.Drawing.Size(391, 351);
            this.dataGridViewWeatherData.TabIndex = 0;
            this.dataGridViewWeatherData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWeatherData_CellClick);
            this.dataGridViewWeatherData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWeatherData_CellContentClick);
            // 
            // buttonGetWeatherData
            // 
            this.buttonGetWeatherData.Location = new System.Drawing.Point(95, 369);
            this.buttonGetWeatherData.Name = "buttonGetWeatherData";
            this.buttonGetWeatherData.Size = new System.Drawing.Size(240, 23);
            this.buttonGetWeatherData.TabIndex = 1;
            this.buttonGetWeatherData.Text = "GetWeatherData";
            this.buttonGetWeatherData.UseVisualStyleBackColor = true;
            this.buttonGetWeatherData.Click += new System.EventHandler(this.buttonGetWeatherData_Click);
            // 
            // buttonGetByName
            // 
            this.buttonGetByName.Location = new System.Drawing.Point(413, 34);
            this.buttonGetByName.Name = "buttonGetByName";
            this.buttonGetByName.Size = new System.Drawing.Size(225, 23);
            this.buttonGetByName.TabIndex = 2;
            this.buttonGetByName.Text = "GetByName";
            this.buttonGetByName.UseVisualStyleBackColor = true;
            this.buttonGetByName.Click += new System.EventHandler(this.buttonGetByName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(413, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxAddCityName
            // 
            this.textBoxAddCityName.Location = new System.Drawing.Point(409, 106);
            this.textBoxAddCityName.Name = "textBoxAddCityName";
            this.textBoxAddCityName.Size = new System.Drawing.Size(225, 20);
            this.textBoxAddCityName.TabIndex = 5;
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(409, 165);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(225, 23);
            this.buttonAddCity.TabIndex = 4;
            this.buttonAddCity.Text = "AddCity";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // textBoxDeleteByName
            // 
            this.textBoxDeleteByName.Location = new System.Drawing.Point(409, 249);
            this.textBoxDeleteByName.Name = "textBoxDeleteByName";
            this.textBoxDeleteByName.Size = new System.Drawing.Size(225, 20);
            this.textBoxDeleteByName.TabIndex = 7;
            // 
            // buttonDeleteByName
            // 
            this.buttonDeleteByName.Location = new System.Drawing.Point(409, 271);
            this.buttonDeleteByName.Name = "buttonDeleteByName";
            this.buttonDeleteByName.Size = new System.Drawing.Size(225, 23);
            this.buttonDeleteByName.TabIndex = 6;
            this.buttonDeleteByName.Text = "DeleteByName";
            this.buttonDeleteByName.UseVisualStyleBackColor = true;
            this.buttonDeleteByName.Click += new System.EventHandler(this.buttonDeleteByName_Click);
            // 
            // textBoxAddCityTemperature
            // 
            this.textBoxAddCityTemperature.Location = new System.Drawing.Point(409, 145);
            this.textBoxAddCityTemperature.Name = "textBoxAddCityTemperature";
            this.textBoxAddCityTemperature.Size = new System.Drawing.Size(225, 20);
            this.textBoxAddCityTemperature.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temperature";
            // 
            // buttonGiveException
            // 
            this.buttonGiveException.Location = new System.Drawing.Point(191, 413);
            this.buttonGiveException.Name = "buttonGiveException";
            this.buttonGiveException.Size = new System.Drawing.Size(240, 165);
            this.buttonGiveException.TabIndex = 11;
            this.buttonGiveException.Text = "GiveException";
            this.buttonGiveException.UseVisualStyleBackColor = true;
            this.buttonGiveException.Click += new System.EventHandler(this.buttonGiveException_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 590);
            this.Controls.Add(this.buttonGiveException);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddCityTemperature);
            this.Controls.Add(this.textBoxDeleteByName);
            this.Controls.Add(this.buttonDeleteByName);
            this.Controls.Add(this.textBoxAddCityName);
            this.Controls.Add(this.buttonAddCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonGetByName);
            this.Controls.Add(this.buttonGetWeatherData);
            this.Controls.Add(this.dataGridViewWeatherData);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeatherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWeatherData;
        private System.Windows.Forms.Button buttonGetWeatherData;
        private System.Windows.Forms.Button buttonGetByName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddCityName;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.TextBox textBoxDeleteByName;
        private System.Windows.Forms.Button buttonDeleteByName;
        private System.Windows.Forms.TextBox textBoxAddCityTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGiveException;
    }
}

