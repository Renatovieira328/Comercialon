---- MySQL Workbench Forward Engineering

--SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
--SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
--SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

---- -----------------------------------------------------
---- Schema mydb
---- -----------------------------------------------------
---- -----------------------------------------------------
---- Schema comercialondb
---- -----------------------------------------------------

---- -----------------------------------------------------
---- Schema comercialondb
---- -----------------------------------------------------
--CREATE SCHEMA IF NOT EXISTS `comercialondb` DEFAULT CHARACTER SET utf8 ;
--USE `comercialondb` ;

---- -----------------------------------------------------
---- Table `comercialondb`.`categorias`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`categorias` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `nome` VARCHAR(45) NOT NULL,
--  `sigla` VARCHAR(45) NULL DEFAULT NULL,
--  PRIMARY KEY (`id`))
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`clientes`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`clientes` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `nome` VARCHAR(45) NOT NULL,
--  `cpf` VARCHAR(11) NOT NULL,
--  `email` VARCHAR(45) NOT NULL,
--  `telefone` VARCHAR(14) NULL DEFAULT NULL,
--  `ativo` BIT(1) NOT NULL DEFAULT b'1',
--  PRIMARY KEY (`id`),
--  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) ,
--  UNIQUE INDEX `email_UNIQUE` (`email` ASC) ,
--  INDEX `index1` (`id` ASC) )
--ENGINE = InnoDB
--AUTO_INCREMENT = 4
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`enderecos`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`enderecos` (
--  `Clientes_id` INT(11) NOT NULL,
--  `cep` VARCHAR(8) NOT NULL,
--  `logradouro` VARCHAR(45) NOT NULL,
--  `numero` VARCHAR(45) NOT NULL,
--  `complemento` VARCHAR(45) NULL DEFAULT NULL,
--  `bairro` VARCHAR(45) NOT NULL,
--  `cidade` VARCHAR(45) NOT NULL,
--  `uf` CHAR(2) NOT NULL,
--  `tipo` VARCHAR(45) NOT NULL,
--  INDEX `fk_Enderecos_Clientes1_idx` (`Clientes_id` ASC) ,
--  CONSTRAINT `fk_Enderecos_Clientes1`
--    FOREIGN KEY (`Clientes_id`)
--    REFERENCES `comercialondb`.`clientes` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`usuarios`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`usuarios` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `nome` VARCHAR(45) NOT NULL,
--  `email` VARCHAR(45) NOT NULL,
--  `senha` CHAR(32) NOT NULL,
--  `nivel` VARCHAR(45) NOT NULL,
--  `ativo` BIT(1) NOT NULL DEFAULT b'1',
--  `cpf` CHAR(11) NOT NULL,
--  PRIMARY KEY (`id`),
--  UNIQUE INDEX `email_UNIQUE` (`email` ASC) ,
--  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) ,
--  INDEX `index1` (`id` ASC) )
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`pedidos`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`pedidos` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
--  `situacao` VARCHAR(45) NOT NULL DEFAULT 'A',
--  `desconto` DECIMAL(10,2) NOT NULL,
--  `Usuarios_id` INT(11) NOT NULL,
--  `Clientes_id` INT(11) NOT NULL,
--  PRIMARY KEY (`id`),
--  INDEX `fk_Pedidos_Usuarios_idx` (`Usuarios_id` ASC) ,
--  INDEX `fk_Pedidos_Clientes1_idx` (`Clientes_id` ASC) ,
--  CONSTRAINT `fk_Pedidos_Clientes1`
--    FOREIGN KEY (`Clientes_id`)
--    REFERENCES `comercialondb`.`clientes` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT `fk_Pedidos_Usuarios`
--    FOREIGN KEY (`Usuarios_id`)
--    REFERENCES `comercialondb`.`usuarios` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`marca`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`marca` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `nome` VARCHAR(45) NOT NULL,
--  `sigla` VARCHAR(45) NULL DEFAULT NULL,
--  PRIMARY KEY (`id`))
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`produtos`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`produtos` (
--  `id` INT(11) NOT NULL AUTO_INCREMENT,
--  `descricao` VARCHAR(128) NOT NULL,
--  `valor_unitario` DECIMAL(10,2) NOT NULL,
--  `unidade_venda` VARCHAR(20) NOT NULL,
--  `codigo_barras` VARCHAR(32) NULL DEFAULT NULL,
--  `desconto` DECIMAL(10,2) NOT NULL,
--  `descontinuado` BIT(1) NOT NULL DEFAULT b'0',
--  `marca_id` INT(11) NOT NULL,
--  `Categorias_id` INT(11) NOT NULL,
--  PRIMARY KEY (`id`),
--  INDEX `fk_Produtos_marca1_idx` (`marca_id` ASC) ,
--  INDEX `fk_Produtos_Categorias1_idx` (`Categorias_id` ASC) ,
--  CONSTRAINT `fk_Produtos_Categorias1`
--    FOREIGN KEY (`Categorias_id`)
--    REFERENCES `comercialondb`.`categorias` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT `fk_Produtos_marca1`
--    FOREIGN KEY (`marca_id`)
--    REFERENCES `comercialondb`.`marca` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;


---- -----------------------------------------------------
---- Table `comercialondb`.`itenspedido`
---- -----------------------------------------------------
--CREATE TABLE IF NOT EXISTS `comercialondb`.`itenspedido` (
--  `Pedidos_id` INT(11) NOT NULL,
--  `Produtos_id` INT(11) NOT NULL,
--  `quantidade` DECIMAL(10,2) NOT NULL,
--  `valor_produto` DECIMAL(10,2) NOT NULL,
--  `desconto` DECIMAL(10,2) NOT NULL,
--  INDEX `fk_ItensPedido_Pedidos1_idx` (`Pedidos_id` ASC) ,
--  INDEX `fk_ItensPedido_Produtos1_idx` (`Produtos_id` ASC) ,
--  CONSTRAINT `fk_ItensPedido_Pedidos1`
--    FOREIGN KEY (`Pedidos_id`)
--    REFERENCES `comercialondb`.`pedidos` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT `fk_ItensPedido_Produtos1`
--    FOREIGN KEY (`Produtos_id`)
--    REFERENCES `comercialondb`.`produtos` (`id`)
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)
--ENGINE = InnoDB
--DEFAULT CHARACTER SET = utf8;

--USE `comercialondb` ;

---- -----------------------------------------------------
---- procedure alterar_categorias
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `alterar_categorias`(
--in _id int,
--in _nome varchar(45),
--in _sigla varchar(45)
--)
--BEGIN
--	update clientes set nome = _nome, sigla = _sigla
--    where id = _id;
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure alterar_clientes
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `alterar_clientes`(
--in _id int,
--in _nome varchar(45),
--in _email varchar(45),
--in _telefone varchar(45) 
--)
--BEGIN
--	update clientes set nome = _nome, email = _email,
--    telefone = _telefone where id = _id;
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure alterar_marca
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `alterar_marca`(
--in _id int,
--in _nome varchar(45),
--in _sigla varchar(45)
--)
--BEGIN
--	update clientes set nome = _nome, sigla = _sigla
--    where id = _id;
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure alterar_usuarios
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `alterar_usuarios`(
--in _id int,
--in _nome varchar(45),
--in _email varchar(45),
--in _nivel varchar(45) 
--)
--BEGIN
--	update clientes set nome = _nome, email = _email,
--    nivel = _nivel where id = _id;
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure inserir_categorias
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_categorias`(
--out _id INT,
--in _nome varchar(45),
--in _sigla varchar(45)
--)
--BEGIN
--	insert clientes values(0, _nome, _sigla);
--    set _id = last_insert_id();
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure inserir_clientes
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_clientes`(
--out _id INT,
--in _nome varchar(45),
--in _cpf varchar(11),
--in _email varchar (45),
--in _telefone varchar (14)
--)
--BEGIN
--	insert clientes values(0, _nome, _cpf, _email, _telefone, 1);
--    set _id = last_insert_id();
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure inserir_enderecos
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_enderecos`(
--in Cliente_id int,
--in _cep varchar(8),
--in _logradouro varchar(45),
--in _numero varchar(45),
--in _complemento varchar(45),
--in _bairro varchar(45),
--in _cidade varchar(45),
--in _uf char(2),
--in _tipo varchar(45)
--)
--BEGIN
--	insert enderecos values(0,_cep, _logradouro, _numero, _complemento,
--    _bairro, _cidade, _uf, _tipo);
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure inserir_marca
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_marca`(
--out _id INT,
--in _nome varchar(45),
--in _sigla varchar(45)
--)
--BEGIN
--	insert clientes values(0, _nome, _sigla);
--    set _id = last_insert_id();
--END$$

--DELIMITER ;

---- -----------------------------------------------------
---- procedure inserir_usuarios
---- -----------------------------------------------------

--DELIMITER $$
--USE `comercialondb`$$
--CREATE DEFINER=`root`@`localhost` PROCEDURE `inserir_usuarios`(
--out _id INT,
--in _nome varchar(45),
--in _email varchar(45),
--in _senha char (32),
--in _nivel varchar (45),
--in _cpf char(11)
--)
--BEGIN
--	insert clientes values(0, _nome, _email, _senha, _nivel, 1,_cpf);
--    set _id = last_insert_id();
--END$$

--DELIMITER ;

--SET SQL_MODE=@OLD_SQL_MODE;
--SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
--SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
