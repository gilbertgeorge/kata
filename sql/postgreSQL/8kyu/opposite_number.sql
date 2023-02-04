-- Very simple, given an integer or a floating-point number, find its opposite.
--
-- Examples:
--
-- 1: -1
-- 14: -14
-- -34: 34
-- You will be given a table: opposite, with a column: number. Return a table with a column: res.

create table opposite (number int);
INSERT INTO opposite VALUES (1), (14), (-34);

SELECT -number as res
FROM opposite;