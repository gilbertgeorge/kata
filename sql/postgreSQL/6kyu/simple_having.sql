-- DESCRIPTION:
-- For this challenge you need to create a simple HAVING statement, you want to count how many people have the same age
-- and return the groups with 10 or more people who have that age.
--
-- people table schema
-- id
-- name
-- age
-- return table schema
-- age
-- total_people

SELECT * FROM people;
INSERT INTO people (name, age) VALUES ('Larry',35);
INSERT INTO people (name, age) VALUES ('Harry',35);
INSERT INTO people (name, age) VALUES ('Rob',35);
INSERT INTO people (name, age) VALUES ('Tom',35);
INSERT INTO people (name, age) VALUES ('Aaron',35);
INSERT INTO people (name, age) VALUES ('Bob',35);


SELECT age, COUNT(*) AS total_people
FROM people
GROUP BY age
HAVING COUNT(*) >= 10;