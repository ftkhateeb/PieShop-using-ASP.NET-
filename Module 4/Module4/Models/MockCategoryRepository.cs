using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4.Models
{
    //Mock data returns hard coded data
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1 , CategoryName ="Fruit Pies" , Description ="all-Fruit" },
            new Category{CategoryId=2 , CategoryName="Cheese Cakes", Description= " cheesy"},
            new Category{CategoryId=3 , CategoryName="Seasonal pies", Description= " get in the mood of seasonal pies" }


        };



    }
}
