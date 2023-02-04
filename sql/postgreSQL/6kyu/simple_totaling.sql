-- For this challenge you need to create a simple query to display each unique clan with their total points and
-- ranked by their total points.
--
-- people table schema
-- name
-- points
-- clan
-- You should then return a table that resembles below
--
-- select on
-- rank
-- clan
-- total_points
-- total_people
-- The query must rank each clan by their total_points, you must return each unqiue clan and if there is no clan
-- name (i.e. it's an empty string) you must replace it with [no clan specified], you must sum the total_points
-- for each clan and the total_people within that clan.

CREATE TABLE people_clan (
    name VARCHAR(255),
    points INT,
    clan VARCHAR(255)
);

INSERT INTO people_clan VALUES ('John', 100, 'Clan A');
INSERT INTO people_clan VALUES ('Jane', 200, 'Clan A');
INSERT INTO people_clan VALUES ('Jim', 300, 'Clan B');
INSERT INTO people_clan VALUES ('Jill', 400, 'Clan B');
INSERT INTO people_clan VALUES ('Jack', 500, 'Clan C');
INSERT INTO people_clan VALUES ('James', 600, '');
INSERT INTO people_clan VALUES ('Jack', 700);

SELECT * FROM people_clan;

SELECT
    ROW_NUMBER() OVER (ORDER BY SUM(points) DESC) AS rank,
    COALESCE(NULLIF(clan,''), '[no clan specified]') AS clan,
    SUM(points) AS total_points,
    COUNT(*) AS total_people
FROM people_clan
GROUP BY NULLIF(clan,'')
ORDER BY rank;