CREATE TABLE IF NOT EXISTS `books` (
  `id` BIGINT(10) NOT NULL AUTO_INCREMENT,
  `title` longtext,
  `author` longtext,
  `price` decimal(65,2) NOT NULL,
  `launch_date` datetime(6) NOT NULL,
  PRIMARY KEY (`id`)
)
