namespace Web.Entities
{
    /// <summary>
    /// Сущность товар
    /// </summary>
    public class Product
    {
        /// <summary>
        /// уникальный идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// название
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// описание
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// стоимость в рублях
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// вес
        /// </summary>
        public decimal Weight { get; set; }
    }
}
