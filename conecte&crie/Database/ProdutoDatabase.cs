using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conecte_crie.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace conecte_crie.Database
{
    public class ProdutoDatabase
    {
        private readonly SQLiteConnection _db;

        public ProdutoDatabase(string dbPath)
        {
            _db = new SQLiteConnection(dbPath);
            _db.CreateTable<Produto>();
        }

        public int Salvar(Produto produto)
        {
            return _db.Insert(produto);
        }

        public List<Produto> Listar()
        {
            return _db.Table<Produto>().ToList();
        }

        public int Deletar(int id)
        {
            return _db.Delete<Produto>(id);
        }
    }
}

