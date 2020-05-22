using System;
using System.Runtime.Serialization;

namespace Excecoes
{
    public class Excecao : Exception
    {
        public Excecao()
        {
        }

        public Excecao(string message) : base(message)
        {
        }

        public Excecao(string message, Exception innerexception) : base(message, innerexception)
        {
        }

        protected Excecao(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }


}
