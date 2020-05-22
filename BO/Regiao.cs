using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Regiao
    {
        #region ATRIBUTOS
        int codRegiao;
        string nomeRegiao;
        #endregion

        #region CONSTRUTOR
        public Regiao()
        {
        }
        #endregion

        #region PROPRIEDADES
        public Regiao(int codRegiao, string nomeRegiao)
        {
            this.codRegiao = codRegiao;
            this.nomeRegiao = nomeRegiao;
        }

        public int CodRegiao
        {
            get { return codRegiao; }
            set { codRegiao = value; }
        }

        public string NomeRegiao
        {
            get { return nomeRegiao; }
            set { nomeRegiao = value; }
        }
        #endregion

    }
}
