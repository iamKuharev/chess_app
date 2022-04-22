
CREATE DATABASE IF NOT EXISTS `chessdatausers`
USE `chessdatausers`;

CREATE TABLE IF NOT EXISTS `achievement` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;

INSERT INTO `achievement` (`id`, `title`, `description`) VALUES
	(1, 'First blood', 'Победить один раз'),
	(2, 'Double kill', 'Победить два раза'),
	(3, 'Triple kill', 'Победить три раза'),
	(4, 'Ultra kill', 'Победить четыре раза'),
	(5, 'Rampaaaaaaaaaage!!!', 'Победить пять раз'),
	(6, 'Свежий кабанчик', 'Решить одну задачу'),
	(7, 'Хороший ученик', 'Решить пять задач'),
	(8, 'Рикошет', 'Поставить пат'),
	(9, 'Чел хорош', 'Решить десять задач'),
	(10, 'Чел мегахорош', 'Решить одинадцать задач'),
	(11, 'Не имей сто рублей, а имей друга', 'Добавить друга'),
	(12, 'Сын маминой подруги', 'Победить в турнире');
    
CREATE TABLE IF NOT EXISTS `avatar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `path` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;

INSERT INTO `avatar` (`id`, `path`) VALUES
	(1, 'planet1'),
	(2, 'planet2'),
	(3, 'planet3'),
	(4, 'planet4'),
	(5, 'planet5'),
	(6, 'planet6'),
	(7, 'planet7'),
	(8, 'planet8'),
	(9, 'planet9');

CREATE TABLE IF NOT EXISTS `rank` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;

INSERT INTO `rank` (`id`, `title`) VALUES
	(1, 'Гроссмейстер'),
	(2, 'Международный мастер'),
	(3, 'Мастер спорта'),
	(4, 'Кандидат в мастера'),
	(5, '1 разряд взрослый'),
	(6, '2 разряд взрослый'),
	(7, '3 разряд взрослый'),
	(8, '1 разряд юношский'),
	(9, '2 разряд юношский'),
	(10, '3 рязряд юношский'),
	(11, 'Без ранга');

CREATE TABLE IF NOT EXISTS `role` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;

INSERT INTO `role` (`id`, `title`) VALUES
	(1, 'Админ'),
	(2, 'Шахматист');

CREATE TABLE IF NOT EXISTS `tournament` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(50) NOT NULL,
  `start_data` date NOT NULL,
  `reward` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

INSERT INTO `tournament` (`id`, `title`, `description`, `start_data`, `reward`) VALUES
	(1, 'Турнир1', 'Описание1', '2022-01-01', '1000'),
	(2, 'Турнир2', 'Описание2', '2022-01-02', 'Пирожок'),
	(3, 'Турнир3', 'Описание3', '2022-01-03', '1200'),
	(4, 'Турнир4', 'Описание4', '2022-01-04', 'Хлеб с маслом'),
	(5, 'Турнир5', 'Описание5', '2022-01-05', '1400'),
	(6, 'Турнир6', 'Описание6', '2022-01-06', 'Чай'),
	(7, 'Турнир7', 'Описание7', '2022-01-07', '1600'),
	(8, 'Турнир8', 'Описание8', '2022-01-08', 'Блинчик'),
	(9, 'Турнир9', 'Описание9', '2022-01-09', '1601'),
	(10, 'Турнир10', 'Описание10', '2022-01-10', 'Бумага');

CREATE TABLE IF NOT EXISTS `tournament_stage` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `stage_type` varchar(50) NOT NULL DEFAULT '',
  `id_tournament` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_id_tournament_tournament` (`id_tournament`),
  CONSTRAINT `fk_id_tournament_tournament` FOREIGN KEY (`id_tournament`) REFERENCES `tournament` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

INSERT INTO `tournament_stage` (`id`, `stage_type`, `id_tournament`) VALUES
	(1, '1/16', 1),
	(2, '1/8', 1),
	(3, '1/4', 1),
	(4, '1/2', 1),
	(5, '1/16', 2),
	(6, '1/8', 2),
	(8, '1/4', 2),
	(9, '1/2', 2),
	(10, '1/16', 3);

CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `task_rate` int(11) NOT NULL,
  `id_avatar` int(11) NOT NULL,
  `id_rank` int(11) NOT NULL,
  `id_role` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_id_avatar_avatar` (`id_avatar`),
  KEY `fk_id_rank_rank` (`id_rank`),
  KEY `fk_id_role_role` (`id_role`),
  CONSTRAINT `fk_id_avatar_avatar` FOREIGN KEY (`id_avatar`) REFERENCES `avatar` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_id_rank_rank` FOREIGN KEY (`id_rank`) REFERENCES `rank` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_id_role_role` FOREIGN KEY (`id_role`) REFERENCES `role` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;

INSERT INTO `user` (`id`, `surname`, `name`, `login`, `password`, `task_rate`, `id_avatar`, `id_rank`, `id_role`) VALUES
	(1, 'Иванов', 'Иван', 'Ivan2005', 'Ivan2005', 5, 1, 11, 2),
	(2, 'Петров', 'Евгений', 'BigDuck', '777', 10, 2, 1, 1),
	(3, 'Абдулаев', 'Анатолий', 'Chuzoi', 'parol', 0, 3, 2, 2),
	(4, 'Шиш', 'Абдурозик', 'Zdarova', 'Otec', 2, 4, 11, 1),
	(5, 'Нешиш', 'Роман', 'Poka', 'Shish', 2, 5, 9, 2),
	(6, 'Бдыщь', 'Борис', 'Boroda', 'Boroda007', 3, 6, 11, 2),
	(7, 'Биба', 'Хазбик', 'BibaHazbik', '21321321', 0, 7, 7, 2),
	(8, 'Пупа', 'Олег', 'login', 'password', 3, 4, 7, 2),
	(9, 'Лупа', 'Юрий', 'password', 'login', 2, 6, 7, 2),
	(10, 'Тула', 'Москва', 'proezdom', 'vremenno', 0, 7, 11, 2);

CREATE TABLE IF NOT EXISTS `user-achievement` (
  `id_user` int(11) NOT NULL,
  `id_achievement` int(11) NOT NULL,
  PRIMARY KEY (`id_user`,`id_achievement`),
  KEY `fk_id_achievement_achievement` (`id_achievement`),
  CONSTRAINT `fk_id_achievement_achievement` FOREIGN KEY (`id_achievement`) REFERENCES `achievement` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_id_user_user` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

INSERT INTO `user-achievement` (`id_user`, `id_achievement`) VALUES
	(1, 10),
	(2, 4),
	(3, 2),
	(3, 3),
	(4, 7),
	(4, 8),
	(8, 11),
	(8, 12),
	(10, 4),
	(10, 11);

