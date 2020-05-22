using BO;
using DAL;
using Excecoes;


namespace BLL
{
    public class BL
    {
        /// <summary>
        /// Valida e adiciona um utente na lista de utentes
        /// </summary>
        /// <param name="utente"></param>
        public static void AddUtente(Utente utente)
        {
            string msg = ValidaUtente(utente);
            if (string.IsNullOrEmpty(msg))
            {
                Dados.AddUtente(utente);
            }
            else
            {
                throw new Excecao(msg);
            }
        }

        /// <summary>
        /// Valida utente
        /// </summary>
        /// <param name="pUtente"></param>
        /// <returns></returns>
        private static string ValidaUtente(Utente pUtente)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(pUtente.CodUtente))
                result = "O código não pode ser vazio! Tem de definir um código!";
            else if (string.IsNullOrEmpty(pUtente.Nome))
                result = "O nome não pode ser vazio! Tem de definir um nome!";
            return result;
        }

        /// <summary>
        /// Remove um utente da lista de utentes
        /// </summary>
        /// <param name="utente"></param>
        /// <returns></returns>
        public static void RemoveUtente(Utente pUtente)
        {
            string msg = string.Empty;
            msg = Dados.RemoveUtente(pUtente.CodUtente);

            if (!string.IsNullOrEmpty(msg))
                throw new Excecao(msg);
        }

        /// <summary>
        /// Adiciona uma profissao na lista de profissoes
        /// </summary>
        /// <param name="profissao"></param>
        /// <returns></returns>
        public static void  AddProfissao(Profissao profissao)
        {
            string msg = ValidaProfissao(profissao);
            if (string.IsNullOrEmpty(msg))
            {
                Dados.AddProfissao(profissao);
            }
            else
            {
                throw new Excecao(msg);
            }
            
        }
        private static string ValidaProfissao(Profissao pProfissao)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(pProfissao.CodProfissao.ToString()))
                result = "";
            return result;
                    
        }
    }
}

        
