using System.ComponentModel.DataAnnotations;

namespace MailSender.Lib.Data.BasedEntities
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public abstract class NamedEntity : Entity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [Required, MaxLength(120)]
        public string Name { get; set; }
    }
}