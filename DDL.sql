use studyDB;

drop TABLE userVocabulary;
drop TABLE userInfo;

CREATE TABLE userInfo(
  userId VARCHAR(20) NOT NULL primary key,
  userPassword VARCHAR(20) NOT NULL,
  alarmYN CHAR(2) NOT NULL,
  alarmTimestamp Time(7),
  loginTimestamp VARCHAR(60),
);

ALTER TABLE userInfo ADD CONSTRAINT DF_alarmYN DEFAULT 'N' FOR alarmYN

CREATE TABLE vocabulary (
  vocaNo int NOT NULL  primary key,
  userId VARCHAR(20) NOT NULL,
  wordName VARCHAR(50) NOT NULL,
  wordMeaning VARCHAR(128) NOT NULL,
  wrongCnt int NOT NULL,
  foreign key (userId) references userInfo(userId),
);

ALTER TABLE vocabulary ADD CONSTRAINT DF_wrongCnt DEFAULT 0 FOR wrongCnt;
