using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TTA.WebApp.MVC.Models;

namespace TTA.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);

        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
    }

}
