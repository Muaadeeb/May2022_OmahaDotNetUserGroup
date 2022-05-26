namespace Business.Interfaces
{
    public interface IBookManager
    {
        public Task<BookDTO> CreateBookAsync(BookDTO obj);
        public Task<BookDTO> UpdateBookAsync(BookDTO obj);
        public Task<int> DeleteBookAsync(int id);
        public Task<BookDTO> GetBookAsync(int id);
        public Task<IEnumerable<BookDTO>> GetBooksAsync();
    }
}
