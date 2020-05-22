using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Utente
    {
        #region ATRIBUTOS
        string codUtente;
        string nome;
        int idade;
        Genero genero;
        string profissao;
        string regiao;
        #endregion

        #region CONSTRUTOR
        public Utente()
        {
        }
        #endregion

        #region PROPRIEDADES
        public Utente(string codUtente, string nome, int idade, Genero genero, string profissao, string regiao)
        {
            this.codUtente = codUtente;
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
            this.profissao = profissao;
            this.regiao = regiao;
        }

        public string CodUtente
        {
            get { return codUtente; }
            set { codUtente = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }
        #endregion

    }
}