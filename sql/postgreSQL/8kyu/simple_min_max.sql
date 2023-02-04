-- DESCRIPTION:
-- For this challenge you need to create a simple MIN / MAX statement that will return the Minimum and Maximum ages out of all the people.
--
-- people table schema
-- id
-- name
-- age
-- select table schema
-- age_min (minimum of ages)
-- age_max (maximum of ages)

CREATE TABLE people (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    age INT NOT NULL
);

INSERT INTO people (name, age) VALUES ('John', 25);
INSERT INTO people (name, age) VALUES ('Mary', 30);
INSERT INTO people (name, age) VALUES ('Peter', 20);
INSERT INTO people (name, age) VALUES ('Jane', 35);

SELECT *
FROM people;

SELECT MIN(age) AS age_min, MAX(age) AS age_max
FROM people;