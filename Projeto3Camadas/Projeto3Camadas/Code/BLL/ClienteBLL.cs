using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using DAL;



namespace Projeto3Camadas.Code.BLL
{
    class ClienteBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();

        public void Inserir(ClienteDTO dto)
        {
            bd.Conectar();
            string comando = "INSERT INTO cliente(nome, email) VALUES('" + dto.Nome + "','" + dto.Email + "') ";
            bd.ExecutarComandoSQL(comando);



        }



    }
}
