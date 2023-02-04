-- There is an events table used to track different key activities taken on a website. For this task you need to:
--
-- find the entries whose name equals "trained"
-- group them by the day the activity happened (the date part of the created_at timestamp) and their description's
-- the 2 aforementioned fields should be returned together with the number of grouped entries in a column called count
-- the result should also be sorted by day
-- "events" table schema
-- id (bigint)
-- name (text)
-- created_at (timestamp)
-- description (text)
-- expected result schema
-- day (date)
-- description (text)
-- count (numeric)

CREATE TABLE events (
  id bigint,
  name text,
  created_at timestamp,
  description text
);

INSERT INTO events (id, name, created_at, description) VALUES (1, 'trained', '2019-01-01 10:00:00', 'description 1');
INSERT INTO events (id, name, created_at, description) VALUES (2, 'trained', '2019-01-01 11:00:00', 'description 2');
INSERT INTO events (id, name, created_at, description) VALUES (3, 'trained', '2019-01-02 10:00:00', 'description 1');
INSERT INTO events (id, name, created_at, description) VALUES (4, 'trained', '2019-01-02 11:00:00', 'description 2');
INSERT INTO events (id, name, created_at, description) VALUES (5, 'trained', '2019-01-03 10:00:00', 'description 1');
INSERT INTO events (id, name, created_at, description) VALUES (6, 'trained', '2019-01-03 11:00:00', 'description 2');
INSERT INTO events (id, name, created_at, description) VALUES (9, 'trained', '2019-01-01 10:00:00', 'description 1');
INSERT INTO events (id, name, created_at, description) VALUES (10, 'trained', '2019-01-01 11:00:00', 'description 2');
INSERT INTO events (id, name, created_at, description) VALUES (7, 'NOT-trained', '2019-01-04 10:00:00', 'description 1');
INSERT INTO events (id, name, created_at, description) VALUES (8, 'NOT-trained', '2019-01-04 11:00:00', 'description 2');

SELECT
  date_trunc('day', created_at) AS day,
  description,
  COUNT(*) AS count
FROM events
WHERE name = 'trained'
GROUP BY 1, 2
ORDER BY 1;