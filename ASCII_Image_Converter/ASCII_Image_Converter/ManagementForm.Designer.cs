
namespace ASCII_Image_Converter
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxWight = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonСhoice = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(34, 258);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(340, 100);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Переглянути готове зображення на консолі";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxWight
            // 
            this.textBoxWight.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWight.Location = new System.Drawing.Point(340, 134);
            this.textBoxWight.MaxLength = 5;
            this.textBoxWight.Name = "textBoxWight";
            this.textBoxWight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxWight.Size = new System.Drawing.Size(126, 37);
            this.textBoxWight.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(388, 379);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(123, 70);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonСhoice
            // 
            this.buttonСhoice.BackColor = System.Drawing.Color.Blue;
            this.buttonСhoice.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСhoice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonСhoice.Location = new System.Drawing.Point(570, 117);
            this.buttonСhoice.Name = "buttonСhoice";
            this.buttonСhoice.Size = new System.Drawing.Size(240, 90);
            this.buttonСhoice.TabIndex = 3;
            this.buttonСhoice.Text = "Завантажити зображення";
            this.buttonСhoice.UseVisualStyleBackColor = false;
            this.buttonСhoice.Click += new System.EventHandler(this.buttonСhoice_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(29, 140);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(305, 25);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Ведіть ширину зображення";
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.AutoSize = true;
            this.checkBoxBlack.Checked = true;
            this.checkBoxBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBlack.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBlack.Location = new System.Drawing.Point(34, 197);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(163, 29);
            this.checkBoxBlack.TabIndex = 5;
            this.checkBoxBlack.Text = "Черний фон";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            this.checkBoxBlack.Visible = false;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Peru;
            this.buttonDownload.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownload.Location = new System.Drawing.Point(520, 258);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(340, 100);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Записати зображення в файл";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Visible = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.checkBoxBlack);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonСhoice);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxWight);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCII Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxWight;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonСhoice;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.Button buttonDownload;
    }
}