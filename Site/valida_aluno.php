<?php
session_start();
include_once("conexao.php");

//Passa valor do botão "confirmar"
$btnlogin = filter_input (INPUT_POST,'btnlogin', FILTER_SANITIZE_STRING);

if($btnlogin) {
	$usuario = filter_input(INPUT_POST, 'usuario', FILTER_SANITIZE_STRING);
	$senha = filter_input(INPUT_POST, 'senha', FILTER_SANITIZE_STRING);
	if (!empty($usuario) AND (!empty($senha))) {
		//Gerar senha criptografada
		//echo password_hash($senha, PASSWORD_DEFAULT);
     	//PESQUISAR USUARIO NO DB
		 $result_usuario = "SELECT id, email, senha FROM login WHERE email='$usuario' LIMIT 1";
		 $resultado_usuario = mysqli_query($conecta, $result_usuario);
		if ($resultado_usuario) {
			$row_usuario = mysqli_fetch_assoc($resultado_usuario);
			 if (password_verify($senha, $row_usuario['senha'])) {

			 header("Location: admin/aluno.php");

			}else{
				$_SESSION['msga'] = "Login ou senha incorreto!";
				header("Location: login.php");
			}
		}
	}
}else{
	$_SESSION['msg'] = "Página não encontrada!";
	header("Location: login.php");
}
?>