-- In baseball, the batting average is a simple and most common way to measure a hitter's performace.
-- Batting average is calculated by taking all the players hits and dividing it by their number of at_bats,
-- and it is usually displayed as a 3 digit decimal (i.e. 0.300).
-- Given a yankees table with the following schema,
-- -player_id STRING
-- -player_name STRING
-- -primary_position STRING
-- -games INTEGER
-- -at_bats INTEGER
-- -hits INTEGER
-- return a table with player_name, games, and batting_average.
-- We want batting_average to be rounded to the nearest thousandth, since that is how baseball fans are used to seeing
-- it. Format it as text and make sure it has 3 digits to the right of the decimal (pad with zeroes if neccesary).
-- Next, order our resulting table by batting_average, with the highest average in the first row.
-- Finally, since batting_average is a rate statistic, a small number of at_bats can change the average dramatically.
-- To correct for this, exclude any player who doesn't have at least 100 at bats.
-- Expected Output Table
-- -player_name STRING
-- -games INTEGER
-- -batting_average STRING

CREATE TABLE yankees (
    player_id VARCHAR(255),
    player_name VARCHAR(255),
    primary_position VARCHAR(255),
    games INTEGER,
    at_bats INTEGER,
    hits INTEGER
);

INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('1', 'Derek Jeter', 'SS', 162, 640, 216);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('2', 'Alex Rodriguez', '3B', 162, 647, 211);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('3', 'Mark Teixeira', '1B', 162, 608, 188);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('4', 'Robinson Cano', '2B', 162, 647, 205);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('5', 'Nick Swisher', 'RF', 162, 608, 183);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('6', 'Curtis Granderson', 'CF', 162, 608, 172);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('7', 'Jorge Posada', 'C', 162, 608, 171);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('8', 'Andruw Jones', 'LF', 162, 608, 169);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('9', 'Eric Chavez', '3B', 162, 608, 169);
INSERT INTO yankees (player_id, player_name, primary_position, games, at_bats, hits) VALUES ('10', 'Russell Martin', 'C', 162, 98, 16);

SELECT player_name, games, to_char(ROUND(hits/at_bats::numeric, 3), 'FM0.000') AS batting_average
FROM yankees
WHERE at_bats >= 100
ORDER BY batting_average DESC;