using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GwentHelper.DAL.Entities
{
    class Card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public List<Category> Categories { get; set; }
        public string Faction { get; set; }
        public string SecondaryFaction { get; set; }
        public int Power { get; set; }
        public int Armor { get; set; }
        public int Provision { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Rarity { get; set; }
        public string Availability { get; set; }
        public int ArtId { get; set; }
        public string Ability { get; set; }
        public string AbilityHtml { get; set; }
        public string FlavorText { get; set; }
        public List<Keyword> Keywords { get; set; }
    }
}
