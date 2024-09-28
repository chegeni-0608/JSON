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
            this.txtSerializeOutput = new System.Windows.Forms.TextBox();
            this.btnSerializeToJson = new System.Windows.Forms.Button();
            this.btnDeserializeToObject = new System.Windows.Forms.Button();
            this.btnSerializeToXMl = new System.Windows.Forms.Button();
            this.btnDeserializeFromXML = new System.Windows.Forms.Button();
            this.btnKeyboardEvents = new System.Windows.Forms.Button();
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
            // txtSerializeOutput
            // 
            this.txtSerializeOutput.Location = new System.Drawing.Point(30, 67);
            this.txtSerializeOutput.Multiline = true;
            this.txtSerializeOutput.Name = "txtSerializeOutput";
            this.txtSerializeOutput.Size = new System.Drawing.Size(437, 263);
            this.txtSerializeOutput.TabIndex = 2;
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
            // btnDeserializeToObject
            // 
            this.btnDeserializeToObject.Location = new System.Drawing.Point(267, 336);
            this.btnDeserializeToObject.Name = "btnDeserializeToObject";
            this.btnDeserializeToObject.Size = new System.Drawing.Size(200, 23);
            this.btnDeserializeToObject.TabIndex = 3;
            this.btnDeserializeToObject.Text = "Deserialize To Object";
            this.btnDeserializeToObject.UseVisualStyleBackColor = true;
            this.btnDeserializeToObject.Click += new System.EventHandler(this.btnDeserializeToObject_Click);
            // 
            // btnSerializeToXMl
            // 
            this.btnSerializeToXMl.Location = new System.Drawing.Point(30, 375);
            this.btnSerializeToXMl.Name = "btnSerializeToXMl";
            this.btnSerializeToXMl.Size = new System.Drawing.Size(200, 23);
            this.btnSerializeToXMl.TabIndex = 4;
            this.btnSerializeToXMl.Text = "Serialize To XML";
            this.btnSerializeToXMl.UseVisualStyleBackColor = true;
            this.btnSerializeToXMl.Click += new System.EventHandler(this.btnSerializeToXMl_Click);
            // 
            // btnDeserializeFromXML
            // 
            this.btnDeserializeFromXML.Location = new System.Drawing.Point(267, 375);
            this.btnDeserializeFromXML.Name = "btnDeserializeFromXML";
            this.btnDeserializeFromXML.Size = new System.Drawing.Size(200, 23);
            this.btnDeserializeFromXML.TabIndex = 5;
            this.btnDeserializeFromXML.Text = "Deserialize XAM To  Object";
            this.btnDeserializeFromXML.UseVisualStyleBackColor = true;
            this.btnDeserializeFromXML.Click += new System.EventHandler(this.btnDeserializeFromXML_Click);
            // 
            // btnKeyboardEvents
            // 
            this.btnKeyboardEvents.Location = new System.Drawing.Point(30, 415);
            this.btnKeyboardEvents.Name = "btnKeyboardEvents";
            this.btnKeyboardEvents.Size = new System.Drawing.Size(200, 23);
            this.btnKeyboardEvents.TabIndex = 6;
            this.btnKeyboardEvents.Text = "Keyboard Events";
            this.btnKeyboardEvents.UseVisualStyleBackColor = true;
            this.btnKeyboardEvents.Click += new System.EventHandler(this.btnKeyboardEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKeyboardEvents);
            this.Controls.Add(this.btnDeserializeFromXML);
            this.Controls.Add(this.btnSerializeToXMl);
            this.Controls.Add(this.btnDeserializeToObject);
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
        private System.Windows.Forms.TextBox txtSerializeOutput;
        private System.Windows.Forms.Button btnSerializeToJson;
        private System.Windows.Forms.Button btnDeserializeToObject;
        private System.Windows.Forms.Button btnSerializeToXMl;
        private System.Windows.Forms.Button btnDeserializeFromXML;
        private System.Windows.Forms.Button btnKeyboardEvents;
    }
}

