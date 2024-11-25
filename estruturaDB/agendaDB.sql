CREATE database dbAgenda;

USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(20) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
    );

CREATE TABLE tb_categoria (
	cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
	nome_categoria VARCHAR(20) NOT NULL,
    usuario VARCHAR(20)
    );
    
DELIMITER $$
CREATE TRIGGER trInsertCategoria
BEFORE
INSERT
ON tb_categoria
FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END;
$$

DELIMITER ;



CREATE TABLE tb_log (
	id_log INT AUTO_INCREMENT PRIMARY KEY,
	usuario VARCHAR(40) NOT NULL,
    data_hora DATETIME NOT NULL,
    descricao VARCHAR(70)
    );
    
DELIMITER $$
CREATE TRIGGER trLogDeleteCategoria
AFTER
DELETE 
ON tb_categoria
FOR EACH ROW
BEGIN
	INSERT INTO tb_log
		(usuario,
		data_hora,
		descricao)
    VALUES
		(USER(),
        CURRENT_DATE(),
        CONCAT('A categoria ', OLD.nome_categoria, ' foi excluida')
		);
END;
$$

DELIMITER ;

DELIMITER $$
CREATE TRIGGER trLogInsertCategoria
AFTER
INSERT
ON tb_categoria
FOR EACH ROW
BEGIN
	INSERT INTO tb_log
		(usuario,
		data_hora,
		descricao)
    VALUES
		(USER(),
        CURRENT_DATE(),
        CONCAT('A categoria ', NEW.nome_categoria, ' foi inserida')
		);
END;
$$

DELIMITER ;

DELIMITER $$
CREATE TRIGGER trLogUpdateCategoria
AFTER
UPDATE
ON tb_categoria
FOR EACH ROW
BEGIN
	INSERT INTO tb_log
		(usuario,
		data_hora,
		descricao)
    VALUES
		(USER(),
        CURRENT_DATE(),
        CONCAT('A categoria ', OLD.nome_categoria, ' foi alterada para ', NEW.nome_categoria)
		);
END;
$$

DELIMITER ;
