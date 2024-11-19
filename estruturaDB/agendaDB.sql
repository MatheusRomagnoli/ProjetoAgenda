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
