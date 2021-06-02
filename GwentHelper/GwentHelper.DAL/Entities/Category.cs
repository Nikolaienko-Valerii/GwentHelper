using System.Collections.Generic;

namespace GwentHelper.DAL.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
