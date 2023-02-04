-- For this challenge you need to create a UNION statement, there are two tables ussales and eusales the parent
-- company tracks each sale at its respective location in each table, you must all filter the sale price so it
-- only returns rows with a sale greater than 50.00. You have been tasked with combining that data for future
-- analysis. Order by location (US before EU), then by id.
--
-- (us/eu)sales table schema
-- id
-- name
-- price
-- card_name
-- card_number
-- transaction_date
--
-- resultant table schema
-- location (EU for eusales and US for ussales)
-- id
-- name
-- price (greater than 50.00)
-- card_name
-- card_number
-- transaction_date

CREATE TABLE ussales (
  id INT,
  name VARCHAR(255),
  price DECIMAL(10,2),
  card_name VARCHAR(255),
  card_number VARCHAR(255),
  transaction_date DATE
);
CREATE TABLE eusales (
  id INT,
  name VARCHAR(255),
  price DECIMAL(10,2),
  card_name VARCHAR(255),
  card_number VARCHAR(255),
  transaction_date DATE
);

INSERT INTO ussales (id, name, price, card_name, card_number, transaction_date) VALUES (1, 'us 1', 40.00, 'name 1', 'number 1', '2018-01-01');
INSERT INTO ussales (id, name, price, card_name, card_number, transaction_date) VALUES (2, 'us 2', 50.00, 'name 2', 'number 2', '2018-01-02');
INSERT INTO ussales (id, name, price, card_name, card_number, transaction_date) VALUES (3, 'us 3', 60.00, 'name 3', 'number 3', '2018-01-03');
INSERT INTO ussales (id, name, price, card_name, card_number, transaction_date) VALUES (4, 'us 4', 70.00, 'name 4', 'number 4', '2018-01-04');
INSERT INTO eusales (id, name, price, card_name, card_number, transaction_date) VALUES (1, 'eu 1', 40.00, 'name 1', 'number 1', '2018-01-01');
INSERT INTO eusales (id, name, price, card_name, card_number, transaction_date) VALUES (2, 'eu 2', 50.00, 'name 2', 'number 2', '2018-01-02');
INSERT INTO eusales (id, name, price, card_name, card_number, transaction_date) VALUES (3, 'eu 3', 60.00, 'name 3', 'number 3', '2018-01-03');
INSERT INTO eusales (id, name, price, card_name, card_number, transaction_date) VALUES (4, 'eu 4', 70.00, 'name 4', 'number 4', '2018-01-04');

SELECT * from ussales;
SELECT * from eusales;

SELECT 'US' as location, id, name, price, card_name, card_number, transaction_date FROM ussales WHERE price > 50.00
UNION ALL
SELECT 'EU' as location, id, name, price, card_name, card_number, transaction_date FROM eusales WHERE price > 50.00
ORDER BY location DESC, id;