namespace Business.Managers
{
    public class BookManager : IBookManager
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookManager(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookDTO> CreateBookAsync(BookDTO obj)
        {
            var book = _mapper.Map<BookDTO, Book>(obj);
            var addedBook = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return _mapper.Map<Book, BookDTO>(addedBook.Entity);
        }

        public async Task<BookDTO> UpdateBookAsync(BookDTO obj)
        {
            var bookDetails = await _context.Books.FindAsync(obj.BookId);
            var book = _mapper.Map<BookDTO, Book>(obj, bookDetails!);

            var updatedBook = _context.Books.Update(book);
            await _context.SaveChangesAsync();

            return _mapper.Map<Book, BookDTO>(updatedBook.Entity);
        }

        public async Task<int> DeleteBookAsync(int id)
        {
            var bookDetails = await _context.Books.FindAsync(id);
            if (bookDetails != null)
            {
                _context.Books.Remove(bookDetails);
                return await _context.SaveChangesAsync();
            }

            return default;
        }

        public async Task<BookDTO?> GetBookAsync(int id)
        {
            var bookData = await _context.Books.FirstOrDefaultAsync((x => x.BookId == id));

            if (bookData == null)
            {
                return default;
            }

            return _mapper.Map<Book, BookDTO>(bookData);

        }

        public async Task<IEnumerable<BookDTO>> GetBooksAsync()
        {
            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDTO>>(await _context.Books.ToListAsync());
        }
    }
}
