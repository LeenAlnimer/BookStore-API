using BookStore_API.DTOs;
using BookStore_API.Models;

namespace BookStore_API.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(int id);
        Task<Book> CreateAsync(CreateBookDto dto);
        Task<bool> UpdateAsync(int id, UpdateBookDto dto);
        Task<bool> DeleteAsync(int id);
        Task<List<Book>> SearchAsync(string title);
    }
}
