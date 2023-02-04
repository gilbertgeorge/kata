-- For this challenge you need to create a simple GROUP BY statement, you want to group all the people by their
-- age and count the people who have the same age.
--
-- people table schema
-- id
-- name
-- age
--
-- select table schema
-- age [group by]
-- people_count (people count)

SELECT * FROM people;

INSERT INTO people (name, age) VALUES ('Steve', 20);
INSERT INTO people (name, age) VALUES ('Bill', 35);
INSERT INTO people (name, age) VALUES ('Mark', 20);
INSERT INTO people (name, age) VALUES ('Paul', 35);
INSERT INTO people (name, age) VALUES ('Jim', 35);
INSERT INTO people (name, age) VALUES ('Jane', 25);

SELECT age, COUNT(*) AS people_count
FROM people
GROUP BY age;