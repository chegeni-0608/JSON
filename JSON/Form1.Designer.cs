namespace JSON
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
            this.btnSerializeToJson = new System.Windows.Forms.Button();
            this.txtSerializeOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Json Serialize Output :";
            // 
            // btnSerializeToJson
            // 
            this.btnSerializeToJson.Location = new System.Drawing.Point(30, 336);
            this.btnSerializeToJson.Name = "btnSerializeToJson";
            this.btnSerializeToJson.Size = new System.Drawing.Size(200, 23);
            this.btnSerializeToJson.TabIndex = 1;
            this.btnSerializeToJson.Text = "Serialize To Json";
            this.btnSerializeToJson.UseVisualStyleBackColor = true;
            this.btnSerializeToJson.Click += new System.EventHandler(this.btnSerializeToJson_Click);
            // 
            // txtSerializeOutput
            // 
            this.txtSerializeOutput.Location = new System.Drawing.Point(30, 67);
            this.txtSerializeOutput.Multiline = true;
            this.txtSerializeOutput.Name = "txtSerializeOutput";
            this.txtSerializeOutput.Size = new System.Drawing.Size(437, 263);
            this.txtSerializeOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSerializeOutput);
            this.Controls.Add(this.btnSerializeToJson);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerializeToJson;
        private System.Windows.Forms.TextBox txtSerializeOutput;
    }
}

