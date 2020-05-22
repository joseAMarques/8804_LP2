using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;

namespace DAL
{
    public class Dados
    {
        static List<Utente> utentes = new List<Utente>();
        static List<Profissao> profissoes = new List<Profissao>();
        static List<Regiao> regioes = new List<Regiao>();
        #region UTENTE
        /// <summary>
        /// Adiciona um utente na lista caso este não exista
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        public static string AddUtente(Utente utente)
        {
            string result = string.Empty;
            if (!Dados.ExisteUtente(utente.CodUtente))
                utentes.Add(utente);
            else
                result = "Já existe utente com este código";
            return result;
        }

        /// <summary>
        /// Remove utente da lista de utentes ( falta criar metodo na BLL)
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        public static string RemoveUtente(string pCodUtente)
        {
            string result = string.Empty;
            if (!Dados.ExisteUtente(pCodUtente))
                result = "Não existe utente com este código";
            else
                utentes.Remove(utentes.First(utente => utente.CodUtente == pCodUtente));
            return result;
        }
        /// <summary>
        /// Verifica o codigo de utente
        /// </summary>
        /// <param name="pCodUtente"></param>
        /// <returns></returns>
        public static bool ExisteUtente(string pCodUtente)
        {
            return utentes.Any(utente => utente.CodUtente == pCodUtente);
        }

        /// <summary>
        /// Conta Utentes
        /// </summary>
        /// <returns></returns>
        public static int ContaUtentes()
        {
            return utentes.Count;
        }

        /// <summary>
        /// conta idades num intervalo de idades
        /// </summary>
        /// <param name="pIdade"></param>
        /// <param name="pMaior"></param>
        /// <returns></returns>
        public static int ContaUtentesIdade(int pIdade, bool pMaior)
        {
            if (pMaior)
                return utentes.Where(utente => utente.Idade >= pIdade).Count();
            else
                return utentes.Where(utente => utente.Idade < pIdade).Count();
        }

        #endregion
        #region REGIAO
        /// <summary>
        /// Verifica se existe regiao na lista de regioes
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string RemoveRegiao(int pCodRegiao)
        {
            string result = string.Empty;
            if (!Dados.ExisteRegiao(pCodRegiao))
                result = "Não existe região com este código";
            else
                regioes.Remove(regioes.First(regiao => regiao.CodRegiao == pCodRegiao));
            return result;
        }
        /// <summary>
        /// Adiciona uma regiao na lista de regioes
        /// </summary>
        /// <param name="regiao"></param>
        /// <returns></returns>
        public static string AddRegiao(Regiao regiao)
        {
            string result = string.Empty;
            if (!Dados.ExisteRegiao(regiao.CodRegiao))
                regioes.Add(regiao);
            else
                result = "Já existe essa regiao";
            return result;
        }

        /// <summary>
        /// Verifica o codigo da regiao
        /// </summary>
        /// <param name="pCodRegiao"></param>
        /// <returns></returns>
        public static bool ExisteRegiao(int pCodRegiao)
        {
            return regioes.Any(regiao => regiao.CodRegiao == pCodRegiao);
        }

        /// <summary>
        /// Devolve o Tipo de regiao solicitado por parâmetro
        /// </summary>
        /// <param name="pRegiao"></param>
        /// <returns></returns>
        public static List<Utente> DevolveUtentesPorRegiao(string pRegiao)
        {
            return utentes.Where(utente => utente.Regiao == pRegiao).ToList();
        }

        #endregion

        #region PROFISSAO
        /// <summary>
        /// Conta profissoes
        /// </summary>
        /// <param name="pProfissao"></param>
        /// <returns></returns>
        public static int ContaUtentesProfissoes(string pProfissao)
        {
            return utentes.Where(utente => utente.Profissao == pProfissao).Count();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="profissao"></param>
        /// <returns></returns>
        public static string AddProfissao(Profissao profissao)
        {
            string result = string.Empty;
            if (!Dados.ExisteProfissao(profissao.CodProfissao))
                profissoes.Add(profissao);
            else
                result = "Já existe essa Profissão";
            return result;
        }
        /// <summary>
        /// Verifica se exite profissão
        /// </summary>
        /// <param name="pCodProfissao"></param>
        /// <returns></returns>
        public static bool ExisteProfissao(int pCodProfissao)
        {
            return profissoes.Any(profissao => profissao.CodProfissao == pCodProfissao);
        }

        /// <summary>
        /// Devolve o tipo de profissão solicitado por parâmentro
        /// </summary>
        /// <param name="pProfissao"></param>
        /// <returns></returns>
        public static List<Utente> DevolveUtentesPorProfissao(string pProfissao)
        {
            return utentes.Where(utente => utente.Profissao == pProfissao).ToList();
        }

        #endregion
        #region GENERO
        /// <summary>
        /// Conta utentes por genero
        /// </summary>
        /// <param name="pGenero"></param>
        /// <returns></returns>
        public static int ContaUtentesGenero(Genero pGenero)
        {
            return utentes.Where(utente => utente.Genero == pGenero).Count();
        }

        /// <summary>
        /// Devolve utentes pelo tipo de genero solicitado por parâmetro
        /// </summary>
        /// <param name="pGenero"></param>
        /// <returns></returns>
        public static List<Utente> DevolveUtentesPorGenero(Genero pGenero)
        {
            return utentes.Where(utente => utente.Genero == pGenero).ToList();
        }
        #endregion



















    }
}




