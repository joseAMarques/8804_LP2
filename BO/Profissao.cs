using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Profissao
    {
        #region ATRIBUTOS
        int codProfissao;
        string nomeProfissao;

        #endregion

        #region CONSTRUTOR
        public Profissao()
        {
        }
        #endregion

        #region PROPRIEDADES
        public Profissao(int codProfissao, string nomeProfissao)
        {
            this.codProfissao = codProfissao;
            this.nomeProfissao = nomeProfissao;
        }

        public int CodProfissao
        {
            get { return codProfissao; }
            set { codProfissao = value; }
        }
        public string NomeProfissao
        {
            get { return nomeProfissao; }
            set { nomeProfissao = value; }
        }

        #endregion

    }
}
