using System.Data.SQLite;
using System.Data;

namespace Winforms_with_Sqlite
{
	internal class DataHelper
	{
		private static SQLiteConnection? sqliteConnection;
		public DataHelper()
		{

		}

	

		private static SQLiteConnection DbConnection()
		{
			sqliteConnection = new SQLiteConnection("Data Source=Db.sqlite; Version=3;");
			sqliteConnection.Open();
			return sqliteConnection;
		}

		public static void CriarBancoSQLite()
		{
			try
			{
				if (!File.Exists("Db.sqlite"))
				{
				SQLiteConnection.CreateFile(@"Db.sqlite");

				}
			}
			catch
			{
				throw;
			}
		}

		public static void CriarTabelaSQlite()
		{
			try
			{
				using (var cmd = DbConnection().CreateCommand())
				{
					cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clientes(id int, Nome Varchar(50), email VarChar(80))";
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public static DataTable GetClientes()
		{
			SQLiteDataAdapter? da = null;
			DataTable dt = new DataTable();
			try
			{
				using (var cmd = DbConnection().CreateCommand())
				{
					cmd.CommandText = "SELECT * FROM Clientes";
					da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
					da.Fill(dt);
					return dt;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public static DataTable GetCliente(int id)
		{
			SQLiteDataAdapter? da = null;
			DataTable dt = new DataTable();
			try
			{
				using (var cmd = DbConnection().CreateCommand())
				{
					cmd.CommandText = "SELECT * FROM Clientes Where Id=" + id;
					da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
					da.Fill(dt);
					return dt;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public static void Add(Cliente cliente)
		{
			try
			{
				using (var cmd = DbConnection().CreateCommand())
				{
					cmd.CommandText = "INSERT INTO Clientes(id, Nome, email ) values (@id, @nome, @email)";
					cmd.Parameters.AddWithValue("@id", cliente.Id);
					cmd.Parameters.AddWithValue("@nome", cliente.Nome);
					cmd.Parameters.AddWithValue("@email", cliente.Email);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public static void Update(Cliente cliente)
		{
			try
			{
				using (var cmd = new SQLiteCommand(DbConnection()))
				{
					if (cliente.Id != null)
					{
						cmd.CommandText = "UPDATE Clientes SET Nome=@Nome, Email=@Email WHERE Id=@Id";
						cmd.Parameters.AddWithValue("@Id", cliente.Id);
						cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
						cmd.Parameters.AddWithValue("@Email", cliente.Email);
						cmd.ExecuteNonQuery();
					}
				};
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		public static void Delete(int Id)
		{
			try
			{
				using (var cmd = new SQLiteCommand(DbConnection()))
				{
					cmd.CommandText = "DELETE FROM Clientes Where Id=@Id";
					cmd.Parameters.AddWithValue("@Id", Id);
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}
