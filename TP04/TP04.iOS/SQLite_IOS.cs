using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TP04.Data;
using TP04.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]

namespace TP04.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }
        public SQLite.SQLiteConnection GetConexao()
        {
            var arquivodb = "ifspdb.db3";
            string caminho = Environment.GetFolderPath(
            Environment.SpecialFolder.Personal);
            string bibliotecaPessoal = Path.Combine(caminho, "..", "Library");
            var local = Path.Combine(bibliotecaPessoal, arquivodb);
            var conexao = new SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}