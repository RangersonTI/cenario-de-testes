using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            new UsuarioDAL().Inserir(_usuario);
        }

        public void Alterar(Usuario _usuario)
        {
            new UsuarioDAL().Alterar(_usuario);
        }

        public void Excluir(int _id)
        {
            new UsuarioDAL().Excluir(_id);
        }

        public Usuario BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);
        }

        public void Altenticar(string _nome, string _senha)
        {
            throw new NotImplementedException();
        }
    }
}
