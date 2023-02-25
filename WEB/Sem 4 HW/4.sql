
-- create
CREATE TABLE classmates (
  empId INTEGER PRIMARY KEY AUTO_INCREMENT,
  name TEXT NOT NULL,
  age TEXT NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO classmates (name, age, address) VALUES ('Clark', '16', 'SPb');
INSERT INTO classmates (name, age, address) VALUES ('Dave', '17', 'Ekat');
INSERT INTO classmates (name, age, address) VALUES ('Ava', '18', 'SPb');
INSERT INTO classmates (name, age, address) VALUES ('Eva', '17', 'Msc');
INSERT INTO classmates (name, age, address) VALUES ('Anton', '19', 'SPb');
INSERT INTO classmates (name, age, address) VALUES ('Elsa', '18', 'Msc');
INSERT INTO classmates (name, age, address) VALUES ('Pola', '31', 'SPb');
INSERT INTO classmates (name, age, address) VALUES ('Serg', '16', 'Ekat');
INSERT INTO classmates (name, age, address) VALUES ('Anna', '21', 'Msc');


-- fetch 
SELECT name FROM classmates where age >= 18 and age < 30 AND address = 'Msc';