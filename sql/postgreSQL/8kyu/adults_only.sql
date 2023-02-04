-- In your application, there is a section for adults only. You need to get a list of names and ages of users from the users table, who are 18 years old or older.
--
-- users table schema
--
-- name
-- age

CREATE TABLE users (
  name VARCHAR(255),
  age INT
);

INSERT INTO users (name, age) VALUES ('John', 18);
INSERT INTO users (name, age) VALUES ('Jane', 17);
INSERT INTO users (name, age) VALUES ('Jack', 19);
INSERT INTO users (name, age) VALUES ('Jill', 20);

SELECT name, age
FROM users WHERE age >= 18;