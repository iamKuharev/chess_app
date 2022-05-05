INSERT INTO avatar(
	path)
    VALUES ('planet11');
    
UPDATE avatar
	SET path = 'planet10'
    WHERE path = 'planet11';
    
DELETE FROM avatar
	WHERE path = 'planet10';
	
	
SELECT user.surname as "Фамилия", user.name as "Имя" FROM user 
	LEFT JOIN role r ON user.id_role = r.id
    WHERE r.title = 'Админ';
    
SELECT surname as "Фамилия", name as "Имя", t.title as "Название турнира" , t.start_data as "Дата начала турнира"  FROM user u
	LEFT JOIN `user-tournament-stage` uts ON uts.id_user = u.id
    LEFT JOIN tournament_stage ts ON uts.id_tournament_stage = ts.id
    LEFT JOIN tournament t ON ts.id_tournament = t.id
    WHERE surname = 'Иванов' and name = 'Иван';
    
SELECT title as "Название достижение", description as "Описание", surname as "Фамилия", name as "Имя" FROM achievement a
	RIGHT JOIN `user-achievement` ua ON ua.id_achievement = a.id
    LEFT JOIN user u ON ua.id_user = u.id
    WHERE a.title = 'Ultra kill';
