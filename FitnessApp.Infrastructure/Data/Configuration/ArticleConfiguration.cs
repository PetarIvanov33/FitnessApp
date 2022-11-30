using FitnessApp.Infrastructure.Data.Enities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Infrastructure.Data.Configuration
{
    internal class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(CreateАrticles());
        }

        private List<Article> CreateАrticles()
        {
            List<Article> articles = new List<Article>()
            {
                new Article()
                {
                    Id = 1,
                    Title = "Поузи от МЪРТВАТА ТЯГА",
                    ImageURL = "https://trenirai.bg/wp-content/uploads/2019/02/deadhlift.jpg",
                    AuthorId = 1,
                    CategoryId = 1,
                    Content = "Мускулите, използвани от това упражнение, са главно бицепсите и трицепсите, които повдигат екипировката, четворките, глутеус максимус, мускулите на бедрата и разтегателите на долната част на гърба. Мъртвата тяга също действа на синергичните мускули, особено тези на бедрото и трицепсите на прасеца. За поддържане на баланса, използват се и други мускули, като корема, трапец, делтоиди, раменни шапки и мускули на ръцете. Когато всички тези мускули работят, сами ще се убедите, че мъртвата тяга е пълно упражнение за развитие на цялото тяло. Мъртвата тяга е много полезна за тялото. Повишава издръжливостта на тялото. Също така помага за подобряване на силата на координация и баланс на гърба. Флексии също ще бъде отлично за артикулация."
                }

             };

            return articles;
        }
    }


}
