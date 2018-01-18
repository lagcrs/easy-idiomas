<?php
session_start();

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
  <title>Área Administrativa</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

  <!-- Custom styles for this template -->
  <link href="css/admin.min.css" rel="stylesheet">

  <script type="text/javascript" src="js/botoes.js">

  </script>
</head>
<body id="page">


  <div class="container-fluid">
    <div class="row content">
      <div class="col-sm-3 sidenav text-center">
        <img src="img/boss.jpg" class="aluno rounded-circle"> 
        <br>
        <h3><strong>Área do Professor</strong></h3>
        <br>

        <div class="container-fluid"> 
          <a href="admin.php" class="btn">Home</a>
          <a href="turmas.php" class="btn">Turmas</a>
          <a href="admin-notas.php" class="btn">Notas</a>
        </div>
      </div>

      <br>
      <div class="col-sm-9">

        <div class= "col-sm-4">
          <h5 class="text-left"><strong>Easy Sistema</strong></h5>
        </div>
        <div class="col-sm-4">
          <h4 class="text-center"><small><strong>BEM-VINDO (A): 
            Professor

          </strong></small></h4>
        </div>
        <div class="col-sm-4 text-right">
          <button type="button" class="btn-danger btn-sm" id="botao"><a 
            style="color: white"  href="logout.php">SAIR</a></button>
          </div>
          <hr>
          <br>
          <div class="box-toggle">
            <div class="col-sm-12">
              <h2 class="text-center">Horários</h2>
              <hr class="primary">
            </div>

            <div class="col-sm-9" id="home">
              <br>
              <table class="table table-bordered">
                <thead class="thead-inverse">
                  <tr>
                    <th><h4 class="text-center">Turma:</h4></th>
                    <th><h4 class="text-center">Horário:</h4></th>

                  </tr>
                </thead>

                <div>
                  <tbody>
                    <tr>
                     <tr>

                      <?php
                      $res = mysqli_query($con,"SELECT * FROM turma");

                      while ($exibe = mysqli_fetch_array($res)) { 
                        echo "<tr>

                        <th class='text-center'>" .$exibe['nivel']."</th>
                        <td class='text-center'>".$exibe['horario_aula']."</td>";

                      }
                      ?>

                    </tr>
                  </tr>

                </tbody>
              </div>

            </table>

          </div>
        </div>
      </div>
    </div>




    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/popper/popper.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    <script src="vendor/scrollreveal/scrollreveal.min.js"></script>
    <script src="vendor/magnific-popup/jquery.magnific-popup.min.js"></script>

    <!-- Custom scripts for this template -->
    <script src="js/creative.min.js"></script>


  </body>
  </html>
