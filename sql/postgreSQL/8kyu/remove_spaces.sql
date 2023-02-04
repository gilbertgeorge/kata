-- Simple, remove the spaces from the string, then return the resultant string.
--   {x: "8 j 8   mBliB8g  imjB8B8  jl  B"},
--   {x: "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"},
--   {x: "8aaaaa dddd r     "},
--   {x: "jfBm  gk lf8hg  88lbe8 "},
--   {x: "8j aam"},
-- # write your SQL statement here: you are given a table 'nospace' with column 'x', return a table with column 'x'
-- and your result in a column named 'res'.
CREATE TABLE nospace (x varchar(100));

INSERT INTO nospace VALUES ('8 j 8   mBliB8g  imjB8B8  jl  B');
INSERT INTO nospace VALUES ('8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd');
INSERT INTO nospace VALUES ('8aaaaa dddd r     ');
INSERT INTO nospace VALUES ('jfBm  gk lf8hg  88lbe8 ');
INSERT INTO nospace VALUES ('8j aam');

SELECT *
FROM nospace;

SELECT x, REPLACE(x, ' ', '') AS res
FROM nospace;