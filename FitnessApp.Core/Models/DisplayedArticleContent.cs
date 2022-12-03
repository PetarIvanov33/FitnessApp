using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class DisplayedArticleContent
    {
        public int ArticleId { get; set; }

        public string Titel { get; set; }

        public string ImageURL { get; set; }

        public string Author { get; set; }

        public string AuthorUserId { get; set; }

        public string Category { get; set; }

        public string Content { get; set; }
    }
}
