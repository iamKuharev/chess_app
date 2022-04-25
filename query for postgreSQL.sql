INSERT INTO public.chess_player(
	full_name, description, picture)
	VALUES ('Хомуха Иван Петрович', 'русский шахматист', 'pictureHomuha');
	
UPDATE public.chess_player
	SET full_name='Хомуха Иван Петрович', description='русский шахматист', picture='pictureHomuha', rank='1900'
	WHERE full_name='Хомуха Иван Петрович';
	
DELETE FROM public.chess_player
	WHERE full_name='Хомуха Иван Петрович';
