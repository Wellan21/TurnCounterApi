namespace Turncounter.Entities
{
    /// <summary>
    /// Classe représentant un sort.
    /// </summary>
    class Spell
    {
        /// <summary>
        /// Identifiant unique du sort.
        /// </summary>
        public int SpellId { get; set; }

        /// <summary>
        /// Nom du sort.
        /// </summary>
        public string SpellName { get; set; }

        /// <summary>
        /// Coût en mana du sort.
        /// </summary>
        public int Mana { get; set; }

        /// <summary>
        /// Temps de recharge du sort.
        /// </summary>
        public int SpellCuntdown { get; set; }

        /// <summary>
        /// Tours restants avant que le sort puisse être réutilisé.
        /// </summary>
        public int RemainingTurn { get; set; }
    }
}
