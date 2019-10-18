using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Services.Interfaces;

namespace MailSender.Lib.Data.BasedEntities
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class Entity : IEntity
    {
        /// <summary>
        /// Индетификатор
        /// </summary>
        public int Id { get; set; }
        
    }
}
