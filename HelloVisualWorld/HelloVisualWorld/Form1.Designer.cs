namespace HelloVisualWorld
{
    partial class hellolabel
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
            this.btn_results = new System.Windows.Forms.Button();
            this.HelloVisualWorld = new System.Windows.Forms.Label();
            this.btn_goodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(355, 138);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(75, 23);
            this.btn_results.TabIndex = 0;
            this.btn_results.Text = "Click Me !";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // HelloVisualWorld
            // 
            this.HelloVisualWorld.AutoSize = true;
            this.HelloVisualWorld.Location = new System.Drawing.Point(352, 62);
            this.HelloVisualWorld.Name = "HelloVisualWorld";
            this.HelloVisualWorld.Size = new System.Drawing.Size(93, 13);
            this.HelloVisualWorld.TabIndex = 1;
            this.HelloVisualWorld.Text = "Hello Visual World";
            // 
            // btn_goodbye
            // 
            this.btn_goodbye.Location = new System.Drawing.Point(250, 216);
            this.btn_goodbye.Name = "btn_goodbye";
            this.btn_goodbye.Size = new System.Drawing.Size(75, 23);
            this.btn_goodbye.TabIndex = 2;
            this.btn_goodbye.Text = "Good Bye!";
            this.btn_goodbye.UseVisualStyleBackColor = true;
            // 
            // hellolabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_goodbye);
            this.Controls.Add(this.HelloVisualWorld);
            this.Controls.Add(this.btn_results);
            this.Name = "hellolabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Label HelloVisualWorld;
        private System.Windows.Forms.Button btn_goodbye;
    }
}

