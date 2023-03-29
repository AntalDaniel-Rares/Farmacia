using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        string[] array_interogari = new string[5];
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            hide_lot_insert(true);
            hide_categorie_insert(true);
            hide_lot_update(true);
            hide_categorie_update(true);
            hide_lot_delete(true);
            hide_categorie_delete(true);
            hide_interogari(true);
            textBox_interogari_promotie.Visible = false;
            CenterControlInParent(button_login, 0, 0);
            CenterControlInParent(textBox1, 0, -60);
            CenterControlInParent(textBox2, 0, -30);
            CenterControlInParent(label1, -70, -63);
            CenterControlInParent(label2, -70, -33);
            dataGridView1.Hide();
            textBox1.Focus();
            String DataSource;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterControlInParent(button_login, 0, 0);
            CenterControlInParent(textBox2, 0, -30);
            CenterControlInParent(textBox1, 0, -55);
            CenterControlInParent(label1, -70, -56);
            CenterControlInParent(label2, -70, -31);
            CenterControlInParent(dataGridView1, 0, -55);

            var findbox = this.Controls.Find("mybox", true).FirstOrDefault();
            if (findbox != null)
            {
                CenterControlInParent(findbox, -310, -280);
            }

        }

        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-7U8UB7F\SQLEXPRESS; Initial Catalog = Farmacia; Integrated Security = True ");
        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, passsword;
            username = textBox1.Text;
            passsword = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    passsword = textBox2.Text;

                    //MessageBox.Show("Login cu succes!");

                    textBox1.Hide();
                    textBox2.Hide();
                    button_login.Hide();
                    label1.Hide();
                    label2.Hide();
                    //FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    Task1();
                    Task_update();
                    Task_delete();
                    hide_interogari(false);
                    Interogari();
                }
                else
                {
                    MessageBox.Show("Username sau prola gresita!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Eroare");
            }
            finally
            {
                conn.Close();
            }
        }

        private void CenterControlInParent(Control ctrlToCenter, int delay_width, int delay_height)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2 + delay_width;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2 + delay_height;
        }

        private void Task1()
        {
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(280, 130);
            mybox.Name = "mybox";

            mybox.Size = new Size(216, 26);

            mybox.Items.Add("Select tabel...");
            mybox.Items.Add("Medicament");
            mybox.Items.Add("Lot");
            mybox.Items.Add("Promotie");
            mybox.Items.Add("Categorie");
            mybox.Items.Add("Medicament_Furnizor");
            mybox.Items.Add("Furnizor");
            mybox.SelectedItem = "Select tabel...";
            this.Controls.Add(mybox);

            mybox.SelectedIndexChanged += new System.EventHandler(this.Box_change);
        }
        private void Box_change(object sender, EventArgs e)
        {
            ComboBox mybox = sender as ComboBox;
            DataTable data = new DataTable();

            if (mybox.SelectedItem.ToString() == "Select tabel...")
                return;

            if (mybox.SelectedItem.ToString() == "Medicament")
            {
                SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Medicament", conn);
                tab_med.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(true);
                hide_lot_insert(true);
                hide_lot_update(true);
                hide_categorie_update(true);
                hide_lot_delete(true);
                hide_categorie_delete(true);
            }
            else if (mybox.SelectedItem.ToString() == "Promotie")
            {
                SqlDataAdapter tab_promotie = new SqlDataAdapter("SELECT * FROM Promotie", conn);
                tab_promotie.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(true);
                hide_lot_insert(true);
                hide_lot_update(true);
                hide_categorie_update(true);
                hide_lot_delete(true);
                hide_categorie_delete(true);
            }
            else if (mybox.SelectedItem.ToString() == "Categorie")
            {

                SqlDataAdapter tab_categorie = new SqlDataAdapter("SELECT * FROM Categorie", conn);
                tab_categorie.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(false);
                hide_lot_insert(true);
                hide_lot_update(true);
                hide_categorie_update(false);
                hide_lot_delete(true);
                hide_categorie_delete(false);
            }
            else if (mybox.SelectedItem.ToString() == "Lot")
            {
                SqlDataAdapter tab_lot = new SqlDataAdapter("SELECT * FROM Lot", conn);
                tab_lot.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(true);
                hide_lot_insert(false);
                hide_lot_update(false);
                hide_categorie_update(true);
                hide_lot_delete(false);
                hide_categorie_delete(true);
            }
            else if (mybox.SelectedItem.ToString() == "Medicament_Furnizor")
            {
                SqlDataAdapter tab_medicament_furnizor = new SqlDataAdapter("SELECT * FROM Medicament_Furnizor", conn);
                tab_medicament_furnizor.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(true);
                hide_lot_insert(true);
                hide_lot_update(true);
                hide_categorie_update(true);
                hide_lot_delete(true);
                hide_categorie_delete(true);
            }
            else if (mybox.SelectedItem.ToString() == "Furnizor")
            {
                SqlDataAdapter tab_furnizor = new SqlDataAdapter("SELECT * FROM Furnizor", conn);
                tab_furnizor.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Visible = true;
                dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                hide_categorie_insert(true);
                hide_lot_insert(true);
                hide_lot_update(true);
                hide_categorie_update(true);
                hide_lot_delete(true);
                hide_categorie_delete(true);
            }
            conn.Close();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            string string_id_categorie = textBox3.Text;
            string string_denumire = textBox4.Text;
            bool pret_impus = checkBox1.Checked;

            String query = "INSERT INTO Categorie (ID_Categorie,Denumire,Pret_impus) VALUES (@id,@nume,@pret)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", string_id_categorie);
            command.Parameters.AddWithValue("@nume", string_denumire);
            command.Parameters.AddWithValue("@pret", pret_impus);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Categorie", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }

        private void hide_categorie_insert(bool hide)
        {
            if (!hide)
            {
                this.textBox3.Show();
                this.textBox4.Show();
                this.label3.Show();
                this.label4.Show();
                this.label5.Show();
                this.checkBox1.Show();
                this.insert_button.Show();
            }
            else
            {
                this.textBox3.Hide();
                this.textBox4.Hide();
                this.label3.Hide();
                this.label4.Hide();
                this.label5.Hide();
                this.checkBox1.Hide();
                this.insert_button.Hide();
            }

        }

        private void button2_insert_Click(object sender, EventArgs e)
        {
            string string_id_lot = textBox_id_lot.Text;
            string string_data = textBox_data_expirare.Text;
            string string_id_promotie = textBox_id_promotie.Text;
            string string_cantitate = textBox_cantitate.Text;

            String query = "INSERT INTO Lot (ID_lot,Data_expirare,ID_promotie,[Cantitate(kg)]) VALUES (@id_lot,@data,@id_promotie,@cantitate)";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id_lot", string_id_lot);
            command.Parameters.AddWithValue("@data", string_data);
            command.Parameters.AddWithValue("@id_promotie", string_id_promotie);
            command.Parameters.AddWithValue("@cantitate", string_cantitate);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");

            //dataGridView1.Update();
            //dataGridView1.Refresh();

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Lot", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }


        private void hide_lot_insert(bool hide)
        {
            if (!hide)
            {
                this.textBox_id_lot.Show();
                this.textBox_id_promotie.Show();
                this.textBox_data_expirare.Show();
                this.textBox_cantitate.Show();
                this.label_cantitate.Show();
                this.label_data_expirare.Show();
                this.label_id_lot.Show();
                this.label_id_promotie.Show();
                this.button2_insert.Show();
            }
            else
            {
                this.textBox_id_lot.Hide();
                this.textBox_id_promotie.Hide();
                this.textBox_data_expirare.Hide();
                this.textBox_cantitate.Hide();
                this.label_cantitate.Hide();
                this.label_data_expirare.Hide();
                this.label_id_lot.Hide();
                this.label_id_promotie.Hide();
                this.button2_insert.Hide();
            }

        }

        private void Task_update()
        {
            this.comboBox_set.Items.Add("ID_lot");
            this.comboBox_set.Items.Add("Data_expirare");
            this.comboBox_set.Items.Add("ID_promotie");
            this.comboBox_set.Items.Add("[Cantitate(kg)]");

            this.comboBox_where.Items.Add("ID_lot");
            this.comboBox_where.Items.Add("Data_expirare");
            this.comboBox_where.Items.Add("ID_promotie");
            this.comboBox_where.Items.Add("[Cantitate(kg)]");

            this.comboBox_set2.Items.Add("ID_Categorie");
            this.comboBox_set2.Items.Add("Denumire");
            this.comboBox_set2.Items.Add("Pret_impus");

            this.comboBox_where2.Items.Add("ID_Categorie");
            this.comboBox_where2.Items.Add("Denumire");
            this.comboBox_where2.Items.Add("Pret_impus");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Lot SET " + this.comboBox_set.SelectedItem.ToString() + " = @set Where " + this.comboBox_where.SelectedItem.ToString() + " = @where";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@set", this.textBox_set.Text);
            command.Parameters.AddWithValue("@where", this.textBox_where.Text);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error updating data into Database!");

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Lot", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }

        private void hide_lot_update(bool hide)
        {
            if (!hide)
            {
                this.label_set.Show();
                this.comboBox_set.Show();
                this.textBox_set.Show();
                this.label_where.Show();
                this.comboBox_where.Show();
                this.textBox_where.Show();
                this.button_update.Show();
            }
            else
            {
                this.label_set.Hide();
                this.comboBox_set.Hide();
                this.textBox_set.Hide();
                this.label_where.Hide();
                this.comboBox_where.Hide();
                this.textBox_where.Hide();
                this.button_update.Hide();
            }

        }

        private void button_update2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Categorie SET " + this.comboBox_set2.SelectedItem.ToString() + " = @set Where " + this.comboBox_where2.SelectedItem.ToString() + " = @where";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@set", this.textBox_set2.Text);
            command.Parameters.AddWithValue("@where", this.textBox_where2.Text);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error updating data into Database!");

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Categorie", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }

        private void hide_categorie_update(bool hide)
        {
            if (!hide)
            {
                this.label_set2.Show();
                this.comboBox_set2.Show();
                this.textBox_set2.Show();
                this.label_where2.Show();
                this.comboBox_where2.Show();
                this.textBox_where2.Show();
                this.button_update2.Show();
            }
            else
            {
                this.label_set2.Hide();
                this.comboBox_set2.Hide();
                this.textBox_set2.Hide();
                this.label_where2.Hide();
                this.comboBox_where2.Hide();
                this.textBox_where2.Hide();
                this.button_update2.Hide();
            }

        }

        private void Task_delete()
        {
            this.comboBox_delete2.Items.Add("ID_lot");
            this.comboBox_delete2.Items.Add("Data_expirare");
            this.comboBox_delete2.Items.Add("ID_promotie");
            this.comboBox_delete2.Items.Add("[Cantitate(kg)]");

            this.comboBox_delete.Items.Add("ID_Categorie");
            this.comboBox_delete.Items.Add("Denumire");
            this.comboBox_delete.Items.Add("Pret_impus");

        }

        private void hide_lot_delete(bool hide)
        {
            if (!hide)
            {
                this.label_delete2.Show();
                this.comboBox_delete2.Show();
                this.textBox_delete2.Show();
                this.button_delete2.Show();
            }
            else
            {
                this.label_delete2.Hide();
                this.comboBox_delete2.Hide();
                this.textBox_delete2.Hide();
                this.button_delete2.Hide();
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categorie WHERE " + comboBox_delete.SelectedItem.ToString() + " = @where";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@where", this.textBox_delete.Text);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error deleting data into Database!");

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Categorie", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }

        private void button_delete2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Lot WHERE " + comboBox_delete2.SelectedItem.ToString() + " = @where";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@where", this.textBox_delete2.Text);

            conn.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error deleting data into Database!");

            DataTable data = new DataTable();
            SqlDataAdapter tab_med = new SqlDataAdapter("SELECT * FROM Lot", conn);
            tab_med.Fill(data);
            dataGridView1.DataSource = data;

            conn.Close();
        }

        private void hide_categorie_delete(bool hide)
        {
            if (!hide)
            {
                this.label_delete.Show();
                this.comboBox_delete.Show();
                this.textBox_delete.Show();
                this.button_delete.Show();
            }
            else
            {
                this.label_delete.Hide();
                this.comboBox_delete.Hide();
                this.textBox_delete.Hide();
                this.button_delete.Hide();
            }

        }

        private void hide_interogari(bool hide)
        {
            button_arrow_up.Visible = !hide;
            button_arrow_down.Visible = !hide;
            label_interogari.Visible = !hide;
        }

        private void button_arrow_up_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 4)
                counter = 0;

            label_interogari.Text = array_interogari[counter];

        }

        private void button_arrow_down_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter == -1)
                counter = 3;


            label_interogari.Text = array_interogari[counter];
        }

        private void Interogari()
        {
            //textBox_interogari_promotie.Visible = true;
            array_interogari[0] = "Toate loturile si cantitatatile ordonate crescator care fac parte din promotia Extraplus.";
            array_interogari[1] = "Toate numele medicamentelor si preturile ordonate crescator care au un pret impus.";
            array_interogari[2] = "Categoriile in care exista macar 1 medicament cu dozaj maxim mai mic decat 10g.";
            array_interogari[3] = "Suma catitatilor cu pretul de vanzare mai mic decat 100lei pentru fiecare an in care urmeaza sa expire intreg lotul.";

        }

        private void label_interogari_Click(object sender, EventArgs e)
        {
            hide_categorie_delete(true);
            hide_categorie_insert(true);
            hide_categorie_update(true);
            hide_lot_delete(true);
            hide_lot_insert(true);
            hide_lot_update(true);

            var findbox = this.Controls.Find("mybox", true).FirstOrDefault();
            ComboBox local_box = (ComboBox)findbox;
            if (findbox != null)
            {
                local_box.SelectedItem = "Select tabel...";
            }

            switch (counter)
            {
                case 0:
                    {
                        string query = "SELECT L.ID_lot, L.[Cantitate(kg)] FROM LOT L INNER JOIN Promotie P ON P.ID_promotie = L.ID_promotie AND P.[Nume promotie] = 'Extraplus' ORDER BY L.[Cantitate(kg)]";

                        DataTable data = new DataTable();
                        SqlDataAdapter tab_med = new SqlDataAdapter(query, conn);
                        tab_med.Fill(data);
                        dataGridView1.Show();
                        dataGridView1.DataSource = data;
                        dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                        break;
                    }
                case 1:
                    {
                        string query = "SELECT M.Denumire, M.Pret_vanzare FROM Medicament M INNER JOIN Categorie C ON C.ID_Categorie = M.ID_categorie AND C.Pret_impus = 1 ORDER BY M.Pret_vanzare";

                        DataTable data = new DataTable();
                        SqlDataAdapter tab_med = new SqlDataAdapter(query, conn);
                        tab_med.Fill(data);
                        dataGridView1.Show();
                        dataGridView1.DataSource = data;
                        dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                        break;
                    }
                case 2:
                    {
                        string query = "SELECT C.ID_categorie, C.Denumire FROM Categorie C INNER JOIN Medicament M ON C.ID_Categorie = M.ID_categorie AND M.Dozaj_maxim < 10.0 GROUP BY C.ID_categorie, C.Denumire HAVING COUNT(M.ID_medicament) > 1";

                        DataTable data = new DataTable();
                        SqlDataAdapter tab_med = new SqlDataAdapter(query, conn);
                        tab_med.Fill(data);
                        dataGridView1.Show();
                        dataGridView1.DataSource = data;
                        dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                        break;
                    }
                case 3:
                    {
                        string query = "SELECT YEAR(L.Data_expirare) AS An, SUM(L.[Cantitate(kg)]) AS Suma_cantitati FROM Lot L INNER JOIN Medicament M ON M.ID_lot = L.ID_lot AND M.Pret_vanzare < 100 GROUP BY L.Data_expirare";

                        DataTable data = new DataTable();
                        SqlDataAdapter tab_med = new SqlDataAdapter(query, conn);
                        tab_med.Fill(data);
                        dataGridView1.Show();
                        dataGridView1.DataSource = data;
                        dataGridView1.Width = dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + 3;
                        break;
                    }
            }

        }
    }
}
