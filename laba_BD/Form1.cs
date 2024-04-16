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

namespace laba_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
        }
        public const string ConnectionString = "Server=192.168.0.20; Database=Store; User Id = sa; Password = eeeeee2020";
        private void LoadData(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }
        public class ComboBoxItem
        {
            public string Item { get; set; }
            public override string ToString()
            {
                return Item;
            }
        }

        private void FillComboBoxes()
        {
            string query = "SELECT Surname FROM Buyer";
            nameEdit.Items.Clear();
            namedel.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Surname = Convert.ToString(reader["Surname"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = Surname
                            };
                            nameEdit.Items.Add(item);
                            namedel.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT Organization FROM Suppler";
            OrgEdit.Items.Clear();
            orgdel.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Organization = Convert.ToString(reader["Organization"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = Organization
                            };
                            OrgEdit.Items.Add(item);
                            orgdel.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT ProductName FROM Product";
            NameProductEdit.Items.Clear();
            ProductNameDel.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ProductName = Convert.ToString(reader["ProductName"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = ProductName
                            };
                            NameProductEdit.Items.Add(item);
                            ProductNameDel.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT ChequeID FROM Cheque";
            IDChequeEdit.Items.Clear();
            IDChequeDel.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ChequeID = Convert.ToString(reader["ChequeID"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = ChequeID
                            };
                            IDChequeEdit.Items.Add(item);
                            IDChequeDel.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT Organization FROM Suppler";
            OrgComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string Organization = Convert.ToString(reader["Organization"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = Organization
                            };
                            OrgComboBox.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT ProductName FROM Product";
            ProductComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ProductName = Convert.ToString(reader["ProductName"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = ProductName
                            };
                            ProductComboBox.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT surname FROM Buyer";
            BuyerComboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string surname = Convert.ToString(reader["surname"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = surname
                            };
                            BuyerComboBox.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT surname FROM Buyer";
            BuyerComboBoxEdit.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string surname = Convert.ToString(reader["surname"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = surname
                            };
                            BuyerComboBoxEdit.Items.Add(item);
                        }
                    }
                }
            }

            query = "SELECT ProductName FROM Product";
            ProductComboBoxEdit.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ProductName = Convert.ToString(reader["ProductName"]);
                            ComboBoxItem item = new ComboBoxItem()
                            {
                                Item = ProductName
                            };
                            ProductComboBoxEdit.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void SequelWithoutReturn(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private DataTable GetData(string query)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    // Открываем соединение с базой данных
                    connection.Open();
                    // Создаем объект команды SQL
                    SqlCommand command = new SqlCommand(query, connection);
                    // Создаем адаптер данных для заполнения DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    // Заполняем DataTable результатами запроса
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Обработка ошибок (например, вывод сообщения об ошибке)
                    MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                }
                finally
                {
                    // Закрываем соединение с базой данных
                    connection.Close();
                }

                return dataTable;
            }
        }
        private void DisplayStatistics()
        {
            string query = @"SELECT MAX(PriceCheque) As MaxCost,
                                    AVG(PriceCheque) As AvgCost,
                                    SUM(PriceCheque) As TotalCost FROM Cheque";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal maxCost = Convert.ToDecimal(reader["MaxCost"]);
                            decimal avgCost = Convert.ToDecimal(reader["AvgCost"]);
                            decimal totalCost = Convert.ToDecimal(reader["TotalCost"]);

                            label80.Text = $"Максимальная стоимость: {maxCost}";
                            label81.Text = $"Средняя стоимость: {avgCost}";
                            label82.Text = $"Полная стоимость всех товаров: {totalCost}";
                        }
                    }
                }
            }
        }

        private String GetSupplerIdByOrganization(string organizationName)
        {
            string query = $"SELECT SupplerID FROM Suppler WHERE Organization = '{organizationName}'";
            DataTable dataTable = GetData(query);
            return Convert.ToString(dataTable.Rows[0]["SupplerID"]);
        }
        private String GetBuyerIdBySurname(string buyerSurname)
        {
            string query = $"SELECT BuyerID FROM Buyer WHERE surname = '{buyerSurname}'";
            DataTable dataTable = GetData(query);
            return Convert.ToString(dataTable.Rows[0]["BuyerID"]);
        }

        private String GetProductIdByProductName(string productName)
        {
            string query = $"SELECT ProductID FROM Product WHERE ProductName = '{productName}'";
            DataTable dataTable = GetData(query);
            return Convert.ToString(dataTable.Rows[0]["ProductID"]);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            LoadData("SELECT ChequeID as 'Номер чека', Product.ProductName, Buyer.surname, PriceCheque, Payment FROM Cheque " +
                "INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                "INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID");
            DisplayStatistics();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData("SELECT Suppler.Organization as OrgName, ProductName, Price, Have, Guarantee FROM Product " +
                "LEFT JOIN Suppler ON Suppler.SupplerID = Product.SupplerID");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadData("SELECT UPPER(surname), Birthday, Gender FROM Buyer");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadData("SELECT Organization, Country FROM Suppler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string surname = SurnametextBox.Text;
            string birthday = BirthdaytextBox.Text;
            string gender = GendertextBox.Text;
            SequelWithoutReturn($"INSERT INTO Buyer (surname, Birthday, Gender) VALUES ('{surname}', '{birthday}', '{gender}')");
            LoadData("SELECT UPPER(surname), Birthday, Gender FROM Buyer");
            FillComboBoxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string country = CountrytextBox.Text;
                string organization = OrgtextBox.Text;
                SequelWithoutReturn($"INSERT INTO Suppler (country, organization) VALUES ('{country}', '{organization}')");
                LoadData("SELECT Organization, Country FROM Suppler");
                FillComboBoxes();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SuppID = GetSupplerIdByOrganization(OrgComboBox.Text);
            string Name = NametextBox.Text;
            string Cost = CosttextBox.Text;
            string Have = HavetextBox.Text;
            string Guarant = GuaranttextBox.Text;
            SequelWithoutReturn($"INSERT INTO Product (SupplerID, ProductName, Price, Have, Guarantee) VALUES ('{SuppID}', '{Name}', '{Cost}','{Have}','{Guarant}')");
            LoadData("SELECT Suppler.Organization as OrgName, ProductName, Price, Have, Guarantee FROM Product " +
                "LEFT JOIN Suppler ON Suppler.SupplerID = Product.SupplerID");
            FillComboBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IDProduct = GetProductIdByProductName(ProductComboBox.Text);
            string IDBuyer = GetBuyerIdBySurname(BuyerComboBox.Text);
            string Costcheque = CostChequetextBox.Text;
            string payment = PaymanttextBox.Text;
            SequelWithoutReturn($"INSERT INTO Cheque (ProductID, BuyerID, PriceCheque, Payment) VALUES ('{IDProduct}', '{IDBuyer}', '{Costcheque}','{payment}')");
            LoadData("SELECT ChequeID as 'Номер чека', Product.ProductName, Buyer.surname, PriceCheque, Payment FROM Cheque " +
                "INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                "INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID");
            FillComboBoxes();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string birthday = BirthdayEdit.Text;  
            string gender = GenderEdit.Text;  
            string name = nameEdit.Text;  
            SequelWithoutReturn($"UPDATE Buyer SET Birthday = '{birthday}', Gender = '{gender}' WHERE surname = '{name}'");
            LoadData("SELECT UPPER(surname), Birthday, Gender FROM Buyer");
            FillComboBoxes();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string organization = OrgEdit.Text;
            string country = CountryEdit.Text;
            SequelWithoutReturn($"UPDATE Suppler SET Country = '{country}' WHERE Organization = '{organization}'");
            LoadData("SELECT Organization, Country FROM Suppler");
            FillComboBoxes();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string nameproduct = NameProductEdit.Text;
            string cost = CostEdit.Text;
            string have = HaveEdit.Text;
            string garant = GrarantEdit.Text;
            SequelWithoutReturn($"UPDATE Product SET Price = {cost}, Have = '{have}', Guarantee = '{garant}' WHERE ProductName = '{nameproduct}'");
            LoadData("SELECT Suppler.Organization as OrgName, ProductName, Price, Have, Guarantee FROM Product " +
                "LEFT JOIN Suppler ON Suppler.SupplerID = Product.SupplerID");
            FillComboBoxes();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string NumberCheque = IDChequeEdit.Text;
            string costcheque = CostChequeEdit.Text;
            string payment = PaymentEdit.Text;
            string ProductName = ProductComboBoxEdit.Text;
            string surname = BuyerComboBoxEdit.Text;
            SequelWithoutReturn($"UPDATE Cheque SET Payment = '{payment}', PriceCheque = '{costcheque}', " +
                $"ProductID = (SELECT ProductID FROM Product WHERE ProductName = '{ProductName}'), " +
                $"BuyerID = (SELECT BuyerID FROM Buyer WHERE surname = '{surname}') WHERE ChequeID = '{NumberCheque}'");
            LoadData("SELECT ChequeID as 'Номер чека', Product.ProductName, Buyer.surname, PriceCheque, Payment FROM Cheque " +
                "INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                "INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID");
            FillComboBoxes();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string name = namedel.Text;
            SequelWithoutReturn($"DELETE FROM Buyer WHERE surname = '{name}'");
            LoadData("SELECT UPPER(surname), Birthday, Gender FROM Buyer");
            FillComboBoxes();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string org = orgdel.Text;
            SequelWithoutReturn($"DELETE FROM Suppler WHERE Organization = '{org}'");
            LoadData("SELECT Organization, Country FROM Suppler");
            FillComboBoxes();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string productname = ProductNameDel.Text;
            SequelWithoutReturn($"DELETE FROM Product WHERE ProductName = '{productname}'");
            LoadData("SELECT Suppler.Organization as OrgName, ProductName, Price, Have, Guarantee FROM Product " +
                "LEFT JOIN Suppler ON Suppler.SupplerID = Product.SupplerID");
            FillComboBoxes();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string IDCheque = IDChequeDel.Text;
            SequelWithoutReturn($"DELETE FROM Cheque WHERE ChequeID = '{IDCheque}'");
            LoadData("SELECT ChequeID as 'Номер чека', Product.ProductName, Buyer.surname, PriceCheque, Payment FROM Cheque " +
                "INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                "INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID");
            FillComboBoxes();
        }

        private void nameEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedName = nameEdit.SelectedItem.ToString(); // Получаем выбранное имя из комбобокса
            string query = $"SELECT Birthday, Gender FROM Buyer WHERE surname = '{selectedName}'";
            DataTable dataTable = GetData(query);

            string birthday = dataTable.Rows[0]["Birthday"].ToString();
            string gender = dataTable.Rows[0]["Gender"].ToString();

            BirthdayEdit.Text = birthday;
            GenderEdit.Text = gender;
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ProductComboBox.SelectedItem.ToString(); // Получаем выбранное имя из комбобокса
            string query = $"SELECT Price FROM Product WHERE ProductName = '{selectedProduct}'";
            DataTable dataTable = GetData(query);

            string product = dataTable.Rows[0]["Price"].ToString();

            CostChequetextBox.Text = product;
        }

        private void OrgEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrg = OrgEdit.SelectedItem.ToString(); // Получаем выбранное имя из комбобокса
            string query = $"SELECT Country FROM Suppler WHERE Organization = '{selectedOrg}'";
            DataTable dataTable = GetData(query);

            string Country = dataTable.Rows[0]["Country"].ToString();

            CountryEdit.Text = Country;
        }

        private void NameProductEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProductName = NameProductEdit.SelectedItem.ToString(); // Получаем выбранное имя из комбобокса
            string query = $"SELECT Price, Have, Guarantee FROM Product WHERE ProductName = '{ProductName}'";
            DataTable dataTable = GetData(query);

            string Price = dataTable.Rows[0]["Price"].ToString();
            string Have = dataTable.Rows[0]["Have"].ToString();
            string Guarantee = dataTable.Rows[0]["Guarantee"].ToString();

            CostEdit.Text = Price;
            HaveEdit.Text = Have;
            GrarantEdit.Text = Guarantee;
        }

        private void IDChequeEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBoxItem selectedItem = (ComboBoxItem)IDChequeEdit.SelectedItem;

            string selectedChequeIdText = IDChequeEdit.SelectedItem.ToString();

            string query = $"SELECT Product.ProductName, Buyer.surname, Cheque.PriceCheque, Cheque.Payment " +
                           $"FROM Cheque " +
                           $"INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                           $"INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID " +
                           $"WHERE Cheque.ChequeID = {selectedChequeIdText}";
            DataTable dataTable = GetData(query);

            ProductComboBoxEdit.Text = dataTable.Rows[0]["ProductName"].ToString();
            BuyerComboBoxEdit.Text = dataTable.Rows[0]["surname"].ToString();
            CostChequeEdit.Text = dataTable.Rows[0]["PriceCheque"].ToString();
            PaymentEdit.Text = dataTable.Rows[0]["Payment"].ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            LoadData("(SELECT 'Product' AS Source, ProductName AS Name, Price AS Value FROM Product) UNION (SELECT 'Cheque' AS Source, NULL AS Name, PriceCheque AS Value FROM Cheque)");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            LoadData("SELECT ChequeID as 'Номер чека', Product.ProductName, Buyer.surname, PriceCheque, Payment FROM Cheque " +
                "INNER JOIN Product ON Cheque.ProductID = Product.ProductID " +
                "INNER JOIN Buyer ON Cheque.BuyerID = Buyer.BuyerID ORDER BY Product.ProductName");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            LoadData("SELECT Suppler.Organization as OrgName, ProductName, Price, Have, Guarantee FROM Product " +
                "LEFT JOIN Suppler ON Suppler.SupplerID = Product.SupplerID WHERE Price > 1000");
        }
    }
}
