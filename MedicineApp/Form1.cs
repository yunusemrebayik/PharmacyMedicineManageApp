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

namespace MedicineApp
{
  public partial class Form1 : Form
  {
    private string connectionString = "Data Source=BAYIK\\SQLEXPRESS;Initial Catalog=pharmacymedicinestock;Integrated Security=True;";
    private int selectedId = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void showData()
    {
      listView1.Items.Clear();

      using (SqlConnection connect = new SqlConnection(connectionString))
      {
        connect.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM Medicine", connect);

        using (SqlDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            ListViewItem item = new ListViewItem();
            item.Text = reader["id"].ToString();
            item.SubItems.Add(reader["medicineName"].ToString());
            item.SubItems.Add(reader["medicineCompany"].ToString());
            item.SubItems.Add(reader["medicineType"].ToString());
            item.SubItems.Add(reader["medicineStockQuantity"].ToString());
            listView1.Items.Add(item);
          }
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      showData();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        using (SqlConnection connect = new SqlConnection(connectionString))
        {
          connect.Open();
          SqlCommand command = new SqlCommand("INSERT INTO Medicine(id, medicineName, medicineCompany, medicineType, medicineStockQuantity) VALUES(@id, @medicineName, @medicineCompany, @medicineType, @medicineStockQuantity)", connect);

          command.Parameters.AddWithValue("@id", textBox1.Text);
          command.Parameters.AddWithValue("@medicineName", textBox2.Text);
          command.Parameters.AddWithValue("@medicineCompany", textBox3.Text);
          command.Parameters.AddWithValue("@medicineType", textBox4.Text);
          command.Parameters.AddWithValue("@medicineStockQuantity", textBox5.Text);

          command.ExecuteNonQuery();
        }
        showData();
        ClearTextBoxes();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Hata oluştu: " + ex.Message);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (selectedId != 0)
      {
        try
        {
          using (SqlConnection connect = new SqlConnection(connectionString))
          {
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Medicine WHERE id = @id", connect);
            command.Parameters.AddWithValue("@id", selectedId);
            command.ExecuteNonQuery();
          }
          showData();
          ClearTextBoxes();
          selectedId = 0;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Hata oluştu: " + ex.Message);
        }
      }
    }

    private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (listView1.SelectedItems.Count > 0)
      {
        selectedId = int.Parse(listView1.SelectedItems[0].Text);
        textBox1.Text = selectedId.ToString();
        textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
        textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
        textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (selectedId != 0)
      {
        try
        {
          using (SqlConnection connect = new SqlConnection(connectionString))
          {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Medicine SET medicineName = @medicineName, medicineCompany = @medicineCompany, medicineType = @medicineType, medicineStockQuantity = @medicineStockQuantity WHERE id = @id", connect);

            command.Parameters.AddWithValue("@id", selectedId);
            command.Parameters.AddWithValue("@medicineName", textBox2.Text);
            command.Parameters.AddWithValue("@medicineCompany", textBox3.Text);
            command.Parameters.AddWithValue("@medicineType", textBox4.Text);
            command.Parameters.AddWithValue("@medicineStockQuantity", textBox5.Text);

            command.ExecuteNonQuery();
          }
          showData();
          ClearTextBoxes();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Hata oluştu: " + ex.Message);
        }
      }
    }

    private void ClearTextBoxes()
    {
      textBox1.Clear();
      textBox2.Clear();
      textBox3.Clear();
      textBox4.Clear();
      textBox5.Clear();
    }
  }
}
