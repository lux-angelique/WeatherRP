
namespace MyWeatherApp
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lciti = new System.Windows.Forms.Label();
            this.lTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Город";
            // 
            // Lciti
            // 
            this.Lciti.AutoSize = true;
            this.Lciti.Font = new System.Drawing.Font("Arial Narrow", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lciti.Location = new System.Drawing.Point(286, 62);
            this.Lciti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lciti.Name = "Lciti";
            this.Lciti.Size = new System.Drawing.Size(52, 23);
            this.Lciti.TabIndex = 10;
            this.Lciti.Text = "label4";
            // 
            // lTemp
            // 
            this.lTemp.AutoSize = true;
            this.lTemp.Font = new System.Drawing.Font("Arial Narrow", 13.84615F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTemp.Location = new System.Drawing.Point(286, 115);
            this.lTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTemp.Name = "lTemp";
            this.lTemp.Size = new System.Drawing.Size(52, 23);
            this.lTemp.TabIndex = 4;
            this.lTemp.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyWeatherApp.Properties.Resources._03d;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lciti);
            this.Controls.Add(this.lTemp);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Погода от Панченко";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lciti;
        private System.Windows.Forms.Label lTemp;
    }
}

