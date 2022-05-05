INSERT INTO public.chess_player(
	full_name, description, picture)
	VALUES ('Хомуха Иван Петрович', 'русский шахматист', 'pictureHomuha');
	
UPDATE public.chess_player
	SET full_name='Хомуха Иван Петрович', description='русский шахматист', picture='pictureHomuha', rank='1900'
	WHERE full_name='Хомуха Иван Петрович';
	
DELETE FROM public.chess_player
	WHERE full_name='Хомуха Иван Петрович';


SELECT *FROM post 
	LEFT JOIN chess_player cp ON post.id_chess_player = cp.id
	LEFT JOIN video_lesson vl ON post.id_video_lesson = vl.id
	LEFT JOIN historical_chess_game hcg ON post.id_historical_chess_game = hcg.id
	LEFT JOIN theory th ON post.id_theory = th.id;
	
SELECT title as "название", hcg.description as "описание", "id_game(NoSQL)", cp1.full_name as "Полное имя", cp2.full_name as "Полное имя" FROM historical_chess_game hcg
	LEFT JOIN chess_player cp1 ON hcg.id_chess_player_1 = cp1.id
	LEFT JOIN chess_player cp2 ON hcg.id_chess_player_2 = cp2.id
	WHERE cp1.full_name = 'Магнус Карлсен' OR cp2.full_name = 'Магнус Карлсен';
	
SELECT theory.title as "Название", theory.description as "Описание", tot.title as "Тип теории"  FROM theory
	LEFT JOIN type_of_theory tot ON theory.id_type_of_theory = tot.id
	WHERE tot.title = 'Открытые дебюты';
