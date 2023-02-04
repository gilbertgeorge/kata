-- Oh no! Timmys been moved into the database divison of his software company but as we know Timmy loves making
-- mistakes. Help Timmy keep his job by fixing his query...
--
-- Timmy works for a statistical analysis company and has been given a task of calculating the highest average
-- salary for a given job, the sample is compiled of 100 applicants each with a job and a salary. Timmy must
-- display each unique job, the total average salary, the total people and the total salary and order by highest
-- average salary. Timmy has some bugs in his query, help Timmy fix his query so he can keep his job!
--
-- people table schema
-- id
-- name
-- job table schema
-- id
-- people_id
-- job_title
-- salary
-- resultant table schema
-- job_title (unique)
-- average_salary (float, 2 dp)
-- total_people (int)
-- total_salary (float, 2 dp)

CREATE TABLE job (
    id SERIAL PRIMARY KEY,
    people_id INT NOT NULL,
    job_title VARCHAR(255) NOT NULL,
    salary FLOAT NOT NULL
);

SELECT * FROM people;
SELECT * FROM job;

INSERT INTO job (people_id, job_title, salary) VALUES (1, 'Developer', 10000);
INSERT INTO job (people_id, job_title, salary) VALUES (2, 'Developer', 20000);
INSERT INTO job (people_id, job_title, salary) VALUES (3, 'Senior Developer', 30000);
INSERT INTO job (people_id, job_title, salary) VALUES (4, 'Senior Developer', 40000);
INSERT INTO job (people_id, job_title, salary) VALUES (5, 'Lead Developer', 50000);

SELECT
    job_title,
    CAST(ROUND(CAST(AVG(salary) as numeric), 2) AS FLOAT) AS average_salary,
    COUNT(*) AS total_people,
    CAST(ROUND(CAST(SUM(salary) as numeric), 2) AS FLOAT) AS total_salary
FROM job
GROUP BY job_title
ORDER BY average_salary DESC;
