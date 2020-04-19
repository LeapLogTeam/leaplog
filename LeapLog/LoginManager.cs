using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LeapLog
{
    class LoginManager
    {
		SqlConnection connection;

		public LoginManager()
		{

			//C:\USERS\ENGEL\ONEDRIVE\01LONESTAR\2020SPRING\INEW2332PROJECT\GITHUB\LEAPLOG\LEAPLOG\LOGINDB\LOGINDB.MDF
			connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ENGEL\DOWNLOADS\NEW FOLDER\UPDATED 4-17\LEAPLOG\LEAPLOG\LOGINDB\LOGINDB.MDF;Integrated Security=True");
		}

		public LoginManager(string connectionString)
		{
			connection = new SqlConnection(connectionString);
		}

		//<<------ this is create journal method tables------>>
		//in porgress
		public void CreateJournalTable(string journalName)
		{

			string tableName = journalName.Replace(" ", "");
			string dbString = @"CREATE TABLE  " + tableName + "( ID INT IDENTITY(1, 1) NOT NULL,Date DATE NULL, Account_1  NVARCHAR(50) NULL, Account_2 NVARCHAR(50) NULL," +
			"Type_1 NVARCHAR(50) NULL, Type_2 NVARCHAR(50) NULL, " +
			"Debit MONEY NULL, Credit  MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";

		}

		//<<------ this is read data method tables------>>
		////in porgress
		public void ReadData(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Console.WriteLine(reader[0]);
					}
				}

			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}

		//<<------ this method writes data to tables------>>
		public void WriteData(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);
				command.ExecuteNonQuery();
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}
		}

		//<<------- read first entry method------->>
		////in porgress
		public void ReadFirstEntry(string databaseCommand)
		{
			try
			{
				connection.Open();
				SqlCommand command = new SqlCommand(databaseCommand, connection);
				command.ExecuteScalar();
			}
			finally
			{
				if (connection != null)
					connection.Close();
			}


		}
	}
}
