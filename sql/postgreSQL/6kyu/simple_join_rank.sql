-- For this challenge you need to create a simple SELECT statement that will return all columns from the people table,
-- and join to the sales table so that you can return the COUNT of all sales and RANK each person by their sale_count.
--
-- people table schema
-- id
-- name
--
-- sales table schema
-- id
-- people_id
-- sale
-- price
-- You should return all people fields as well as the sale count as "sale_count" and the rank as "sale_rank".

DROP TABLE IF EXISTS people;
DROP TABLE IF EXISTS sales;

CREATE TABLE people (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255)
);
CREATE TABLE sales (
    id SERIAL PRIMARY KEY,
    people_id INT,
    sale VARCHAR(255),
    price INT
);

INSERT INTO people (name) VALUES ('John');
INSERT INTO people (name) VALUES ('Mary');
INSERT INTO people (name) VALUES ('Peter');
INSERT INTO people (name) VALUES ('Susan');
INSERT INTO people (name) VALUES ('George');

INSERT INTO sales (people_id, sale, price) VALUES (1, 'car', 10000);
INSERT INTO sales (people_id, sale, price) VALUES (1, 'house', 20000);
INSERT INTO sales (people_id, sale, price) VALUES (1, 'boat', 30000);
INSERT INTO sales (people_id, sale, price) VALUES (2, 'car', 10000);
INSERT INTO sales (people_id, sale, price) VALUES (2, 'house', 20000);
INSERT INTO sales (people_id, sale, price) VALUES (3, 'car', 10000);
INSERT INTO sales (people_id, sale, price) VALUES (3, 'house', 20000);
INSERT INTO sales (people_id, sale, price) VALUES (3, 'boat', 30000);
INSERT INTO sales (people_id, sale, price) VALUES (3, 'plane', 40000);
INSERT INTO sales (people_id, sale, price) VALUES (4, 'car', 10000);
INSERT INTO sales (people_id, sale, price) VALUES (4, 'house', 20000);
INSERT INTO sales (people_id, sale, price) VALUES (5, 'car', 10000);

SELECT * FROM people;
SELECT * FROM sales;

SELECT
    p.id,
    p.name,
    COUNT(s.id) AS sale_count,
    RANK() OVER (ORDER BY COUNT(s.id) DESC) AS sale_rank
FROM
    people p
    LEFT JOIN sales s ON p.id = s.people_id
GROUP BY
    p.id,
    p.name