using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPI.Models;

namespace BookStoreAPI.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private BookDbContext _categoryContext;

        public CategoryRepository(BookDbContext categoryContext)
        {
            _categoryContext = categoryContext;
        }

        public ICollection<Category> GetCategories()
        {
            return _categoryContext.Categories.OrderBy(c => c.Name).ToList();
        }

        public ICollection<BookCategory> GetCategoriesOfABook(int bookId)
        {
            return _categoryContext.BookCategories.Where(b => b.BookId == bookId).ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _categoryContext.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
        }
    }
}
