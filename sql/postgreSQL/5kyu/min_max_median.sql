-- For this challenge you need to create a simple SELECT statement.
-- Your task is to calculate the MIN, MEDIAN and MAX scores of the students from the results table.
--
-- Resultant table:
-- min
-- median
-- max

CREATE TABLE student (id INT, name VARCHAR(200));
CREATE TABLE results (id INT, student_id INT, score INT);

INSERT INTO student VALUES (1, 'John');
INSERT INTO student VALUES (2, 'Mary');
INSERT INTO student VALUES (3, 'Peter');
INSERT INTO student VALUES (4, 'Jane');
INSERT INTO student VALUES (5, 'Mark');

INSERT INTO results VALUES (1, 1, 10);
INSERT INTO results VALUES (2, 1, 20);
INSERT INTO results VALUES (3, 1, 30);
INSERT INTO results VALUES (4, 2, 40);
INSERT INTO results VALUES (5, 2, 50);
INSERT INTO results VALUES (6, 2, 60);
INSERT INTO results VALUES (7, 3, 70);
INSERT INTO results VALUES (8, 3, 80);
INSERT INTO results VALUES (9, 3, 90);
INSERT INTO results VALUES (10, 4, 100);
INSERT INTO results VALUES (11, 4, 95);
INSERT INTO results VALUES (12, 4, 85);
INSERT INTO results VALUES (13, 5, 75);
INSERT INTO results VALUES (14, 5, 65);
INSERT INTO results VALUES (15, 5, 55);

SELECT MIN(score) AS min,
       ROUND(AVG(score),1)::FLOAT AS median,
       MAX(score) AS max
FROM results;
-- to get the median, we need to order the scores and then get the middle one
-- if there are an even number of scores, we need to get the average of the two middle ones
-- to get the min and max, we can just order the scores and get the first and last ones
SELECT MIN(score) AS min,
       percentile_cont(0.5) WITHIN GROUP(ORDER BY score DESC) AS median,
       MAX(score) AS max
FROM results;
