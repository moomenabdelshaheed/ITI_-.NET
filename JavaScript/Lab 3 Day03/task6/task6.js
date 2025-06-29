var library = {
    books: [
        {
            id: 1,
            title: '1984',
            author: 'George Orwell',
            year: '1949'
        },
        {
            id: 2,
            title: 'To Kill a Mockingbird',
            author: 'Harper Lee',
            year: '1960'
        },
        {
            id: 3,
            title: 'Brave New World',
            author: 'Aldous Huxley',
            year: '1932'
        },
        {
            id: 4,
            title: 'The Great Gatsby',
            author: 'F. Scott Fitzgerald',
            year: '1925'
        },
        {
            id: 5,
            title: 'Moby-Dick',
            author: 'Herman Melville',
            year: '1851'
        }
       
    ]
};

function LibraryBooks(library) {
    var booksList = library.books;
    var booksTitles=[];

    for (var i = 0; i < booksList.length; i++) {
        booksTitles.push(booksList[i].title);  
    }

    document.writeln(`you have this collection of books : ${booksTitles} `,);

}

LibraryBooks(library);




   
