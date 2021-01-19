namespace GA__windowsForm_project
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Draw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tournament = new System.Windows.Forms.Label();
            this.tour_input = new System.Windows.Forms.TextBox();
            this.sum_cards = new System.Windows.Forms.Label();
            this.product_cards = new System.Windows.Forms.Label();
            this.sum_input = new System.Windows.Forms.TextBox();
            this.product_input = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.show_sum = new System.Windows.Forms.Button();
            this.clear_grid = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.Color.FloralWhite;
            this.Draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Draw.ForeColor = System.Drawing.Color.DarkRed;
            this.Draw.Location = new System.Drawing.Point(428, 107);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(75, 23);
            this.Draw.TabIndex = 1;
            this.Draw.Text = "Show";
            this.Draw.UseVisualStyleBackColor = false;
            this.Draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 294);
            this.panel1.TabIndex = 2;
            // 
            // tournament
            // 
            this.tournament.AutoSize = true;
            this.tournament.Cursor = System.Windows.Forms.Cursors.No;
            this.tournament.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournament.ForeColor = System.Drawing.Color.Maroon;
            this.tournament.Location = new System.Drawing.Point(12, 9);
            this.tournament.Name = "tournament";
            this.tournament.Size = new System.Drawing.Size(232, 24);
            this.tournament.TabIndex = 3;
            this.tournament.Text = "Tournaments Limit ?";
            // 
            // tour_input
            // 
            this.tour_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tour_input.Location = new System.Drawing.Point(264, 13);
            this.tour_input.Name = "tour_input";
            this.tour_input.Size = new System.Drawing.Size(100, 22);
            this.tour_input.TabIndex = 4;
            // 
            // sum_cards
            // 
            this.sum_cards.AutoSize = true;
            this.sum_cards.Cursor = System.Windows.Forms.Cursors.No;
            this.sum_cards.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_cards.ForeColor = System.Drawing.Color.DarkRed;
            this.sum_cards.Location = new System.Drawing.Point(12, 58);
            this.sum_cards.Name = "sum_cards";
            this.sum_cards.Size = new System.Drawing.Size(152, 24);
            this.sum_cards.TabIndex = 5;
            this.sum_cards.Text = "Sum Of Cards";
            this.sum_cards.Click += new System.EventHandler(this.label1_Click);
            // 
            // product_cards
            // 
            this.product_cards.AutoSize = true;
            this.product_cards.Cursor = System.Windows.Forms.Cursors.No;
            this.product_cards.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_cards.ForeColor = System.Drawing.Color.DarkRed;
            this.product_cards.Location = new System.Drawing.Point(12, 107);
            this.product_cards.Name = "product_cards";
            this.product_cards.Size = new System.Drawing.Size(191, 24);
            this.product_cards.TabIndex = 6;
            this.product_cards.Text = "Product Of Cards";
            // 
            // sum_input
            // 
            this.sum_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_input.Location = new System.Drawing.Point(264, 60);
            this.sum_input.Name = "sum_input";
            this.sum_input.Size = new System.Drawing.Size(100, 22);
            this.sum_input.TabIndex = 7;
            // 
            // product_input
            // 
            this.product_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_input.Location = new System.Drawing.Point(264, 109);
            this.product_input.Name = "product_input";
            this.product_input.Size = new System.Drawing.Size(100, 22);
            this.product_input.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Font = new System.Drawing.Font("Tekton Pro Ext", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Brown;
            this.richTextBox1.Location = new System.Drawing.Point(546, 9);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 335);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // show_sum
            // 
            this.show_sum.BackColor = System.Drawing.Color.FloralWhite;
            this.show_sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_sum.ForeColor = System.Drawing.Color.DarkRed;
            this.show_sum.Location = new System.Drawing.Point(428, 60);
            this.show_sum.Name = "show_sum";
            this.show_sum.Size = new System.Drawing.Size(75, 23);
            this.show_sum.TabIndex = 10;
            this.show_sum.Text = "Show";
            this.show_sum.UseVisualStyleBackColor = false;
            this.show_sum.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clear_grid
            // 
            this.clear_grid.BackColor = System.Drawing.Color.FloralWhite;
            this.clear_grid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_grid.ForeColor = System.Drawing.Color.DarkRed;
            this.clear_grid.Location = new System.Drawing.Point(546, 401);
            this.clear_grid.Name = "clear_grid";
            this.clear_grid.Padding = new System.Windows.Forms.Padding(5);
            this.clear_grid.Size = new System.Drawing.Size(90, 37);
            this.clear_grid.TabIndex = 11;
            this.clear_grid.Text = "Clear Grid";
            this.clear_grid.UseVisualStyleBackColor = false;
            this.clear_grid.Click += new System.EventHandler(this.next_Click);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color.ForeColor = System.Drawing.Color.Transparent;
            this.color.Location = new System.Drawing.Point(688, 395);
            this.color.Name = "color";
            this.color.Padding = new System.Windows.Forms.Padding(5);
            this.color.Size = new System.Drawing.Size(90, 43);
            this.color.TabIndex = 12;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = false;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GA__windowsForm_project.Properties.Resources.study;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color);
            this.Controls.Add(this.clear_grid);
            this.Controls.Add(this.show_sum);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.product_input);
            this.Controls.Add(this.sum_input);
            this.Controls.Add(this.product_cards);
            this.Controls.Add(this.sum_cards);
            this.Controls.Add(this.tour_input);
            this.Controls.Add(this.tournament);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tournament;
        private System.Windows.Forms.TextBox tour_input;
        private System.Windows.Forms.Label sum_cards;
        private System.Windows.Forms.Label product_cards;
        private System.Windows.Forms.TextBox sum_input;
        private System.Windows.Forms.TextBox product_input;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button show_sum;
        private System.Windows.Forms.Button clear_grid;
        private System.Windows.Forms.Button color;
    }
}

