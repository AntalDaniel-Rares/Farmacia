
namespace Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_cantitate = new System.Windows.Forms.Label();
            this.label_id_lot = new System.Windows.Forms.Label();
            this.label_id_promotie = new System.Windows.Forms.Label();
            this.button2_insert = new System.Windows.Forms.Button();
            this.textBox_id_lot = new System.Windows.Forms.TextBox();
            this.textBox_id_promotie = new System.Windows.Forms.TextBox();
            this.textBox_cantitate = new System.Windows.Forms.TextBox();
            this.label_data_expirare = new System.Windows.Forms.Label();
            this.textBox_data_expirare = new System.Windows.Forms.TextBox();
            this.label_set = new System.Windows.Forms.Label();
            this.comboBox_set = new System.Windows.Forms.ComboBox();
            this.textBox_set = new System.Windows.Forms.TextBox();
            this.label_where = new System.Windows.Forms.Label();
            this.comboBox_where = new System.Windows.Forms.ComboBox();
            this.textBox_where = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_update2 = new System.Windows.Forms.Button();
            this.textBox_where2 = new System.Windows.Forms.TextBox();
            this.comboBox_where2 = new System.Windows.Forms.ComboBox();
            this.label_where2 = new System.Windows.Forms.Label();
            this.textBox_set2 = new System.Windows.Forms.TextBox();
            this.comboBox_set2 = new System.Windows.Forms.ComboBox();
            this.label_set2 = new System.Windows.Forms.Label();
            this.label_delete2 = new System.Windows.Forms.Label();
            this.comboBox_delete2 = new System.Windows.Forms.ComboBox();
            this.textBox_delete2 = new System.Windows.Forms.TextBox();
            this.button_delete2 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.comboBox_delete = new System.Windows.Forms.ComboBox();
            this.label_delete = new System.Windows.Forms.Label();
            this.button_arrow_down = new System.Windows.Forms.Button();
            this.button_arrow_up = new System.Windows.Forms.Button();
            this.label_interogari = new System.Windows.Forms.Label();
            this.textBox_interogari_promotie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Location = new System.Drawing.Point(330, 243);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(100, 22);
            this.textBoxDataSource.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 209);
            this.textBox2.MaxLength = 14;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(339, 262);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(91, 31);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 500);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(463, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(645, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(857, 125);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 9;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID_Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Denumire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pret impus";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(833, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_cantitate
            // 
            this.label_cantitate.AutoSize = true;
            this.label_cantitate.Location = new System.Drawing.Point(929, 125);
            this.label_cantitate.Name = "label_cantitate";
            this.label_cantitate.Size = new System.Drawing.Size(64, 17);
            this.label_cantitate.TabIndex = 19;
            this.label_cantitate.Text = "Cantitate";
            // 
            // label_id_lot
            // 
            this.label_id_lot.AutoSize = true;
            this.label_id_lot.Location = new System.Drawing.Point(367, 125);
            this.label_id_lot.Name = "label_id_lot";
            this.label_id_lot.Size = new System.Drawing.Size(44, 17);
            this.label_id_lot.TabIndex = 18;
            this.label_id_lot.Text = "ID_lot";
            // 
            // label_id_promotie
            // 
            this.label_id_promotie.AutoSize = true;
            this.label_id_promotie.Location = new System.Drawing.Point(732, 125);
            this.label_id_promotie.Name = "label_id_promotie";
            this.label_id_promotie.Size = new System.Drawing.Size(85, 17);
            this.label_id_promotie.TabIndex = 17;
            this.label_id_promotie.Text = "ID_Promotie";
            // 
            // button2_insert
            // 
            this.button2_insert.Location = new System.Drawing.Point(1100, 120);
            this.button2_insert.Name = "button2_insert";
            this.button2_insert.Size = new System.Drawing.Size(75, 23);
            this.button2_insert.TabIndex = 9;
            this.button2_insert.Text = "INSERT";
            this.button2_insert.UseVisualStyleBackColor = true;
            this.button2_insert.Click += new System.EventHandler(this.button2_insert_Click);
            // 
            // textBox_id_lot
            // 
            this.textBox_id_lot.Location = new System.Drawing.Point(417, 120);
            this.textBox_id_lot.Name = "textBox_id_lot";
            this.textBox_id_lot.Size = new System.Drawing.Size(100, 22);
            this.textBox_id_lot.TabIndex = 15;
            // 
            // textBox_id_promotie
            // 
            this.textBox_id_promotie.Location = new System.Drawing.Point(823, 120);
            this.textBox_id_promotie.Name = "textBox_id_promotie";
            this.textBox_id_promotie.Size = new System.Drawing.Size(100, 22);
            this.textBox_id_promotie.TabIndex = 14;
            // 
            // textBox_cantitate
            // 
            this.textBox_cantitate.Location = new System.Drawing.Point(994, 120);
            this.textBox_cantitate.Name = "textBox_cantitate";
            this.textBox_cantitate.Size = new System.Drawing.Size(100, 22);
            this.textBox_cantitate.TabIndex = 20;
            // 
            // label_data_expirare
            // 
            this.label_data_expirare.AutoSize = true;
            this.label_data_expirare.Location = new System.Drawing.Point(523, 125);
            this.label_data_expirare.Name = "label_data_expirare";
            this.label_data_expirare.Size = new System.Drawing.Size(97, 17);
            this.label_data_expirare.TabIndex = 21;
            this.label_data_expirare.Text = "Data_expirare";
            // 
            // textBox_data_expirare
            // 
            this.textBox_data_expirare.Location = new System.Drawing.Point(626, 120);
            this.textBox_data_expirare.Name = "textBox_data_expirare";
            this.textBox_data_expirare.Size = new System.Drawing.Size(100, 22);
            this.textBox_data_expirare.TabIndex = 22;
            // 
            // label_set
            // 
            this.label_set.AutoSize = true;
            this.label_set.Location = new System.Drawing.Point(367, 91);
            this.label_set.Name = "label_set";
            this.label_set.Size = new System.Drawing.Size(35, 17);
            this.label_set.TabIndex = 23;
            this.label_set.Text = "SET";
            // 
            // comboBox_set
            // 
            this.comboBox_set.FormattingEnabled = true;
            this.comboBox_set.Location = new System.Drawing.Point(408, 85);
            this.comboBox_set.Name = "comboBox_set";
            this.comboBox_set.Size = new System.Drawing.Size(121, 24);
            this.comboBox_set.TabIndex = 24;
            // 
            // textBox_set
            // 
            this.textBox_set.Location = new System.Drawing.Point(535, 87);
            this.textBox_set.Name = "textBox_set";
            this.textBox_set.Size = new System.Drawing.Size(100, 22);
            this.textBox_set.TabIndex = 25;
            // 
            // label_where
            // 
            this.label_where.AutoSize = true;
            this.label_where.Location = new System.Drawing.Point(641, 92);
            this.label_where.Name = "label_where";
            this.label_where.Size = new System.Drawing.Size(59, 17);
            this.label_where.TabIndex = 26;
            this.label_where.Text = "WHERE";
            // 
            // comboBox_where
            // 
            this.comboBox_where.FormattingEnabled = true;
            this.comboBox_where.Location = new System.Drawing.Point(707, 85);
            this.comboBox_where.Name = "comboBox_where";
            this.comboBox_where.Size = new System.Drawing.Size(121, 24);
            this.comboBox_where.TabIndex = 27;
            // 
            // textBox_where
            // 
            this.textBox_where.Location = new System.Drawing.Point(835, 86);
            this.textBox_where.Name = "textBox_where";
            this.textBox_where.Size = new System.Drawing.Size(100, 22);
            this.textBox_where.TabIndex = 28;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(942, 85);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(87, 23);
            this.button_update.TabIndex = 29;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_update2
            // 
            this.button_update2.Location = new System.Drawing.Point(942, 86);
            this.button_update2.Name = "button_update2";
            this.button_update2.Size = new System.Drawing.Size(87, 23);
            this.button_update2.TabIndex = 36;
            this.button_update2.Text = "UPDATE";
            this.button_update2.UseVisualStyleBackColor = true;
            this.button_update2.Click += new System.EventHandler(this.button_update2_Click);
            // 
            // textBox_where2
            // 
            this.textBox_where2.Location = new System.Drawing.Point(835, 87);
            this.textBox_where2.Name = "textBox_where2";
            this.textBox_where2.Size = new System.Drawing.Size(100, 22);
            this.textBox_where2.TabIndex = 35;
            // 
            // comboBox_where2
            // 
            this.comboBox_where2.FormattingEnabled = true;
            this.comboBox_where2.Location = new System.Drawing.Point(707, 86);
            this.comboBox_where2.Name = "comboBox_where2";
            this.comboBox_where2.Size = new System.Drawing.Size(121, 24);
            this.comboBox_where2.TabIndex = 34;
            // 
            // label_where2
            // 
            this.label_where2.AutoSize = true;
            this.label_where2.Location = new System.Drawing.Point(641, 93);
            this.label_where2.Name = "label_where2";
            this.label_where2.Size = new System.Drawing.Size(59, 17);
            this.label_where2.TabIndex = 33;
            this.label_where2.Text = "WHERE";
            // 
            // textBox_set2
            // 
            this.textBox_set2.Location = new System.Drawing.Point(535, 88);
            this.textBox_set2.Name = "textBox_set2";
            this.textBox_set2.Size = new System.Drawing.Size(100, 22);
            this.textBox_set2.TabIndex = 32;
            // 
            // comboBox_set2
            // 
            this.comboBox_set2.FormattingEnabled = true;
            this.comboBox_set2.Location = new System.Drawing.Point(408, 86);
            this.comboBox_set2.Name = "comboBox_set2";
            this.comboBox_set2.Size = new System.Drawing.Size(121, 24);
            this.comboBox_set2.TabIndex = 31;
            // 
            // label_set2
            // 
            this.label_set2.AutoSize = true;
            this.label_set2.Location = new System.Drawing.Point(367, 92);
            this.label_set2.Name = "label_set2";
            this.label_set2.Size = new System.Drawing.Size(35, 17);
            this.label_set2.TabIndex = 30;
            this.label_set2.Text = "SET";
            // 
            // label_delete2
            // 
            this.label_delete2.AutoSize = true;
            this.label_delete2.Location = new System.Drawing.Point(367, 60);
            this.label_delete2.Name = "label_delete2";
            this.label_delete2.Size = new System.Drawing.Size(117, 17);
            this.label_delete2.TabIndex = 37;
            this.label_delete2.Text = "DELETE WHERE";
            // 
            // comboBox_delete2
            // 
            this.comboBox_delete2.FormattingEnabled = true;
            this.comboBox_delete2.Location = new System.Drawing.Point(492, 55);
            this.comboBox_delete2.Name = "comboBox_delete2";
            this.comboBox_delete2.Size = new System.Drawing.Size(175, 24);
            this.comboBox_delete2.TabIndex = 38;
            // 
            // textBox_delete2
            // 
            this.textBox_delete2.Location = new System.Drawing.Point(673, 57);
            this.textBox_delete2.Name = "textBox_delete2";
            this.textBox_delete2.Size = new System.Drawing.Size(154, 22);
            this.textBox_delete2.TabIndex = 39;
            // 
            // button_delete2
            // 
            this.button_delete2.Location = new System.Drawing.Point(833, 56);
            this.button_delete2.Name = "button_delete2";
            this.button_delete2.Size = new System.Drawing.Size(141, 23);
            this.button_delete2.TabIndex = 40;
            this.button_delete2.Text = "DELETE";
            this.button_delete2.UseVisualStyleBackColor = true;
            this.button_delete2.Click += new System.EventHandler(this.button_delete2_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(834, 57);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(141, 23);
            this.button_delete.TabIndex = 44;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(674, 58);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(154, 22);
            this.textBox_delete.TabIndex = 43;
            // 
            // comboBox_delete
            // 
            this.comboBox_delete.FormattingEnabled = true;
            this.comboBox_delete.Location = new System.Drawing.Point(493, 56);
            this.comboBox_delete.Name = "comboBox_delete";
            this.comboBox_delete.Size = new System.Drawing.Size(175, 24);
            this.comboBox_delete.TabIndex = 42;
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Location = new System.Drawing.Point(368, 61);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(117, 17);
            this.label_delete.TabIndex = 41;
            this.label_delete.Text = "DELETE WHERE";
            // 
            // button_arrow_down
            // 
            this.button_arrow_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_arrow_down.BackgroundImage")));
            this.button_arrow_down.Location = new System.Drawing.Point(371, 756);
            this.button_arrow_down.Name = "button_arrow_down";
            this.button_arrow_down.Size = new System.Drawing.Size(50, 48);
            this.button_arrow_down.TabIndex = 45;
            this.button_arrow_down.UseVisualStyleBackColor = true;
            this.button_arrow_down.Click += new System.EventHandler(this.button_arrow_down_Click);
            // 
            // button_arrow_up
            // 
            this.button_arrow_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_arrow_up.BackgroundImage")));
            this.button_arrow_up.Location = new System.Drawing.Point(371, 702);
            this.button_arrow_up.Name = "button_arrow_up";
            this.button_arrow_up.Size = new System.Drawing.Size(50, 48);
            this.button_arrow_up.TabIndex = 46;
            this.button_arrow_up.UseVisualStyleBackColor = true;
            this.button_arrow_up.Click += new System.EventHandler(this.button_arrow_up_Click);
            // 
            // label_interogari
            // 
            this.label_interogari.AutoSize = true;
            this.label_interogari.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_interogari.Location = new System.Drawing.Point(427, 740);
            this.label_interogari.Name = "label_interogari";
            this.label_interogari.Size = new System.Drawing.Size(1003, 29);
            this.label_interogari.TabIndex = 47;
            this.label_interogari.Text = "Toate loturile si cantitatatile ordonate crescator care fac parte din promotia Ex" +
    "traplus. ";
            this.label_interogari.Click += new System.EventHandler(this.label_interogari_Click);
            // 
            // textBox_interogari_promotie
            // 
            this.textBox_interogari_promotie.Location = new System.Drawing.Point(1371, 746);
            this.textBox_interogari_promotie.Name = "textBox_interogari_promotie";
            this.textBox_interogari_promotie.Size = new System.Drawing.Size(126, 22);
            this.textBox_interogari_promotie.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 762);
            this.Controls.Add(this.textBox_interogari_promotie);
            this.Controls.Add(this.label_interogari);
            this.Controls.Add(this.button_arrow_up);
            this.Controls.Add(this.button_arrow_down);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.comboBox_delete);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.button_delete2);
            this.Controls.Add(this.textBox_delete2);
            this.Controls.Add(this.comboBox_delete2);
            this.Controls.Add(this.label_delete2);
            this.Controls.Add(this.button_update2);
            this.Controls.Add(this.textBox_where2);
            this.Controls.Add(this.comboBox_where2);
            this.Controls.Add(this.label_where2);
            this.Controls.Add(this.textBox_set2);
            this.Controls.Add(this.comboBox_set2);
            this.Controls.Add(this.label_set2);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_where);
            this.Controls.Add(this.comboBox_where);
            this.Controls.Add(this.label_where);
            this.Controls.Add(this.textBox_set);
            this.Controls.Add(this.comboBox_set);
            this.Controls.Add(this.label_set);
            this.Controls.Add(this.textBox_data_expirare);
            this.Controls.Add(this.label_data_expirare);
            this.Controls.Add(this.textBox_cantitate);
            this.Controls.Add(this.label_cantitate);
            this.Controls.Add(this.label_id_lot);
            this.Controls.Add(this.label_id_promotie);
            this.Controls.Add(this.button2_insert);
            this.Controls.Add(this.textBox_id_lot);
            this.Controls.Add(this.textBox_id_promotie);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_cantitate;
        private System.Windows.Forms.Label label_id_lot;
        private System.Windows.Forms.Label label_id_promotie;
        private System.Windows.Forms.Button button2_insert;
        private System.Windows.Forms.TextBox textBox_id_lot;
        private System.Windows.Forms.TextBox textBox_id_promotie;
        private System.Windows.Forms.TextBox textBox_cantitate;
        private System.Windows.Forms.Label label_data_expirare;
        private System.Windows.Forms.TextBox textBox_data_expirare;
        private System.Windows.Forms.Label label_set;
        private System.Windows.Forms.ComboBox comboBox_set;
        private System.Windows.Forms.TextBox textBox_set;
        private System.Windows.Forms.Label label_where;
        private System.Windows.Forms.ComboBox comboBox_where;
        private System.Windows.Forms.TextBox textBox_where;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_update2;
        private System.Windows.Forms.TextBox textBox_where2;
        private System.Windows.Forms.ComboBox comboBox_where2;
        private System.Windows.Forms.Label label_where2;
        private System.Windows.Forms.TextBox textBox_set2;
        private System.Windows.Forms.ComboBox comboBox_set2;
        private System.Windows.Forms.Label label_set2;
        private System.Windows.Forms.Label label_delete2;
        private System.Windows.Forms.ComboBox comboBox_delete2;
        private System.Windows.Forms.TextBox textBox_delete2;
        private System.Windows.Forms.Button button_delete2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.ComboBox comboBox_delete;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.Button button_arrow_down;
        private System.Windows.Forms.Button button_arrow_up;
        private System.Windows.Forms.Label label_interogari;
        private System.Windows.Forms.TextBox textBox_interogari_promotie;
    }
}

