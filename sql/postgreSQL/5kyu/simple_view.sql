-- You need to CREATE a View, then SELECT it to show data for the unit tests.
-- You need to find members who have spent more than $1000 across ALL departments (or at least one)
-- which have total sales of more than $10000.
-- Your solution needs to have these required fields (in this order): ID, Name, Email, Total_spending

DROP TABLE IF EXISTS products;
DROP TABLE IF EXISTS sales;
CREATE TABLE members (
    id SERIAL PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    number VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    city VARCHAR(255) NOT NULL,
    street_name VARCHAR(255) NOT NULL,
    street_address VARCHAR(255) NOT NULL
);

CREATE TABLE sales (
    id SERIAL PRIMARY KEY NOT NULL,
    department_id INTEGER NOT NULL,
    product_id INTEGER NOT NULL,
    member_id INTEGER NOT NULL,
    transaction_date timestamp NOT NULL,
    FOREIGN KEY (member_id) REFERENCES members(id),
    FOREIGN KEY (product_id) REFERENCES products(id),
    FOREIGN KEY (department_id) REFERENCES departments(id)
);

-- CREATE TABLE departments (
--     id SERIAL PRIMARY KEY NOT NULL,
--     name VARCHAR(255) NOT NULL
-- );

CREATE TABLE products (
    id SERIAL PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    price INTEGER NOT NULL
);

SELECT * FROM departments;
SELECT * FROM products;
SELECT * FROM members;
SELECT * FROM sales;

INSERT INTO products (name, price) VALUES ('Shoes', 100), ('T-shirt', 150), ('Pants', 180), ('Socks', 20), ('Hat', 130), ('Sweater', 160), ('Jacket', 220), ('Gloves', 90), ('Scarf', 85), ('Umbrella', 55);
INSERT INTO members (name, number, email, city, street_name, street_address) VALUES ('Steve', 3, 'steve@gmail.com', 'Warren', 'Main', 123), ('John', 4, 'john@gmail.com', 'Detroit', 'Side', 1234), ('Mary', 5, 'mary@gmail.com', 'Detroit', 'Front', 12345), ('Sue', 6, 'sue@gmail.com', 'Detroit', 'Back', 123456), ('Bob', 7, 'bob@gmail.com', 'Detroit', 'Front', 1234567);
INSERT INTO sales (department_id, product_id, member_id, transaction_date) VALUES (1, 1, 1, '2018-01-01'), (1, 2, 1, '2018-01-01'), (1, 3, 1, '2018-01-01'), (1, 4, 1, '2018-01-01'), (1, 5, 1, '2018-01-01'), (1, 6, 1, '2018-01-01'), (1, 7, 1, '2018-01-01'), (1, 8, 1, '2018-01-01'), (1, 9, 1, '2018-01-01'), (1, 10, 1, '2018-01-01'), (1, 1, 2, '2018-01-01'), (1, 2, 2, '2018-01-01'), (1, 3, 2, '2018-01-01'), (1, 4, 2, '2018-01-01'), (1, 5, 2, '2018-01-01'), (1, 6, 2, '2018-01-01'), (1, 7, 2, '2018-01-01'), (1, 8, 2, '2018-01-01'), (1, 9, 2, '2018-01-01'), (1, 10, 2, '2018-01-01'), (1, 1, 3, '2018-01-01'), (1, 2, 3, '2018-01-01'), (1, 3, 3, '2018-01-01'), (1, 4, 3, '2018-01-01'), (1, 5, 3, '2018-01-01'), (1, 6, 3, '2018-01-01'), (1, 7, 3, '2018-01-01'), (1, 8, 3, '2018-01-01'), (1, 9, 3, '2018-01-01'), (1, 10, 3, '2018-01-01');
INSERT INTO sales (department_id, product_id, member_id, transaction_date) VALUES (2, 1, 1, '2018-01-01'), (2, 2, 1, '2018-01-01'), (2, 3, 1, '2018-01-01'), (2, 4, 1, '2018-01-01'), (2, 5, 1, '2018-01-01'), (2, 6, 1, '2018-01-01'), (2, 7, 1, '2018-01-01'), (2, 8, 1, '2018-01-01'), (2, 9, 1, '2018-01-01'), (2, 10, 1, '2018-01-01'), (2, 1, 2, '2018-01-01'), (2, 2, 2, '2018-01-01'), (2, 3, 2, '2018-01-01'), (2, 4, 2, '2018-01-01'), (2, 5, 2, '2018-01-01'), (2, 6, 2, '2018-01-01'), (2, 7, 2, '2018-01-01'), (2, 8, 2, '2018-01-01'), (2, 9, 2, '2018-01-01'), (2, 10, 2, '2018-01-01'), (2, 1, 3, '2018-01-01'), (2, 2, 3, '2018-01-01'), (2, 3, 3, '2018-01-01'), (2, 4, 3, '2018-01-01'), (2, 5, 3, '2018-01-01'), (2, 6, 3, '2018-01-01'), (2, 7, 3, '2018-01-01'), (2, 8, 3, '2018-01-01'), (2, 9, 3, '2018-01-01'), (2, 10, 3, '2018-01-01');
INSERT INTO sales (department_id, product_id, member_id, transaction_date) VALUES (3, 1, 1, '2018-01-01'), (3, 2, 4, '2018-01-01'), (3, 3, 4, '2018-01-01'), (3, 4, 4, '2018-01-01'), (3, 5, 4, '2018-01-01'), (3, 6, 4, '2018-01-01'), (3, 7, 4, '2018-01-01'), (3, 8, 4, '2018-01-01'), (3, 9, 4, '2018-01-01'), (3, 10, 4, '2018-01-01'), (3, 1, 5, '2018-01-01'), (3, 2, 5, '2018-01-01'), (3, 3, 5, '2018-01-01'), (3, 4, 5, '2018-01-01'), (3, 5, 5, '2018-01-01'), (3, 6, 5, '2018-01-01'), (3, 7, 5, '2018-01-01'), (3, 8, 5, '2018-01-01'), (3, 9, 5, '2018-01-01'), (3, 10, 5, '2018-01-01'), (3, 1, 5, '2018-01-01'), (3, 2, 5, '2018-01-01'), (3, 3, 5, '2018-01-01'), (3, 4, 5, '2018-01-01'), (3, 5, 5, '2018-01-01'), (3, 6, 5, '2018-01-01'), (3, 7, 5, '2018-01-01'), (3, 8, 5, '2018-01-01'), (3, 9, 5, '2018-01-01'), (3, 10, 5, '2018-01-01');


-- For this challenge you need to create a VIEW. This VIEW is used by a sales store to give out vouches to members
-- who have spent over $1000 in departments that have brought in more than $10000 total ordered by the members id.
-- The VIEW must be called members_approved_for_voucher then you must create a SELECT query using the view.
-- resultant table schema
-- id
-- name
-- email
-- total_spending

CREATE VIEW members_approved_for_voucher AS
    SELECT mem.id, mem.name, mem.email, mem.total_spending
    FROM
    (
        SELECT s.member_id as id, m.name, m.email, SUM(p.price) AS total_spending
        FROM sales s
        INNER JOIN members m ON m.id = s.member_id
        INNER JOIN products p ON s.product_id = p.id
        JOIN
        (
            SELECT department_id AS "id", SUM(price)
            FROM sales s
            INNER JOIN products p ON (s.product_id = p.id)
            INNER JOIN departments d ON (s.department_id = d.id)
            GROUP BY s.department_id
            HAVING SUM(price) > 10000
        ) d ON (s.department_id = d.id)
        GROUP BY s.member_id, m.name, email
        HAVING SUM(p.price) > 1000
    ) mem;

select id, name, email, total_spending
from members_approved_for_voucher
order by id;
