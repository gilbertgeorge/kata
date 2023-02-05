-- select from grades scores where score > 90 and type = 'exam'
SELECT scores.type as scores_type, scores.score as score
FROM grades
WHERE scores_type = 'exam' AND score > 90;