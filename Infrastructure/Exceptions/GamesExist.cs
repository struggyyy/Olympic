using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Exceptions
{
    [Serializable]
    internal class GamesExist : Exception
    {
        private int id;

        public GamesExist()
        {
        }

        public GamesExist(int id)
        {
            this.id = id;
        }

        public GamesExist(string? message) : base(message)
        {
        }

        public GamesExist(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GamesExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
