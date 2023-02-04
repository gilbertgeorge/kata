-- You are a border guard sitting on the Canadian border. You were given a list of travelers who have
-- arrived at your gate today. You know that American, Mexican, and Canadian citizens don't need visas,
-- so they can just continue their trips. You don't need to check their passports for visas! You only
-- need to check the passports of citizens of all other countries!
--
-- Select names, and countries of origin of all the travelers, excluding anyone from Canada, Mexico, or The US.
--
-- travelers table schema
--
-- name
-- country

CREATE TABLE travelers (name VARCHAR(255), country VARCHAR(255));

INSERT INTO travelers (name, country) VALUES ('John', 'Canada');
INSERT INTO travelers (name, country) VALUES ('Mary', 'Mexico');
INSERT INTO travelers (name, country) VALUES ('Bob', 'USA');
INSERT INTO travelers (name, country) VALUES ('Jane', 'France');

SELECT name, country
FROM travelers
WHERE country NOT IN ('Canada', 'Mexico', 'USA');