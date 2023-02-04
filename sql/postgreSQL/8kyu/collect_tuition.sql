-- You are working for a local school, and you are responsible for collecting tuition from students.
-- You have a list of all students, some of them have already paid tution and some haven't.
-- Write a select statement to get a list of all students who haven't paid their tuition yet.
-- The list should include all the data available about these students.
--
-- students table schema
--
-- name (string)
-- age (integer)
-- semester (integer)
-- mentor (string)
-- tuition_received (Boolean)

CREATE TABLE students (
    name VARCHAR(255),
    age INTEGER,
    semester INTEGER,
    mentor VARCHAR(255),
    tuition_received BOOLEAN
);

INSERT INTO students (name, age, semester, mentor, tuition_received)
VALUES ('John', 20, 1, 'John', FALSE),
       ('Mary', 21, 2, 'Mary', TRUE),
       ('Peter', 22, 3, 'Peter', FALSE),
       ('Jane', 23, 4, 'Jane', TRUE),
       ('Bob', 24, 5, 'Bob', FALSE);

SELECT *
FROM students
WHERE tuition_received = FALSE;