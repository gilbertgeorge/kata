-- For this challenge you need to create a SELECT statement that will contain data about departments that had
-- a sale with a price over 98.00 dollars. This SELECT statement will have to use an EXISTS to achieve the task.
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

CREATE TABLE departments (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE sales (
    id SERIAL PRIMARY KEY,
    department_id INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    card_name VARCHAR(255) NOT NULL,
    card_number VARCHAR(255) NOT NULL,
    transaction_date DATE NOT NULL,
    FOREIGN KEY (department_id) REFERENCES departments(id)
);

INSERT INTO departments (name) VALUES ('Department 1');
INSERT INTO departments (name) VALUES ('Department 2');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (1, 'Sale 1', 100.00, 'John Doe', '1234567890', '2018-01-01');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (1, 'Sale 2', 50.00, 'John Doe', '1234567890', '2018-01-01');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (2, 'Sale 3', 75.00, 'John Doe', '1234567890', '2018-01-01');
INSERT INTO sales (department_id, name, price, card_name, card_number, transaction_date) VALUES (2, 'Sale 4', 25.00, 'John Doe', '1234567890', '2018-01-01');


SELECT departments.id, departments.name
FROM departments
WHERE EXISTS (
    SELECT *
    FROM sales
    WHERE sales.department_id = departments.id
    AND sales.price > 98.00
);