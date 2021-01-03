using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module4.Models
{
    public class CategoryRepository : ICategoryRepository
    {

    
    private readonly AppDbContext _appDbContext;


    public CategoryRepository (AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
