# SQL Manager Lite for MySQL 5.5.3.46192
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : cinema2018


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

SET FOREIGN_KEY_CHECKS=0;

CREATE DATABASE `cinema2018`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_swedish_ci';

USE `cinema2018`;

#
# Structure for the `fornecedor` table :
#

CREATE TABLE `fornecedor` (
  `codigoFornecedor` INTEGER(11) NOT NULL,
  `cnpj` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  `nomeFornecedor` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  `endereco` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  PRIMARY KEY (`codigoFornecedor`) USING BTREE
) ENGINE=InnoDB
CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
COMMENT='InnoDB free: 3072 kB';

#
# Structure for the `filme` table :
#

CREATE TABLE `filme` (
  `codigoFilme` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `nomeFilme` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  `duracaoFilme` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  `codigoFornecedor` INTEGER(11) DEFAULT NULL,
  PRIMARY KEY (`codigoFilme`) USING BTREE,
  KEY `codigoFornecedor` (`codigoFornecedor`) USING BTREE,
  CONSTRAINT `filme_fk1` FOREIGN KEY (`codigoFornecedor`) REFERENCES `fornecedor` (`codigoFornecedor`)
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
COMMENT='InnoDB free: 3072 kB; (`codigoFornecedor`) REFER `cinema2018/fornecedor`(`codigo';

#
# Structure for the `secao` table :
#

CREATE TABLE `secao` (
  `codigoSecao` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `sala` INTEGER(11) DEFAULT NULL,
  `horario` VARCHAR(20) COLLATE latin1_swedish_ci DEFAULT NULL,
  `qtdCadeiras` INTEGER(11) DEFAULT NULL,
  `valor` FLOAT(9,3) DEFAULT NULL,
  `codigoFilme` INTEGER(11) DEFAULT NULL,
  PRIMARY KEY (`codigoSecao`) USING BTREE,
  KEY `codigoFilme` (`codigoFilme`) USING BTREE,
  CONSTRAINT `secao_fk1` FOREIGN KEY (`codigoFilme`) REFERENCES `filme` (`codigoFilme`)
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
COMMENT='InnoDB free: 3072 kB; (`codigoFilme`) REFER `cinema2018/filme`(`codigoFilme`)';



/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;