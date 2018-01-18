<?php
session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
	<a href="login.php"></a>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<link rel="SHORTCUT ICON" href="favicon.ico">
	<title>Login - Easy Idiomas</title>

	<!-- Bootstrap core CSS -->
	<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

	<!-- Custom fonts for this template -->
	<link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
	<link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>

	<!-- Plugin CSS -->
	<link href="vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

	<!-- Custom styles for this template -->
	<link href="css/signin.css" rel="stylesheet">
	
</head>
<body>
	<nav class="navbar navbar-expand-lg navbar-light fixed-top">

		<div class="container">
			<div class="row">

				<a class="navfont" href="index.html">
					<i class=" icon fa fa-home"></i>
				Easy Idiomas</a>
			</div>
		</div>
	</nav>

<div class="row">
	<div class="container col-sm-6">

		<form class="form-signin center-block" method="POST" action="valida_login.php">
			<h2 class="form-signin-heading">
				Professor
				<i class="fa fa-sign-in"></i>
			</h2>
			<label for="inputEmail" class="sr-only">Email</label>
			<input type="email" name="usuario" id="inputEmail" class="form-control" placeholder="Email" required autofocus>
			<label for="inputPassword" class="sr-only">Senha</label>
			<input type="password" id="inputPassword" name="senha" class="form-control" placeholder="Senha" required>
			<?php
			if (isset($_SESSION['msg'])) {
				echo $_SESSION['msg'];
				unset($_SESSION['msg']);
			}
			?>

			<div class="checkbox">
				<label id="lembra">
					<input type="checkbox" value="lembra-me">Lembra-me
				</label>
			</div>
			<button class="btn btn-lg btn-primary btn-block center-block" type="submit" name="btnlogin" value="Acessar">Confirmar</button>
		</form>

	</div>

	<div class="container col-sm-6">

		<form class="form-signin" method="POST" action="valida_aluno.php">
			<h2 class="form-signin-heading">
				Aluno
				<i class="fa fa-sign-in"></i>
			</h2>
			<label for="inputEmail" class="sr-only">Email</label>
			<input type="email" name="usuario" id="inputEmail" class="form-control" placeholder="Email" required autofocus>
			<label for="inputPassword" class="sr-only">Senha</label>
			<input type="password" id="inputPassword" name="senha" class="form-control" placeholder="Senha" required>
			<?php
			if (isset($_SESSION['msga'])) {
				echo $_SESSION['msga'];
				unset($_SESSION['msga']);
			}
			?>

			<div class="checkbox">
				<label id="lembra">
					<input type="checkbox" value="lembra-me">Lembra-me
				</label>
			</div>
			<button class="btn btn-lg btn-primary btn-block" type="submit" name="btnlogin" value="Acessar">Confirmar</button>
		</form>

	</div>
</div>

	<footer>
		<div class="footer footer-expand-lg fixed-bottom" id="footer1">
			<div class="container">
				<i class="fa fa-copyright" style="color: white"></i>
				<a id="footer2">Easy Idiomas. Todos os direitos reservados.</a>
			</div>
		</div>
	</footer>

	<script src="../../assets/js/ie10-viewport-bug-workaround.js"></script>


</body>
</html>