using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRespositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            
            usuarioRespositorio.Adicionar(usuario);
            

        }
    }
}
