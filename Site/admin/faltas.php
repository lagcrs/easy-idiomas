<?php 
$host = "localhost";
$db = "easy_idiomas";
$user = "root";
$pass = "";

$con = mysqli_connect($host, $user, $pass) or trigger_error(mysqli_error(), E_USER_ERROR);

mysqli_select_db($con, $db);


?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
	<title>Área de Aluno</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

	<!-- Custom styles for this template -->
	<link href="css/aluno.min.css" rel="stylesheet">


</head>
<body>

	<div class="container-fluid">
		<div class="row content">
			<div class="col-sm-3 sidenav text-center">
				<a href="aluno.php">
					<img src="img/reading.jpg" class="aluno" height="136" width="144">
				</a>
				<h3 class="text-center" style="color: white"><strong>Área Aluno</strong></h3>
				<ul class="nav nav-pills nav-stacked">
					<li class="active"><a href="notas.php">Notas</a></li>
					<li class="active"><a href="faltas.php">Alunos</a></li>
					<li class="active"><a href="turma.php">Turmas</a></li>
				</ul><br>

			</div>


			<div class="col-sm-9">
				<div class= "col-sm-4">
					<h5 class="text-left"><strong>Easy Sistema</strong></h5>
				</div>
				<div class="col-sm-4">
					<h4 class="text-center"><small><strong>BEM-VINDO (A): 
						Aluno
					</strong></small></h4>
				</div>

				<div class="col-sm-4 text-right">
					<button type="button" class="btn btn-danger btn-sm" id="botao"><a 
					style="color: white" 	href="logout.php">SAIR</a></button>
				</div>

				<hr>

				<table class="table text-center" id="border">
					<thead>
						<tr>
							<th class="text-center">Nome do Aluno</th>
							<th class="text-center">E-mail</th>
						</tr>
					</thead>

					<tbody>
						<?php

						$res = mysqli_query($con,"select * from turma");

						while ($exibe = mysqli_fetch_array($res)) {

							echo "<tr>
							<td>" .$exibe['nome_aluno']. "</td>
							<td>" .$exibe['email']. "</td>
							</tr>"; 
							;
							;        
						} 
						?>
					</tbody>
				</table>

				<hr>
			</div>
		</div>

	</body>
	</html>
