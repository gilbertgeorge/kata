-- For this challenge you need to create a simple SELECT statement that will return all columns from the
-- products table, and join to the companies table so that you can return the company name.
--
-- products table schema
-- id
-- name
-- isbn
-- company_id
-- price
-- companies table schema
-- id
-- name
-- You should return all product fields as well as the company name as "company_name".

CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    isbn VARCHAR(255) NOT NULL,
    company_id INT NOT NULL,
    price DECIMAL(10,2) NOT NULL
);

CREATE TABLE companies (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

INSERT INTO products (name, isbn, company_id, price) VALUES ('The Hobbit', '9780547928227', 1, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('The Fellowship of the Ring', '9780547928227', 1, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('The Two Towers', '9780547928227', 1, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('The Return of the King', '9780547928227', 1, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('The Silmarillion', '9780547928227', 1, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('A Game of Thrones', '9780547928227', 2, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('A Clash of Kings', '9780547928227', 2, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('A Storm of Swords', '9780547928227', 2, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('A Feast for Crows', '9780547928227', 2, 9.99);
INSERT INTO products (name, isbn, company_id, price) VALUES ('A Dance with Dragons', '9780547928227', 2, 9.99);

INSERT INTO companies (name) VALUES ('Tolkien Enterprises');
INSERT INTO companies (name) VALUES ('Bantam Spectra');

SELECT p.*, c.name AS company_name
FROM products p
JOIN companies c ON p.company_id = c.id;