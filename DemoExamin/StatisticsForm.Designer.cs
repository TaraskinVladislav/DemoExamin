namespace DemoExamin
{
    partial class StatisticsForm
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
            this.lblCompletedRequests = new System.Windows.Forms.Label();
            this.lblAverageCompletionTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompletedRequests
            // 
            this.lblCompletedRequests.AutoSize = true;
            this.lblCompletedRequests.Location = new System.Drawing.Point(22, 45);
            this.lblCompletedRequests.Name = "lblCompletedRequests";
            this.lblCompletedRequests.Size = new System.Drawing.Size(180, 13);
            this.lblCompletedRequests.TabIndex = 0;
            this.lblCompletedRequests.Text = "Количество выполненных заявок:";
            // 
            // lblAverageCompletionTime
            // 
            this.lblAverageCompletionTime.AutoSize = true;
            this.lblAverageCompletionTime.Location = new System.Drawing.Point(22, 69);
            this.lblAverageCompletionTime.Name = "lblAverageCompletionTime";
            this.lblAverageCompletionTime.Size = new System.Drawing.Size(192, 13);
            this.lblAverageCompletionTime.TabIndex = 1;
            this.lblAverageCompletionTime.Text = "Среднее время выполнения заявки:";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAverageCompletionTime);
            this.Controls.Add(this.lblCompletedRequests);
            this.Name = "StatisticsForm";
            this.Text = "Статистика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompletedRequests;
        private System.Windows.Forms.Label lblAverageCompletionTime;
    }
}