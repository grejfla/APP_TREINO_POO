using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_TREINO_P00
{
    public class DadosdoUsuario
    {

        public string nomeUsuario { get; set; }

        public string matriculaUsuario { set; get; }

        public string senhaUsuario { set; get; }


        public DadosdoUsuario(string NomeUsuario, string MatriculaUsuario, string SenhaUsuario)
        {


            nomeUsuario = NomeUsuario;
            matriculaUsuario = MatriculaUsuario;
            senhaUsuario = SenhaUsuario;
        }

        public bool VerificarDados()
        {
            return nomeUsuario == "Jack" && matriculaUsuario == "123" &&  senhaUsuario  == "456";

        }
    }
    
}
