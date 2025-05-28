
CREATE TABLE sucursal (
    idsucursal        NUMBER PRIMARY KEY,
    nombresucursal    VARCHAR2(15),
    ciudadsucursal    VARCHAR2(15),
    activos           NUMBER,
    region            VARCHAR2(2)
);
/

CREATE TABLE prestamo (
    noprestamo        NUMBER PRIMARY KEY,
    idsucursal        NUMBER,
    cantidad          NUMBER,
    CONSTRAINT fk_idsucursal FOREIGN KEY (idsucursal)
        REFERENCES sucursal(idsucursal)
);
/

INSERT INTO sucursal VALUES (1, 'Downtown',  'Brooklyn',   900000,  'A');
INSERT INTO sucursal VALUES (2, 'Redwood',   'Palo Alto',  2100000, 'A');
INSERT INTO sucursal VALUES (3, 'Perryridge','Horseneck',  1700000, 'A');
INSERT INTO sucursal VALUES (4, 'Mianus',    'Horseneck',   400200, 'A');

INSERT INTO prestamo VALUES (17, 1, 1000);
INSERT INTO prestamo VALUES (23, 2, 2000);
INSERT INTO prestamo VALUES (15, 3, 1500);
INSERT INTO prestamo VALUES (14, 1, 1500);
INSERT INTO prestamo VALUES (93, 4,  500);
INSERT INTO prestamo VALUES (16, 3, 1300);


select * from sucursal;
select * from prestamo;