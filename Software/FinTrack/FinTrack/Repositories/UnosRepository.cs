using DBLayer;  
using FinTrack.Models;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrack.Repositories
{
    public class UnosRepository
    {
        public static List<Unos> GetUnosi()
        {
            var lista = new List<Unos>();
            string sql = "SELECT u.*, k.Naziv FROM Unosi u INNER JOIN Kategorija k ON u.KategorijaId = k.Id";


            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                var unos = new Unos
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Vrsta = reader["Vrsta"].ToString(),
                    Datum = DateTime.Parse(reader["Datum"].ToString()),
                    Opis = reader["Opis"].ToString(),
                    Iznos = decimal.Parse(reader["Iznos"].ToString()),
                    KategorijaId = int.Parse(reader["KategorijaId"].ToString()),
                    Kategorija = new Kategorija
                    {
                        Id = int.Parse(reader["KategorijaId"].ToString()),
                        Naziv = reader["Naziv"].ToString()
                    }
                };
                lista.Add(unos);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        public static void InsertUnos(Unos u)   
        {
            string sql = $@"
                    INSERT INTO Unosi (Vrsta, Datum, Opis, Iznos, KategorijaId)
                    VALUES ('{u.Vrsta}', '{u.Datum:yyyy-MM-dd}', '{u.Opis}', {u.Iznos}, {u.KategorijaId})";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteUnos(int id)
        {
            string sql = $"DELETE FROM Unosi WHERE Id = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Unos> SearchUnosi(string pojam)
        {
            var lista = new List<Unos>();

            string sql = $"SELECT u.*, k.Naziv FROM Unosi u INNER JOIN Kategorija k ON u.KategorijaId = k.Id WHERE u.Opis LIKE '%{pojam}%'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                var unos = new Unos
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Vrsta = reader["Vrsta"].ToString(),
                    Datum = DateTime.Parse(reader["Datum"].ToString()),
                    Opis = reader["Opis"].ToString(),
                    Iznos = decimal.Parse(reader["Iznos"].ToString()),
                    KategorijaId = int.Parse(reader["KategorijaId"].ToString()),
                    Kategorija = new Kategorija
                    {
                        Id = int.Parse(reader["KategorijaId"].ToString()),
                        Naziv = reader["Naziv"].ToString()
                    }
                };
                lista.Add(unos);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        public static void UpdateUnos(Unos u)
        {
            string sql = $@"
                UPDATE Unosi
                SET Vrsta = '{u.Vrsta}', 
                    Datum = '{u.Datum:yyyy-MM-dd}', 
                    Opis = '{u.Opis.Replace("'", "''")}', //bez obzira na apostrofe u opisu
                    Iznos = {u.Iznos.ToString(System.Globalization.CultureInfo.InvariantCulture)}, // da se decimal ispravno formatira
                    KategorijaId = {u.KategorijaId}
                WHERE Id = {u.Id}"; 
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Unos> GetUnosiByMonthByYear(int month, int year)
        {
            var lista = new List<Unos>();
            string sql = $@"
                SELECT u.*, k.Naziv 
                FROM Unosi u 
                INNER JOIN Kategorija k ON u.KategorijaId = k.Id 
                WHERE MONTH(u.Datum) = {month} AND YEAR(u.Datum) = {year}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                var unos = new Unos
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Vrsta = reader["Vrsta"].ToString(),
                    Datum = DateTime.Parse(reader["Datum"].ToString()),
                    Opis = reader["Opis"].ToString(),
                    Iznos = decimal.Parse(reader["Iznos"].ToString()),
                    KategorijaId = int.Parse(reader["KategorijaId"].ToString()),
                    Kategorija = new Kategorija
                    {
                        Id = int.Parse(reader["KategorijaId"].ToString()),
                        Naziv = reader["Naziv"].ToString()
                    }
                };
                lista.Add(unos);
            }
            reader.Close();
            DB.CloseConnection();
            return lista;
        }
    }
}
