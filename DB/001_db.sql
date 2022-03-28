create database if not exists `Katilla` character set utf8 collate utf8_hungarian_ci;
drop table if exists `karakter_verziok`;
drop table if exists `karakter`;
create table if not exists `karakter` (
  `id` int unsigned not null auto_increment primary key,  
  `faj` text  
)engine = innoDB;
drop table if exists `karakter_verziok`;
create table if not exists `karakter_verziok` (
  `id` int unsigned not null auto_increment primary key,
  `karakter_id` int unsigned not null,  
  foreign key (`karakter_id`) references `karakter`(`id`) on delete cascade,
  `nev` varchar(255) not null,
  unique index (`nev`),
  `alkaszt` text,
  `szint` text,
  `datum` datetime default current_timestamp,
  index (`datum`)
)engine = innoDB;