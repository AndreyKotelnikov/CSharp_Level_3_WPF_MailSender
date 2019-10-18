namespace MailSender.Lib.Data.BasedEntities
{
    /// <summary>
    /// Персона
    /// </summary>
    public abstract class Human : NamedEntity
    {
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Дополнительное описание
        /// </summary>
        public string Description { get; set; }
    }
}