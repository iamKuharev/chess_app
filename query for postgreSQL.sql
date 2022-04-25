INSERT INTO public.chess_player(
	full_name, description, picture)
	VALUES ('Хомуха Иван Петрович', 'русский шахматист', 'pictureHomuha');
	
UPDATE public.chess_player
	SET full_name='Хомуха Иван Петрович', description='русский шахматист', picture='pictureHomuha', rank='1900'
	WHERE full_name='Хомуха Иван Петрович';
	
DELETE FROM public.chess_player
	WHERE full_name='Хомуха Иван Петрович';


SELECT *FROM post 
	LEFT JOIN chess_player cp  ON post.id_chess_player = cp.id
	LEFT JOIN video_lesson vl ON post.id_video_lesson = vl.id
	LEFT JOIN historical_chess_game hcg ON post.id_historical_chess_game = hcg.id
	LEFT JOIN theory th ON post.id_theory = th.id;
