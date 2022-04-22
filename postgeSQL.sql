CREATE TABLE public.chess_player (
    id serial NOT NULL,
    full_name text NOT NULL,
    description text NOT NULL,
    picture text NOT NULL,
    rank text
);

CREATE TABLE public.content_for_theory (
    id serial NOT NULL,
    article text,
    picture text,
    id_theory integer NOT NULL
);

CREATE TABLE public.historical_chess_game (
    id serial NOT NULL,
    title text NOT NULL,
    description text NOT NULL,
    date date NOT NULL,
    id_chess_player_1 integer NOT NULL,
    id_chess_player_2 integer NOT NULL,
    "id_game(NoSQL)" integer NOT NULL
);

CREATE TABLE public.post (
    id serial NOT NULL,
    title text NOT NULL,
    id_chess_player integer,
    id_video_lesson integer,
    id_historical_chess_game integer,
    id_theory integer
);

CREATE TABLE public.task (
    id serial NOT NULL,
    title text NOT NULL,
    description text NOT NULL,
    id_theory integer NOT NULL,
    "id_game(NoSQL)" integer NOT NULL
);

CREATE TABLE public.theory (
    id serial NOT NULL,
    title text NOT NULL,
    description text NOT NULL,
    id_type_of_theory integer NOT NULL
);

CREATE TABLE public.type_of_theory (
    id serial NOT NULL,
    title text NOT NULL
);

CREATE TABLE public.video_lesson (
    id serial NOT NULL,
    title text NOT NULL,
    link text NOT NULL
);

ALTER TABLE ONLY public.chess_player
    ADD CONSTRAINT chess_player_pkey PRIMARY KEY (id);
	
ALTER TABLE ONLY public.content_for_theory
    ADD CONSTRAINT content_for_theory_pkey PRIMARY KEY (id);

ALTER TABLE ONLY public.historical_chess_game
    ADD CONSTRAINT historical_chess_game_pkey PRIMARY KEY (id);
	
ALTER TABLE ONLY public.post
    ADD CONSTRAINT post_pkey PRIMARY KEY (id);

ALTER TABLE ONLY public.task
    ADD CONSTRAINT task_pkey PRIMARY KEY (id);
	
ALTER TABLE ONLY public.theory
    ADD CONSTRAINT theory_pkey PRIMARY KEY (id);

ALTER TABLE ONLY public.type_of_theory
    ADD CONSTRAINT type_of_theory_pkey PRIMARY KEY (id);
	
ALTER TABLE ONLY public.video_lesson
    ADD CONSTRAINT video_lesson_pkey PRIMARY KEY (id);

ALTER TABLE ONLY public.content_for_theory
    ADD CONSTRAINT content_for_theory_id_theory_fkey FOREIGN KEY (id_theory) REFERENCES public.theory(id) NOT VALID;

ALTER TABLE ONLY public.post
    ADD CONSTRAINT fk_chess_player FOREIGN KEY (id_chess_player) REFERENCES public.chess_player(id) NOT VALID;

ALTER TABLE ONLY public.post
    ADD CONSTRAINT fk_video_lesson FOREIGN KEY (id_video_lesson) REFERENCES public.video_lesson(id) NOT VALID;

ALTER TABLE ONLY public.historical_chess_game
    ADD CONSTRAINT historical_chess_game_id_chess_player_1_fkey FOREIGN KEY (id_chess_player_1) REFERENCES public.chess_player(id) NOT VALID;

ALTER TABLE ONLY public.historical_chess_game
    ADD CONSTRAINT historical_chess_game_id_chess_player_2_fkey FOREIGN KEY (id_chess_player_2) REFERENCES public.chess_player(id) NOT VALID;

ALTER TABLE ONLY public.post
    ADD CONSTRAINT post_id_historical_chess_game_fkey FOREIGN KEY (id_historical_chess_game) REFERENCES public.historical_chess_game(id) NOT VALID;

ALTER TABLE ONLY public.post
    ADD CONSTRAINT post_id_theory_fkey FOREIGN KEY (id_theory) REFERENCES public.theory(id) NOT VALID;

ALTER TABLE ONLY public.task
    ADD CONSTRAINT task_id_theory_fkey FOREIGN KEY (id_theory) REFERENCES public.theory(id) NOT VALID;

ALTER TABLE ONLY public.theory
    ADD CONSTRAINT theory_id_type_of_theory_fkey FOREIGN KEY (id_type_of_theory) REFERENCES public.type_of_theory(id) NOT VALID;


INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Магнус Карлсен', 'Свен Ма́гнус Э́эн Ка́рлсен (норв. Sven Magnus Øen Carlsen; род. 30 ноября 1990 года, Тёнсберг, губерния Вестфолл, Норвегия) — норвежский шахматист, 16-й (действующий) чемпион мира по шахматам (2013). Чемпион мира по шахматам в трёх категориях: с 2013 года — чемпион мира по классическим шахматам; в 2014—2016, 2019 годах — чемпион мира по рапиду[5]; в 2014—2015, 2017—2019 годах — чемпион мира по блицу[5]. Один из самых молодых гроссмейстеров мира — стал им 26 апреля 2004 года в возрасте 13 лет 4 месяцев 27 дней (на тот момент он был вторым в списке самых молодых гроссмейстеров мира).', 'pictureMagnus', '2864');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Алиреза Фирузджа', 'Алиреза́ Фирузджа́ (распространён неточный вариант Фируджа) (перс. علیرضا فیروزجاه‎, 18 июня 2003 года) — французский, ранее иранский шахматист, гроссмейстер. Стал гроссмейстером в возрасте 14 лет. Серебряный призёр чемпионата мира по рапиду 2019 года. Бронзовый призёр чемпионата мира по блицу 2021 года. Двукратный чемпион Ирана (2016, 2019).', 'pictureAlireza', '2804');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Дин Лижэнь', 'Дин Лижэ́нь (кит. упр. 丁立人, пиньинь Dīng Lìrén; род. 24 октября 1992) — китайский шахматист, гроссмейстер (2009). Играет в шахматы с четырёх лет[3].', 'pictureDin', '2799');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Левон Аронян', 'Лево́н Григо́рьевич Ароня́н (арм. Լևոն Գրիգորիի Արոնյան; род. 6 октября 1982 года, Ереван, Армянская ССР) — американский, раннее армянский шахматист, гроссмейстер. Победитель множества престижных международных турниров, включая единоличные победы в турнирах Линарес (2006), Вейк-ан-Зее (2012, 2014), Кубок Синкфилда (2015), Ставангер (2017). Двукратный обладатель Кубка мира ФИДЕ (2005, 2017), победитель Гран-при ФИДЕ 2008/2009, трёхкратный олимпийский чемпион в составе сборной Армении (2006, 2008, 2012), чемпион мира по рапиду (2009), чемпион мира по блицу (2010).', 'pictureLevon', '2785');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Фабиано Каруана', 'Фабиа́но Луи́джи Каруа́на (итал. Fabiano Luigi Caruana; род. 30 июля 1992, Майами, Флорида, США) — американский шахматист итальянского происхождения, международный гроссмейстер (2007).', 'pictureFabiano', '2781');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Уэсли Со', 'Уэ́сли Со (исп. Wesley Barbasa So; 9 октября 1993, Бакоор, Кавите, Филиппины) — американский шахматист, гроссмейстер (2008). Сильнейший (по рейтингу) шахматист за всю историю Филиппин. Победитель чемпионата мира по шахматам Фишера 2019 года — первого чемпионата, признанного ФИДЕ[3]. Уэсли Со известен как шахматный вундеркинд. Он завоевал титул гроссмейстера в возрасте 14 лет, одного месяца и 28 дней, став по этому показателю девятнадцатым за всю историю шахмат (первое место с возрастом в 12 лет, 4 месяцев и 25 дней — у Абхиманью Мишры). Кроме того, Со стал самым молодым шахматистом, преодолевшим рейтинговую отметку в 2600 пунктов.', 'pictureUesli', '2778');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Рихард Раппорт', 'Ри́хард Ра́ппорт (венг. Rapport Richárd; род. 25 марта 1996, Сомбатхей) — венгерский шахматист, гроссмейстер (2010). Чемпион Венгрии 2017 года. Член символического клуба победителей чемпионов мира Михаила Чигорина с 22 января 2017 года. Раппорт дошел до четвертьфинала кубка мира по шахматам 2017, но проиграл Дину Лижэню. Ученик Александра Белявского.', 'pictureRihard', '2776');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Аниш Гири', 'Аниш Кумар[2] Гири (род. 28 июня 1994 года, Санкт-Петербург, Россия) — нидерландский шахматист, гроссмейстер (2009), чемпион Нидерландов (2009, 2011, 2012, 2015). Воспитанник ДЮСШ-2 Калининского района Санкт-Петербурга. Гроссмейстерскую норму Аниш выполнил в 14,5 лет. С 2009 года Гири представляет Нидерланды в личных и командных соревнованиях под эгидой ФИДЕ. 17 января 2011 года нанёс поражение лидеру мирового рейтинга норвежцу Магнусу Карлсену, вынудив его сдаться уже после 22 ходов, в третьем туре традиционного шахматного турнира в Вейк-ан-Зее[3]. Максимальный рейтинг Эло: 2798 (январь 2016 года).', 'PictureAnish', '2773');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Ян Непомнящий', 'Ян Алекса́ндрович Непо́мнящий (род. 14 июля 1990, Брянск) — российский шахматист, гроссмейстер (2007). Чемпион Европы 2010 года. Двукратный чемпион России (2010 и 2020), двукратный победитель командного чемпионата мира в составе команды России (2013 и 2019), победитель Турнира претендентов по шахматам (2020/2021). Спортивное прозвище — «Непо».', 'PictureYan', '2773');
INSERT INTO public.chess_player (full_name, description, picture, rank) VALUES ('Шахрияр Мамедьяров', 'Шахрия́р Гами́д оглы Мамедья́ров[2] (азерб. Şəhriyar Həmid oğlu Məmmədyarov; род. 12 апреля 1985, Сумгаит, Азербайджанская ССР) — азербайджанский шахматист, международный гроссмейстер. Трёхкратный чемпион Европы (2009, 2013, 2017) командного чемпионата в составе сборной Азербайджана, чемпион мира по быстрым шахматам (2013). Единственный шахматист в истории, становившийся чемпионом мира среди юниоров более одного раза (2003, 2005)[3], чемпион мира среди юношей до 18 лет (2003). Участник турнира претендентов 2014 и 2018. Член символических клубов победителей чемпионов мира Михаила Чигорина и Эугенио Торре (2018)[4].', 'pictureSharihard', '2771');


