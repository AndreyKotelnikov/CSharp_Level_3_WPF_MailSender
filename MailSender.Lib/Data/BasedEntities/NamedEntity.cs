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
        public string Name { get; set; }
    }
}