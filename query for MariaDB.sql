INSERT INTO avatar(
	path)
    VALUES ('planet11');
    
UPDATE avatar
	SET path = 'planet10'
    WHERE path = 'planet11';
    
DELETE FROM avatar
	WHERE path = 'planet10';
