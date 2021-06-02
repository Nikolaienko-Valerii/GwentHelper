using System.Collections.Generic;

namespace GwentHelper.DAL.Entities
{
    class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string TextHtml { get; set; }
        public List<Card> Cards { get; set; }
    }
}
