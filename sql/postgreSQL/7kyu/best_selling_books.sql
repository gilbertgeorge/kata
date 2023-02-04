-- You work at a book store. It's the end of the month, and you need to find out the 5 bestselling books at
-- your store. Use a select statement to list names, authors, and number of copies sold of the 5 books which
-- were sold most.
--
-- books table schema
--
-- name
-- author
-- copies_sold

CREATE TABLE books (
    name VARCHAR(255),
    author VARCHAR(255),
    copies_sold INT
);

INSERT INTO books (name, author, copies_sold) VALUES ('The Hobbit', 'J.R.R. Tolkien', 100);
INSERT INTO books (name, author, copies_sold) VALUES ('The Lord of the Rings', 'J.R.R. Tolkien', 200);
INSERT INTO books (name, author, copies_sold) VALUES ('The Silmarillion', 'J.R.R. Tolkien', 50);
INSERT INTO books (name, author, copies_sold) VALUES ('The Fellowship of the Ring', 'J.R.R. Tolkien', 125);
INSERT INTO books (name, author, copies_sold) VALUES ('The Two Towers', 'J.R.R. Tolkien', 150);
INSERT INTO books (name, author, copies_sold) VALUES ('The Return of the King', 'J.R.R. Tolkien', 175);

SELECT name, author, copies_sold
FROM books
ORDER BY copies_sold DESC
LIMIT 5;
