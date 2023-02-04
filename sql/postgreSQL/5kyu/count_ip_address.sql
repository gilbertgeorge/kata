-- Given a database of first and last IPv4 addresses, calculate the number of addresses between them (including the first one, excluding the last one).
--
-- Input
-- ---------------------------------
-- |     Table    | Column | Type  |
-- |--------------+--------+-------|
-- | ip_addresses | id     | int   |
-- |              | first  | text  |
-- |              | last   | text  |
-- ---------------------------------
-- Output
-- -------------------------
-- |   Column    |  Type   |
-- |-------------+---------|
-- | id          | int     |
-- | ips_between | bigint  |
-- -------------------------
-- All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.
--
-- Examples
-- * With input "10.0.0.0", "10.0.0.50"  => return   50
-- * With input "10.0.0.0", "10.0.1.0"   => return  256
-- * With input "20.0.0.10", "20.0.1.0"  => return  246

CREATE TABLE ip_addresses (id int, first text, last text);
--postgresql function to convert ip address to integer
CREATE OR REPLACE FUNCTION ip_to_int(ip text) RETURNS bigint AS $$
DECLARE
    ip_array text[] := string_to_array(ip, '.');
    ip_int bigint := 0;
BEGIN
    ip_int := (ip_array[1]::bigint * 256^3) + (ip_array[2]::bigint * 256^2) + (ip_array[3]::bigint * 256) + ip_array[4]::bigint;
    RETURN ip_int;
END;
$$ LANGUAGE plpgsql;

INSERT INTO ip_addresses VALUES (1, '10.0.0.0', '10.0.0.50');
INSERT INTO ip_addresses VALUES (2, '10.0.0.0', '10.0.1.0');
INSERT INTO ip_addresses VALUES (3, '20.0.0.10', '"20.0.1.0');
SELECT id, (ip_to_int(last) - ip_to_int(first)) AS ips_between
FROM ip_addresses;

SELECT id, (last::inet - first::inet) AS ips_between
FROM ip_addresses;