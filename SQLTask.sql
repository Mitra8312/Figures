create database test1
go

use test1
go

CREATE TABLE product (
    product_id INT IDENTITY(1,1) PRIMARY KEY,
    product_Name VARCHAR(128) NOT NULL UNIQUE
);

CREATE TABLE type_product (
    type_product_id INT IDENTITY(1,1) PRIMARY KEY,
    type_product_name VARCHAR(56) UNIQUE
);

CREATE TABLE product_types (
    product_types_id INT IDENTITY(1,1) PRIMARY KEY,
    id_type_product INT NOT NULL,
    id_product INT NOT NULL,
    FOREIGN KEY (id_type_product) REFERENCES type_product(type_product_Id),
    FOREIGN KEY (id_product) REFERENCES product(product_Id)
);


-- Добавление данных в таблицу type_product
INSERT INTO type_product (type_product_name) VALUES ('Кондиционер');
INSERT INTO type_product (type_product_name) VALUES ('Обогреватель');
INSERT INTO type_product (type_product_name) VALUES ('Вентилятор');
INSERT INTO type_product (type_product_name) VALUES ('Увлажнитель воздуха');

-- Добавление данных в таблицу product
INSERT INTO product (product_Name) VALUES ('Кондиционер LG');
INSERT INTO product (product_Name) VALUES ('Обогреватель DeLonghi');
INSERT INTO product (product_Name) VALUES ('Вентилятор Dyson');
INSERT INTO product (product_Name) VALUES ('Увлажнитель воздуха Philips');
INSERT INTO product (product_Name) VALUES ('Настольный вентилятор ClimaTech');
INSERT INTO product (product_Name) VALUES ('Настольный вентилятор FirmaPridumal');

-- Добавление данных в таблицу product_types
INSERT INTO product_types (id_type_product, id_product) VALUES (1, 1);
INSERT INTO product_types (id_type_product, id_product) VALUES (2, 2);
INSERT INTO product_types (id_type_product, id_product) VALUES (3, 3);
INSERT INTO product_types (id_type_product, id_product) VALUES (4, 4);

SELECT product_Name, type_product_name
FROM product
LEFT JOIN product_types ON product_Id = id_product
LEFT JOIN type_product ON id_type_product = type_product_Id;

