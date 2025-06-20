using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;  
using FinTrack.Models;

namespace FinTrack.Repositories
{
    public class KategorijaRepository
    {
        public static List<Kategorija> GetKategorije()
        {
            var lista = new List<Kategorija>();
            string sql = "SELECT * FROM Kategorija";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                var kategorija = new Kategorija
                {
                    Id = int.Parse(reader["Id"].ToString()),
                    Naziv = reader["Naziv"].ToString()
                };
                lista.Add(kategorija);
            }
            reader.Close();
            DB.CloseConnection();
            return lista;
        }
    }
}