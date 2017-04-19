function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(args) {
            let output = [];

            if (args && args.author) {
                output = books.filter(function (book) {
                    return book.author === args.author;
                });
            }
            else if (args && args.category) {
                output = books.filter(function (book) {
                    return book.category === args.category;
                });
            }
            else {
                output = books;
            }

            // Sort before returning
            books = output.sort(function (first, second) {
                return first.ID - second.ID;
            });

            return books;
        }
        function isBookExisting(newBook) {
            return books.some(function (book) {
                return book.title === newBook.title || book.isbn === newBook.isbn;
            });
        }

        function addBook(book) {
            // Validate all properties exist
            if (!book.hasOwnProperty('title') || !book.hasOwnProperty('category') || !book.hasOwnProperty('author') || !book.hasOwnProperty('isbn')) {
                throw "Book object paramethers incomplete.";
            }

            // Validate book title
            if (book.title.length < 2 || book.title.length > 100) {
                throw "Invalid book title name.";
            }

            // Validate book author
            if (book.author.length === 0) {
                throw "Book object missing author name.";
            }

            // Validate ISBN
            if (!/(^\d{10}$)|(^\d{13}$)/.test(book.isbn)) {
                throw "Book object has an invalid ISBN";
            }

            // Validate unique book name and isbn
            if (isBookExisting (book)) {
                throw "Book with identical ISBN or Name already exists.";
            }

            // Create category if it does not exist
            if (categories.indexOf(book.category) === -1) {
                categories.push(book.category);
            }

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            categories = categories.sort(function (first, second) {
                return first - second; 
            });
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}

module.exports = solve;
