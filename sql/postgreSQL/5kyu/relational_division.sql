-- Given film_actor and film tables from the DVD Rental sample database find all movies both Sidney Crowe
-- (actor_id = 105) and Salma Nolte (actor_id = 122) cast in together and order the result set alphabetically.

SELECT * FROM actor;
SELECT * FROM film_actor;
SELECT * FROM film;

SELECT title FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
WHERE actor_id = 105
INTERSECT
SELECT title FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
WHERE actor_id = 122
ORDER BY title;