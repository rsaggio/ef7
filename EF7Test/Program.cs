using EF7Test.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();
            contexto.Database.EnsureCreated();
            Usuario usuario = new Usuario() { Nome = "Renan", Senha = "123" };
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
