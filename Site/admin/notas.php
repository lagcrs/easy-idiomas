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

	<script>
		window.onload = function () {

			var chart = new CanvasJS.Chart("chartContainer", {
				animationEnabled: true,
				exportEnabled: true,
  theme: "light2", // "light1", "light2", "dark1", "dark2"
  title:{
  	text: ""
  },
  data: [{
    type: "bar", //change type to bar, line, area, pie, etc
    //indexLabel: "{y}", //Shows y value on all Data Points
    indexLabelFontColor: "#5A5757",
    indexLabelPlacement: "outside",
    dataPoints: [
    { x: 30, y: 30, indexLabel: "Básico" },
    { x: 60, y: 60, indexLabel: "Intermediário" },
    { x: 90, y: 90, indexLabel: "Avançado" }
    ]
}]
});
			chart.render();

		}
	</script>
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

				<br>
				<hr>
				<table class="table" id="border">
					<thead>
						<tr>
							<th>Aluno</th>
							<th>Nota</th>
						</tr>
					</thead>

					<tbody>
						<?php

						$res = mysqli_query($con,"select nome_aluno, nota from turma");

						while ($exibe = mysqli_fetch_array($res)) {
							echo  "<tr>
							<td>" .$exibe['nome_aluno']. "</td>
							<td>" .$exibe['nota']. "</td>
						
							</tr>"; 

						}
						?>
					</tbody>
				</table>
				<hr>

				<div class="magin col-sm-12" id="border">
					<h4 class="text-center"><strong>RELAÇÃO NOTAS</strong></h4>
					<div id="chartContainer" style="height: 200px; width: 100%;"></div>
					<script src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
				</div>
	</body>
	</html>
