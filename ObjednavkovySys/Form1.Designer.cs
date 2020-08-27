namespace ObjednavkovySys
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
            this.listView1_SeznamObjednavek = new System.Windows.Forms.ListView();
            this.Cislo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datumObj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2_SeznamPolozekObjednavky = new System.Windows.Forms.ListView();
            this.Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1_SeznamObjednavek = new System.Windows.Forms.Label();
            this.label2_SeznamPolozekObjednavky = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1_SeznamVysledku = new System.Windows.Forms.Label();
            this.listBox1_Vysledky = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1_Nacist = new System.Windows.Forms.Button();
            this.button2_Mesice = new System.Windows.Forms.Button();
            this.button3_Ceny = new System.Windows.Forms.Button();
            this.button4_prvocisla = new System.Windows.Forms.Button();
            this.button5_exportovat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1_SeznamObjednavek
            // 
            this.listView1_SeznamObjednavek.BackColor = System.Drawing.SystemColors.Window;
            this.listView1_SeznamObjednavek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cislo,
            this.datumObj,
            this.columnHeader1});
            this.listView1_SeznamObjednavek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1_SeznamObjednavek.FullRowSelect = true;
            this.listView1_SeznamObjednavek.GridLines = true;
            this.listView1_SeznamObjednavek.HideSelection = false;
            this.listView1_SeznamObjednavek.Location = new System.Drawing.Point(3, 26);
            this.listView1_SeznamObjednavek.Name = "listView1_SeznamObjednavek";
            this.listView1_SeznamObjednavek.Size = new System.Drawing.Size(369, 112);
            this.listView1_SeznamObjednavek.TabIndex = 0;
            this.listView1_SeznamObjednavek.UseCompatibleStateImageBehavior = false;
            this.listView1_SeznamObjednavek.View = System.Windows.Forms.View.Details;
            this.listView1_SeznamObjednavek.SelectedIndexChanged += new System.EventHandler(this.listView1_SeznamObjednavek_SelectedIndexChanged);
            // 
            // Cislo
            // 
            this.Cislo.Text = "Cislo";
            // 
            // datumObj
            // 
            this.datumObj.Text = "datum Objednavky";
            // 
            // listView2_SeznamPolozekObjednavky
            // 
            this.listView2_SeznamPolozekObjednavky.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazev,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2_SeznamPolozekObjednavky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2_SeznamPolozekObjednavky.HideSelection = false;
            this.listView2_SeznamPolozekObjednavky.Location = new System.Drawing.Point(378, 26);
            this.listView2_SeznamPolozekObjednavky.Name = "listView2_SeznamPolozekObjednavky";
            this.listView2_SeznamPolozekObjednavky.Size = new System.Drawing.Size(369, 112);
            this.listView2_SeznamPolozekObjednavky.TabIndex = 1;
            this.listView2_SeznamPolozekObjednavky.UseCompatibleStateImageBehavior = false;
            this.listView2_SeznamPolozekObjednavky.View = System.Windows.Forms.View.Details;
            // 
            // Nazev
            // 
            this.Nazev.Text = "Nazev";
            // 
            // label1_SeznamObjednavek
            // 
            this.label1_SeznamObjednavek.AutoSize = true;
            this.label1_SeznamObjednavek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_SeznamObjednavek.Location = new System.Drawing.Point(3, 0);
            this.label1_SeznamObjednavek.Name = "label1_SeznamObjednavek";
            this.label1_SeznamObjednavek.Size = new System.Drawing.Size(369, 23);
            this.label1_SeznamObjednavek.TabIndex = 2;
            this.label1_SeznamObjednavek.Text = "Seznam objednávek";
            this.label1_SeznamObjednavek.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2_SeznamPolozekObjednavky
            // 
            this.label2_SeznamPolozekObjednavky.AutoSize = true;
            this.label2_SeznamPolozekObjednavky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_SeznamPolozekObjednavky.Location = new System.Drawing.Point(378, 0);
            this.label2_SeznamPolozekObjednavky.Name = "label2_SeznamPolozekObjednavky";
            this.label2_SeznamPolozekObjednavky.Size = new System.Drawing.Size(369, 23);
            this.label2_SeznamPolozekObjednavky.TabIndex = 3;
            this.label2_SeznamPolozekObjednavky.Text = "Seznam položek objednávky";
            this.label2_SeznamPolozekObjednavky.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView1_SeznamObjednavek, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2_SeznamPolozekObjednavky, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView2_SeznamPolozekObjednavky, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1_SeznamObjednavek, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 141);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1_SeznamVysledku
            // 
            this.label1_SeznamVysledku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_SeznamVysledku.AutoSize = true;
            this.label1_SeznamVysledku.Location = new System.Drawing.Point(3, 0);
            this.label1_SeznamVysledku.Name = "label1_SeznamVysledku";
            this.label1_SeznamVysledku.Size = new System.Drawing.Size(632, 33);
            this.label1_SeznamVysledku.TabIndex = 5;
            this.label1_SeznamVysledku.Text = "Seznam Výsledků";
            this.label1_SeznamVysledku.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBox1_Vysledky
            // 
            this.listBox1_Vysledky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1_Vysledky.FormattingEnabled = true;
            this.listBox1_Vysledky.Location = new System.Drawing.Point(3, 36);
            this.listBox1_Vysledky.Name = "listBox1_Vysledky";
            this.listBox1_Vysledky.Size = new System.Drawing.Size(632, 159);
            this.listBox1_Vysledky.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBox1_Vysledky, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1_SeznamVysledku, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 254);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(638, 198);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1_Nacist, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2_Mesice, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button3_Ceny, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button4_prvocisla, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button5_exportovat, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(654, 254);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(106, 195);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // button1_Nacist
            // 
            this.button1_Nacist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1_Nacist.Location = new System.Drawing.Point(3, 3);
            this.button1_Nacist.Name = "button1_Nacist";
            this.button1_Nacist.Size = new System.Drawing.Size(100, 33);
            this.button1_Nacist.TabIndex = 0;
            this.button1_Nacist.Text = "Načíst";
            this.button1_Nacist.UseVisualStyleBackColor = true;
            this.button1_Nacist.Click += new System.EventHandler(this.button1_Nacist_Click);
            // 
            // button2_Mesice
            // 
            this.button2_Mesice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2_Mesice.Location = new System.Drawing.Point(3, 42);
            this.button2_Mesice.Name = "button2_Mesice";
            this.button2_Mesice.Size = new System.Drawing.Size(100, 33);
            this.button2_Mesice.TabIndex = 1;
            this.button2_Mesice.Text = "Měsíce";
            this.button2_Mesice.UseVisualStyleBackColor = true;
            this.button2_Mesice.Click += new System.EventHandler(this.button2_Mesice_Click);
            // 
            // button3_Ceny
            // 
            this.button3_Ceny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3_Ceny.Location = new System.Drawing.Point(3, 81);
            this.button3_Ceny.Name = "button3_Ceny";
            this.button3_Ceny.Size = new System.Drawing.Size(100, 33);
            this.button3_Ceny.TabIndex = 2;
            this.button3_Ceny.Text = "Ceny";
            this.button3_Ceny.UseVisualStyleBackColor = true;
            this.button3_Ceny.Click += new System.EventHandler(this.button3_Ceny_Click);
            // 
            // button4_prvocisla
            // 
            this.button4_prvocisla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4_prvocisla.Location = new System.Drawing.Point(3, 120);
            this.button4_prvocisla.Name = "button4_prvocisla";
            this.button4_prvocisla.Size = new System.Drawing.Size(100, 33);
            this.button4_prvocisla.TabIndex = 3;
            this.button4_prvocisla.Text = "Prvočísla";
            this.button4_prvocisla.UseVisualStyleBackColor = true;
            this.button4_prvocisla.Click += new System.EventHandler(this.button4_prvocisla_Click);
            // 
            // button5_exportovat
            // 
            this.button5_exportovat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5_exportovat.Location = new System.Drawing.Point(3, 159);
            this.button5_exportovat.Name = "button5_exportovat";
            this.button5_exportovat.Size = new System.Drawing.Size(100, 33);
            this.button5_exportovat.TabIndex = 4;
            this.button5_exportovat.Text = "Exportovat";
            this.button5_exportovat.UseVisualStyleBackColor = true;
            this.button5_exportovat.Click += new System.EventHandler(this.button5_exportovat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 464);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "ObjednavkovySys";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1_SeznamObjednavek;
        private System.Windows.Forms.ListView listView2_SeznamPolozekObjednavky;
        private System.Windows.Forms.Label label1_SeznamObjednavek;
        private System.Windows.Forms.Label label2_SeznamPolozekObjednavky;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1_SeznamVysledku;
        private System.Windows.Forms.ListBox listBox1_Vysledky;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1_Nacist;
        private System.Windows.Forms.Button button2_Mesice;
        private System.Windows.Forms.Button button3_Ceny;
        private System.Windows.Forms.Button button4_prvocisla;
        private System.Windows.Forms.Button button5_exportovat;
        private System.Windows.Forms.ColumnHeader Cislo;
        private System.Windows.Forms.ColumnHeader datumObj;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Nazev;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

