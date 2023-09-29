namespace MedicineApp
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      listView1 = new System.Windows.Forms.ListView();
      columnHeader1 = new System.Windows.Forms.ColumnHeader();
      columnHeader2 = new System.Windows.Forms.ColumnHeader();
      columnHeader3 = new System.Windows.Forms.ColumnHeader();
      columnHeader4 = new System.Windows.Forms.ColumnHeader();
      columnHeader5 = new System.Windows.Forms.ColumnHeader();
      button1 = new System.Windows.Forms.Button();
      button2 = new System.Windows.Forms.Button();
      label1 = new System.Windows.Forms.Label();
      textBox1 = new System.Windows.Forms.TextBox();
      label2 = new System.Windows.Forms.Label();
      label3 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      label5 = new System.Windows.Forms.Label();
      textBox5 = new System.Windows.Forms.TextBox();
      textBox2 = new System.Windows.Forms.TextBox();
      textBox3 = new System.Windows.Forms.TextBox();
      textBox4 = new System.Windows.Forms.TextBox();
      label6 = new System.Windows.Forms.Label();
      label7 = new System.Windows.Forms.Label();
      button3 = new System.Windows.Forms.Button();
      button4 = new System.Windows.Forms.Button();
      pictureBox1 = new System.Windows.Forms.PictureBox();
      label8 = new System.Windows.Forms.Label();
      label9 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // listView1
      // 
      listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
      listView1.HideSelection = false;
      listView1.Location = new System.Drawing.Point(22, 49);
      listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      listView1.Name = "listView1";
      listView1.Size = new System.Drawing.Size(1055, 153);
      listView1.TabIndex = 0;
      listView1.UseCompatibleStateImageBehavior = false;
      listView1.View = System.Windows.Forms.View.Details;
      listView1.MouseDoubleClick += listView1_MouseDoubleClick;
      // 
      // columnHeader1
      // 
      columnHeader1.Text = "Sira";
      columnHeader1.Width = 40;
      // 
      // columnHeader2
      // 
      columnHeader2.Text = "Ilac Ismi";
      columnHeader2.Width = 150;
      // 
      // columnHeader3
      // 
      columnHeader3.Text = "Ilac Sirketi";
      columnHeader3.Width = 150;
      // 
      // columnHeader4
      // 
      columnHeader4.Text = "Ilac Tipi";
      columnHeader4.Width = 150;
      // 
      // columnHeader5
      // 
      columnHeader5.Text = "Ilac Stok Adedi";
      columnHeader5.Width = 150;
      // 
      // button1
      // 
      button1.BackColor = System.Drawing.SystemColors.Control;
      button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      button1.ForeColor = System.Drawing.Color.Red;
      button1.Location = new System.Drawing.Point(22, 221);
      button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      button1.Name = "button1";
      button1.Size = new System.Drawing.Size(134, 28);
      button1.TabIndex = 1;
      button1.Text = "Listele";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.BackColor = System.Drawing.SystemColors.Control;
      button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      button2.ForeColor = System.Drawing.Color.Black;
      button2.Location = new System.Drawing.Point(943, 464);
      button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      button2.Name = "button2";
      button2.Size = new System.Drawing.Size(134, 28);
      button2.TabIndex = 2;
      button2.Text = "Kaydet";
      button2.UseVisualStyleBackColor = false;
      button2.Click += button2_Click;
      // 
      // label1
      // 
      label1.Location = new System.Drawing.Point(0, 0);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(100, 23);
      label1.TabIndex = 22;
      // 
      // textBox1
      // 
      textBox1.Location = new System.Drawing.Point(783, 286);
      textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      textBox1.Name = "textBox1";
      textBox1.Size = new System.Drawing.Size(294, 23);
      textBox1.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.BackColor = System.Drawing.Color.White;
      label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      label2.Location = new System.Drawing.Point(696, 318);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(75, 21);
      label2.TabIndex = 5;
      label2.Text = " Ilac Adi;";
      // 
      // label3
      // 
      label3.Location = new System.Drawing.Point(0, 0);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(100, 23);
      label3.TabIndex = 21;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.BackColor = System.Drawing.Color.Transparent;
      label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      label4.Location = new System.Drawing.Point(691, 381);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(79, 21);
      label4.TabIndex = 9;
      label4.Text = "Ilac Turu;";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.BackColor = System.Drawing.Color.Transparent;
      label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      label5.Location = new System.Drawing.Point(644, 418);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(126, 21);
      label5.TabIndex = 11;
      label5.Text = "Ilac Kutu Adeti;";
      // 
      // textBox5
      // 
      textBox5.Location = new System.Drawing.Point(783, 416);
      textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      textBox5.Name = "textBox5";
      textBox5.Size = new System.Drawing.Size(294, 23);
      textBox5.TabIndex = 12;
      // 
      // textBox2
      // 
      textBox2.Location = new System.Drawing.Point(783, 318);
      textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      textBox2.Name = "textBox2";
      textBox2.Size = new System.Drawing.Size(294, 23);
      textBox2.TabIndex = 13;
      // 
      // textBox3
      // 
      textBox3.Location = new System.Drawing.Point(783, 350);
      textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      textBox3.Name = "textBox3";
      textBox3.Size = new System.Drawing.Size(294, 23);
      textBox3.TabIndex = 14;
      // 
      // textBox4
      // 
      textBox4.Location = new System.Drawing.Point(783, 382);
      textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      textBox4.Name = "textBox4";
      textBox4.Size = new System.Drawing.Size(294, 23);
      textBox4.TabIndex = 15;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.BackColor = System.Drawing.Color.Transparent;
      label6.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
      label6.ForeColor = System.Drawing.SystemColors.HotTrack;
      label6.Location = new System.Drawing.Point(746, 241);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(331, 25);
      label6.TabIndex = 16;
      label6.Text = "Ilac Stok Girisi Yapma Alani;";
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.BackColor = System.Drawing.Color.Transparent;
      label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
      label7.ForeColor = System.Drawing.SystemColors.HotTrack;
      label7.Location = new System.Drawing.Point(22, 9);
      label7.Name = "label7";
      label7.Size = new System.Drawing.Size(448, 32);
      label7.TabIndex = 17;
      label7.Text = "STOKTA BULUNAN ILACLARIN LISTESI";
      // 
      // button3
      // 
      button3.BackColor = System.Drawing.Color.Red;
      button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      button3.ForeColor = System.Drawing.Color.LightGray;
      button3.Location = new System.Drawing.Point(176, 221);
      button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      button3.Name = "button3";
      button3.Size = new System.Drawing.Size(134, 28);
      button3.TabIndex = 18;
      button3.Text = "Sil";
      button3.UseVisualStyleBackColor = false;
      button3.Click += button3_Click;
      // 
      // button4
      // 
      button4.BackColor = System.Drawing.SystemColors.Control;
      button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      button4.ForeColor = System.Drawing.Color.Red;
      button4.Location = new System.Drawing.Point(325, 221);
      button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      button4.Name = "button4";
      button4.Size = new System.Drawing.Size(134, 28);
      button4.TabIndex = 19;
      button4.Text = "Bilgi Guncelle";
      button4.UseVisualStyleBackColor = false;
      button4.Click += button4_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
      pictureBox1.BackColor = System.Drawing.SystemColors.Control;
      pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
      pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      pictureBox1.Location = new System.Drawing.Point(22, 545);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new System.Drawing.Size(110, 100);
      pictureBox1.TabIndex = 20;
      pictureBox1.TabStop = false;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.BackColor = System.Drawing.Color.White;
      label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      label8.Location = new System.Drawing.Point(727, 286);
      label8.Name = "label8";
      label8.Size = new System.Drawing.Size(43, 21);
      label8.TabIndex = 23;
      label8.Text = "Sira;";
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.BackColor = System.Drawing.Color.Transparent;
      label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      label9.Location = new System.Drawing.Point(676, 350);
      label9.Name = "label9";
      label9.Size = new System.Drawing.Size(94, 21);
      label9.TabIndex = 24;
      label9.Text = "Ilac Sirketi;";
      // 
      // Form1
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
      BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      ClientSize = new System.Drawing.Size(1166, 657);
      Controls.Add(label9);
      Controls.Add(label8);
      Controls.Add(pictureBox1);
      Controls.Add(button4);
      Controls.Add(button3);
      Controls.Add(label7);
      Controls.Add(label6);
      Controls.Add(textBox4);
      Controls.Add(textBox3);
      Controls.Add(textBox2);
      Controls.Add(textBox5);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(textBox1);
      Controls.Add(label1);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(listView1);
      Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      Name = "Form1";
      Text = "Merkez Eczanesi";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
  }
}
