-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 09-Dez-2017 às 13:26
-- Versão do servidor: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `easy`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `aluno`
--

CREATE TABLE `aluno` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `senha` varchar(6) NOT NULL,
  `mensalidade` int(10) NOT NULL,
  `vencimento` char(10) NOT NULL,
  `nivel` varchar(20) NOT NULL,
  `nascimento` char(10) NOT NULL,
  `sexo` varchar(1) NOT NULL,
  `rg` int(9) NOT NULL,
  `cpf` int(11) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `numero` int(5) NOT NULL,
  `cep` varchar(12) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `email` varchar(50) NOT NULL,
  `notas` int(2) NOT NULL,
  `fotoaluno` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Armazena as informações dos alunos';

--
-- Extraindo dados da tabela `aluno`
--

INSERT INTO `aluno` (`id`, `nome`, `senha`, `mensalidade`, `vencimento`, `nivel`, `nascimento`, `sexo`, `rg`, `cpf`, `telefone`, `celular`, `endereco`, `numero`, `cep`, `cidade`, `bairro`, `uf`, `email`, `notas`, `fotoaluno`) VALUES
(14, 'jose', '4', 150, '05', 'Básico', '04/11/1990', 'M', 123456789, 2147483647, '(012) 3144-9989', '(012) 3144-6645', 'Rua Nárnia', 123, '12700-000', 'Fantasia', 'Imaginação', 'SP', 'jose_joselito@hotmail.com', 0, 'C:\\Users\\Samsung\\Desktop\\Easy\\Icones\\alunos.png');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `senha` varchar(6) NOT NULL,
  `salario` int(10) NOT NULL,
  `pagamento` char(10) NOT NULL,
  `funcao` varchar(30) NOT NULL,
  `nacimento` char(10) NOT NULL,
  `sexo` varchar(1) NOT NULL,
  `rg` int(9) NOT NULL,
  `cpf` int(11) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `numero` int(10) NOT NULL,
  `cep` varchar(12) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `uf` varchar(2) NOT NULL,
  `email` varchar(50) NOT NULL,
  `fotofunc` varchar(500) NOT NULL,
  `banco` varchar(10) NOT NULL,
  `tipoconta` varchar(8) NOT NULL,
  `agencia` varchar(20) NOT NULL,
  `conta` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='armazena as informações dos funcionários';

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id`, `nome`, `senha`, `salario`, `pagamento`, `funcao`, `nacimento`, `sexo`, `rg`, `cpf`, `telefone`, `celular`, `endereco`, `numero`, `cep`, `cidade`, `bairro`, `uf`, `email`, `fotofunc`, `banco`, `tipoconta`, `agencia`, `conta`) VALUES
(11, 'Thayane', '2', 1000000, '10', 'Professor', '12/12/2000', 'F', 2, 2, '(012) 3144-2222', '(012) 2222-2222', 'rua dois', 2, '22222-222', 'Dois Rios', 'Doble', 'SP', 'thayane_lais@gmail.com', 'C:\\Users\\Samsung\\Desktop\\Easy\\Icones\\ICONE_FUNC.png', '', '', '', ''),
(12, 'Damaris', '1', 1000, '04/05/1991', 'Administrativo', '01/01/2001', 'F', 1, 1, '(012) 1111-1111', '(012) 1111-1111', 'Rua um', 1, '11111-111', 'Cruzeiro', 'Longe Demais', '', 'damariscristinaribeiroprado@gmail.com', 'C:\\Users\\Samsung\\Desktop\\Easy\\Icones\\ICONE_FUNC.png', '111111', 'Poupança', '111111', '111111');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagar`
--

CREATE TABLE `pagar` (
  `id` int(11) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `valor` int(10) NOT NULL,
  `vencimento` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Armazena as contas a pagar';

--
-- Extraindo dados da tabela `pagar`
--

INSERT INTO `pagar` (`id`, `tipo`, `valor`, `vencimento`) VALUES
(17, 'comida', 1000, '12/12/1222'),
(18, 'salario', 2000, '04/05/2017'),
(19, 'celular', 5000, '  /  /'),
(20, 'carteira', 1500, '  /  /');

-- --------------------------------------------------------

--
-- Estrutura da tabela `receber`
--

CREATE TABLE `receber` (
  `id` int(11) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `valor` int(10) NOT NULL,
  `vencimento` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Armazena as contas a receber';

--
-- Extraindo dados da tabela `receber`
--

INSERT INTO `receber` (`id`, `tipo`, `valor`, `vencimento`) VALUES
(1, 'Mensalidade 1', 50, '20/01/2017'),
(3, 'Mensalidade 2', 100, '30/02/2017'),
(4, 'Mensalidade 3', 150, '12/03/2017'),
(5, 'Mensalidade 4', 200, '29/04/2017'),
(6, 'Mensalidade 5', 250, '11/05/2017'),
(7, 'Mensalidade 6', 300, '29/06/2017'),
(8, 'Mensalidade 7', 350, '22/07/2017');

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma`
--

CREATE TABLE `turma` (
  `id` int(11) NOT NULL,
  `nome` varchar(20) NOT NULL,
  `inicio` time(4) NOT NULL,
  `fim` time(4) NOT NULL,
  `professor` varchar(20) NOT NULL,
  `nivel` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Armazena as turmas criadas';

--
-- Extraindo dados da tabela `turma`
--

INSERT INTO `turma` (`id`, `nome`, `inicio`, `fim`, `professor`, `nivel`) VALUES
(13, '1', '11:11:00.0000', '22:22:00.0000', 'carlos', 'Avançado'),
(17, 'poi', '11:11:00.0000', '22:22:00.0000', 'carlos', 'Básico'),
(18, '16', '11:11:00.0000', '22:22:00.0000', 'carlos', 'Básico'),
(19, '1', '11:11:00.0000', '22:22:00.0000', 'carlos', 'Avançado');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pagar`
--
ALTER TABLE `pagar`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `receber`
--
ALTER TABLE `receber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `turma`
--
ALTER TABLE `turma`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aluno`
--
ALTER TABLE `aluno`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `pagar`
--
ALTER TABLE `pagar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `receber`
--
ALTER TABLE `receber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `turma`
--
ALTER TABLE `turma`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
