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

namespace CalorieTracker
{
    public partial class FormFoodList : Form
    {
        private Dictionary<string, (int Carbs, int Fats, int Proteins)> foodNutritionalValues = new Dictionary<string, (int Carbs, int Fats, int Proteins)>
        {
            {"Apple", (25, 0, 0)},
            {"Banana", (27, 0, 1)},
            {"Bacon", (1, 12, 3)},
            {"Berries", (14, 0, 1)},
            {"Bread", (14, 1, 2)},
            {"Cereal", (30, 2, 3)},
            {"Egg", (1, 5, 6)},
            {"Milk", (12, 8, 8)},
            {"Oatmeal", (27, 3, 5)},
            {"Pancake", (28, 5, 6)},
            {"Toast", (15, 2, 3)},
            {"Beef", (0, 15, 23)},
            {"Chicken", (0, 3, 27)},
            {"Fish", (0, 3, 22)},
            {"Fruits", (25, 0, 1)},
            {"Hotdog", (2, 15, 6)},
            {"Noodles", (27, 4, 5)},
            {"Pasta", (31, 1, 6)},
            {"Pork", (0, 21, 20)},
            {"Rice", (28, 0, 3)},
            {"Vegetables", (10, 0, 2)},
        };
        public FormFoodList()
        {
            InitializeComponent();
            SetupDataGridView(); // Setup columns
            DisplayFoodItems(); // Load data
            FoodItemsDGV.SelectionChanged += FoodItemsDGV_SelectionChanged;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rein\OneDrive\Documents\NutrinometerDb.mdf;Integrated Security=True;Connect Timeout=30;");

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int CalculateTotalCalories(int carbs, int fats, int proteins)
        {
            int totalCalories = (carbs * 4) + (fats * 9) + (proteins * 4);
            return totalCalories;
        }

        private void DisplayFoodItems()
        {
            con.Open();
            string Query = "SELECT Num, Category, Food, Portion, Carbs, Fats, Proteins, [Total Calories], Date FROM FoodItemsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FoodItemsDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clear()
        {
            categoryCB.Text = "";
            foodCB.Text = "";
            portionCB.Text = "";
            carbs_textBox.Text = "";
            fats_textBox.Text = "";
            proteins_textBox.Text = "";
            totalCal_textBox.Text = "";
            dateTimePicker1.Text = "";
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (categoryCB.Text == "" || foodCB.Text == "" || portionCB.Text == "" || carbs_textBox.Text == "" || fats_textBox.Text == "" || proteins_textBox.Text == "" || totalCal_textBox.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // Parse input values
                    int carbs = int.Parse(carbs_textBox.Text);
                    int fats = int.Parse(fats_textBox.Text);
                    int proteins = int.Parse(proteins_textBox.Text);

                    // Calculate total calories
                    int totalCalories = CalculateTotalCalories(carbs, fats, proteins);

                    // Update the total calories text box
                    totalCal_textBox.Text = totalCalories.ToString();

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FoodItemsTbl (Category, Food, Portion, Carbs, Fats, Proteins, [Total Calories], Date) values(@C,@F, @P, @Ca, @Fa, @Pro, @TCal, @D)", con);
                    cmd.Parameters.AddWithValue("@C", categoryCB.Text);
                    cmd.Parameters.AddWithValue("@F", foodCB.Text);
                    cmd.Parameters.AddWithValue("@P", portionCB.Text);
                    cmd.Parameters.AddWithValue("@Ca", carbs_textBox.Text);
                    cmd.Parameters.AddWithValue("@Fa", fats_textBox.Text);
                    cmd.Parameters.AddWithValue("@Pro", proteins_textBox.Text);
                    cmd.Parameters.AddWithValue("@TCal", totalCal_textBox.Text);
                    cmd.Parameters.AddWithValue("@D", dateTimePicker1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Item Added");
                    con.Close();
                    DisplayFoodItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (FoodItemsDGV.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = FoodItemsDGV.SelectedRows[0];
                    int num = int.Parse(row.Cells["Num"].Value.ToString());

                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FoodItemsTbl SET Category=@C, Food=@F, Portion=@P, Carbs=@Ca, Fats=@Fa, Proteins=@Pro, [Total Calories]=@TCal, Date=@D WHERE Num=@Num", con);
                    cmd.Parameters.AddWithValue("@C", categoryCB.Text);
                    cmd.Parameters.AddWithValue("@F", foodCB.Text);
                    cmd.Parameters.AddWithValue("@P", portionCB.Text);
                    cmd.Parameters.AddWithValue("@Ca", carbs_textBox.Text);
                    cmd.Parameters.AddWithValue("@Fa", fats_textBox.Text);
                    cmd.Parameters.AddWithValue("@Pro", proteins_textBox.Text);
                    cmd.Parameters.AddWithValue("@TCal", totalCal_textBox.Text);
                    cmd.Parameters.AddWithValue("@D", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Num", num);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Food Item Updated");
                    DisplayFoodItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No row selected to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (FoodItemsDGV.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = FoodItemsDGV.SelectedRows[0];
                    int num = int.Parse(row.Cells["Num"].Value.ToString());

                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM FoodItemsTbl WHERE Num=@Num", con);
                    cmd.Parameters.AddWithValue("@Num", num);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Food Item Deleted");
                    DisplayFoodItems();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No row selected to delete");
            }
        }

        private void signOut_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void foodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNutritionalValues();
        }

        private void portionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNutritionalValues();
        }

        private void UpdateNutritionalValues()
        {
            if (foodCB.SelectedItem != null && portionCB.SelectedItem != null)
            {
                string selectedFood = foodCB.SelectedItem.ToString();
                string selectedPortion = portionCB.SelectedItem.ToString();

                if (selectedFood == "other..." || selectedPortion == "other...")
                {
                    carbs_textBox.ReadOnly = false;
                    fats_textBox.ReadOnly = false;
                    proteins_textBox.ReadOnly = false;
                    totalCal_textBox.ReadOnly = false;

                    carbs_textBox.Text = "";
                    fats_textBox.Text = "";
                    proteins_textBox.Text = "";
                    totalCal_textBox.Text = "";
                }
                else if (foodNutritionalValues.ContainsKey(selectedFood))
                {
                    int portion = int.Parse(selectedPortion);
                    var (Carbs, Fats, Proteins) = foodNutritionalValues[selectedFood];

                    Carbs *= portion;
                    Fats *= portion;
                    Proteins *= portion;

                    carbs_textBox.ReadOnly = true;
                    fats_textBox.ReadOnly = true;
                    proteins_textBox.ReadOnly = true;
                    totalCal_textBox.ReadOnly = true;

                    carbs_textBox.Text = Carbs.ToString();
                    fats_textBox.Text = Fats.ToString();
                    proteins_textBox.Text = Proteins.ToString();

                    int totalCalories = CalculateTotalCalories(Carbs, Fats, Proteins);
                    totalCal_textBox.Text = totalCalories.ToString();
                }
            }
        }

        private void SetupDataGridView()
        {
            FoodItemsDGV.AutoGenerateColumns = false;
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Num", DataPropertyName = "Num"});
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "Category" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Food", DataPropertyName = "Food" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Portion", DataPropertyName = "Portion" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Carbs", DataPropertyName = "Carbs" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fats", DataPropertyName = "Fats" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Proteins", DataPropertyName = "Proteins" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Calories", DataPropertyName = "Total Calories" });
            FoodItemsDGV.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date", DataPropertyName = "Date" });
        }

        private void carbs_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fats_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proteins_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalCal_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FoodItemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FoodItemsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (FoodItemsDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = FoodItemsDGV.SelectedRows[0];
                categoryCB.Text = row.Cells[1].Value.ToString();
                foodCB.Text = row.Cells[2].Value.ToString();
                portionCB.Text = row.Cells[3].Value.ToString();
                carbs_textBox.Text = row.Cells[4].Value.ToString();
                fats_textBox.Text = row.Cells[5].Value.ToString();
                proteins_textBox.Text = row.Cells[6].Value.ToString();
                totalCal_textBox.Text = row.Cells[7].Value.ToString();
                dateTimePicker1.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
