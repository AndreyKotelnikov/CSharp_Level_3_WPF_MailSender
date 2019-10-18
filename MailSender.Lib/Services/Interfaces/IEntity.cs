using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Services.Interfaces
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Индетификатор
        /// </summary>
        int Id { get; set; }
    }
}
