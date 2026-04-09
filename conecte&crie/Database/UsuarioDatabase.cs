using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conecte_crie.Models;
using SQLite;

namespace conecte_crie.Database
{
    public class UsuarioDatabase
    {
        private readonly SQLiteConnection _db;

        public UsuarioDatabase(string dbPath)
        {
            _db = new SQLiteConnection(dbPath);
            _db.CreateTable<Usuario>();
        }

        public int Salvar(Usuario usuario)
        {
            return _db.Insert(usuario);
        }

        public List<Usuario> Listar()
        {
            return _db.Table<Usuario>().ToList();
        }

        public int Atualizar(Usuario usuario)
        {
            return _db.Update(usuario);
        }

        public int Deletar(int id)
        {
            return _db.Delete<Usuario>(id);
        }
    }
}
