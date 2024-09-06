namespace _04_Task_Performance_1
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.GuessText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GuessWord = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.listBoxGuess = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessText
            // 
            this.GuessText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuessText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessText.Location = new System.Drawing.Point(12, 208);
            this.GuessText.Name = "GuessText";
            this.GuessText.Size = new System.Drawing.Size(509, 29);
            this.GuessText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GuessWord
            // 
            this.GuessWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuessWord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GuessWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessWord.ForeColor = System.Drawing.Color.White;
            this.GuessWord.Location = new System.Drawing.Point(144, 267);
            this.GuessWord.Name = "GuessWord";
            this.GuessWord.Size = new System.Drawing.Size(239, 44);
            this.GuessWord.TabIndex = 2;
            this.GuessWord.Text = "Guess";
            this.GuessWord.UseVisualStyleBackColor = false;
            this.GuessWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.ForeColor = System.Drawing.Color.White;
            this.labelWord.Location = new System.Drawing.Point(204, 107);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(33, 20);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "----";
            this.labelWord.Click += new System.EventHandler(this.labelWord_Click);
            // 
            // listBoxGuess
            // 
            this.listBoxGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGuess.FormattingEnabled = true;
            this.listBoxGuess.ItemHeight = 20;
            this.listBoxGuess.Location = new System.Drawing.Point(547, 90);
            this.listBoxGuess.Name = "listBoxGuess";
            this.listBoxGuess.Size = new System.Drawing.Size(362, 324);
            this.listBoxGuess.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(547, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wrong Guess";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(509, 167);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(975, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxGuess);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.GuessWord);
            this.Controls.Add(this.GuessText);
            this.Controls.Add(this.button2);
            this.Name = "form1";
            this.Text = "Guess The Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GuessText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button GuessWord;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.ListBox listBoxGuess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

