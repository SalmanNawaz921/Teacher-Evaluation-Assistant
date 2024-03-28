using DBMIDProject_2022_CS_138;
using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DBMIDProject_2022_CS_138s
{
    // Implement the method directly in a class
    internal class UtilisImplementation
    {
        public static bool ValidateFirstName(string firstName)
        {
            // Define a regular expression to match only letters
            Regex regex = new Regex("^[a-zA-Z \t\r\n\f]+$");
            // Check if the input matches the regular expression
            if (!regex.IsMatch(firstName))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid first name. The name should contain only letters.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }
        public static bool ValidateLastName(string LastName)
        {
            // Define a regular expression to match only letters
            Regex regex = new Regex("^[a-zA-Z\\s]*$");
            // Check if the input matches the regular expression
            if (!regex.IsMatch(LastName))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid Last name. The name should contain only letters.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }
        public static bool ValidateInput(int input)
        {
            if (input >= 1 && input <= 100)
            {
                return true;
            }
            else
            {
                Guna.UI2.WinForms.MessageDialog.Show("Input value must be between 1 and 100.");
                return false;
            }
        }

        public static bool ValidateCLO(string cloNumber)
        {
            // Define a regular expression to match a valid CLO number format
            Regex regex = new Regex("^[a-zA-Z \t\r\n\f]+$");
            // Check if the input matches the regular expression
            if (!regex.IsMatch(cloNumber))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid CLO ", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }

        public static bool ValidateRegistrationNumber(string registrationNumber)
        {
            // Define a regular expression to match a valid registration number format
            Regex regex = new Regex(@"^(20[0-1][0-9]|202[0-3])-[A-Za-z]{2,}-\d{1,}$");

            // Check if the input matches the regular expression
            if (!regex.IsMatch(registrationNumber))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid registration number in the format of 2021-CS-13 or 2021-CS-123 and ensure the year is between 2000 and 2023.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }

        public static bool ValidateEmail(string email)
        {
            // Define a regular expression to match a valid email address format
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            // Check if the input matches the regular expression
            if (!regex.IsMatch(email))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid email address.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Define a regular expression to match a valid Pakistan phone number format with or without hyphen
            Regex regex = new Regex(@"^(03[0-9]{2}-?[0-9]{7})?$");

            // Check if the input matches the regular expression
            if (!regex.IsMatch(phoneNumber))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid phone number in the format of 03xx-xxxxxxx or 03xxxxxxxxx.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }
        public static bool ValidateAssessName(string firstName)
        {
            // Define a regular expression to match letters and digits
            Regex regex = new Regex("^[a-zA-Z0-9\\s]+$");

            // Check if the input matches the regular expression
            if (!regex.IsMatch(firstName))
            {
                // Display an error message to the user
                Guna.UI2.WinForms.MessageDialog.Show("Please enter a valid  name. The name should contain only letters.", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Dark);
                return false;
            }
            return true;
        }

        public static void sortStudent(string sortBy, Guna2DataGridView dataGridView1)
        {
            var con = Configuration.getInstance().getConnection();
            string sortColumn = sortBy;
            if (sortColumn != "")
            {
                string sqlQuery = "Select Id,RegistrationNumber,FirstName,LastName,Contact,Email from Student where Status=5 ORDER BY " + sortColumn;
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public static void search(string query, string searchBy, Guna2DataGridView dataGridView1)
        {
            var con = Configuration.getInstance().getConnection();
            //string search = searchBy;
            //string a = search.ToString();
            if (searchBy != "")
            {

                SqlCommand cmd = new SqlCommand($"{query}" + " LIKE '%" + searchBy + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

        }
    }
}
