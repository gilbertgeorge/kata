-- For this challenge you need to create a SELECT statement, this SELECT statement will use an IN to check whether
-- a department has had a sale with a price over 98.00 dollars.
--
-- departments table schema
-- id
-- name
--
-- sales table schema
-- id
-- department_id (department foreign key)
-- name
-- price
-- card_name
-- card_number
-- transaction_date
--
-- resultant table schema
-- id
-- name
DROP TABLE IF EXISTS sales;
CREATE TABLE sales (
  id SERIAL PRIMARY KEY,
  department_id INT NOT NULL,
  name VARCHAR(255) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  card_name VARCHAR(255) NOT NULL,
  card_number VARCHAR(255) NOT NULL,
  transaction_date TIMESTAMP NOT NULL,
  FOREIGN KEY (department_id) REFERENCES departments(id)
);

SELECT * FROM departments;
SELECT * FROM sales;

INSERT INTO departments (name) VALUES ('Department 3');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (1, 'sale 1', 100.00, 'card name 1', 'card number 1', '2017-01-01 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (1, 'sale 2', 99.00, 'card name 2', 'card number 2', '2017-01-02 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (1, 'sale 3', 98.00, 'card name 3', 'card number 3', '2017-01-03 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (2, 'sale 4', 97.00, 'card name 4', 'card number 4', '2017-01-04 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (2, 'sale 5', 96.00, 'card name 4', 'card number 5', '2017-01-04 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (2, 'sale 6', 97.00, 'card name 5', 'card number 6', '2017-01-05 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (3, 'sale 7', 98.00, 'card name 6', 'card number 7', '2017-01-06 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (3, 'sale 8', 99.00, 'card name 7', 'card number 8', '2017-01-07 00:00:00');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (3, 'sale 9', 100.00, 'card name 8', 'card number 9', '2017-01-08 00:00:00');

SELECT id, name
FROM departments
WHERE id IN (
  SELECT department_id
  FROM sales
  WHERE price > 98.00
);