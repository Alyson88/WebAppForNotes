--NotesDB Setup

--DROP TABLE app_user;

CREATE TABLE app_user (
username varchar(32) NOT NULL,
password nvarchar(32) NOT NULL,
email nvarchar(max) NOT NULL,
first_name varchar(50),
last_name varchar(100),
updates bit,
is_admin bit,
CONSTRAINT pk_app_user_username PRIMARY KEY (username)
);


INSERT INTO app_user (username, password, email, first_name, last_name, updates, is_admin) VALUES ('alysonmw11', 'password', 'alysonmw11@gmail.com', 'Alyson', 'Wood', 1, 1);