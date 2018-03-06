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
  <link href="css/chamada.min.css" rel="stylesheet">

  <script type="text/javascript" src="js/botoes.js">
  </script>
  <script type="text/javascript">
    $(document).ready(function(){
      $("#presenca1").click(function(){
       $("#lista2").hide();
       $("#lista3").hide();
       $("#lista1").slideToggle("slow");
     });
    });

    $(document).ready(function(){
      $("#presenca2").click(function(){
        $("#lista1").hide();
        $("#lista3").hide();
        $("#lista2").slideToggle("slow");
      });
    });

    $(document).ready(function(){
      $("#presenca3").click(function(){
       $("#lista1").hide();
       $("#lista2").hide();
       $("#lista3").slideToggle("slow");
     });
    });
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
    </div>


   
    <br>

    <div class="container col-sm-9">
      <h2 class="text-center">Lista de Alunos</h2>
      <hr class="primary">


      <div class="container col-sm-3" id="presenca1">

        <div>Básico</div>


      </div>

      <div class="container col-sm-3" id="presenca2">

        <div id="flip2">Intermediário</div>
      </div>

      <div class="container col-sm-3" id="presenca3">
        <div id="flip3">Avançado</div>
      </div>


      <br>
      <br>
      <br>
      <div class="center-block" id="lista1">
        <table class="table table-bordered">
          <thead class="thead-inverse">
            <tr>
              <th><h4 class="text-center">Nome:</h4></th>
              <th><h4 class="text-center">Email:</h4></th>

            </tr>
          </thead>

          <div>
            <tbody>

              <tr>

               <tr>

                <?php
                $res = mysqli_query($con,"SELECT * FROM turma WHERE nivel='Basico'");

                while ($exibe = mysqli_fetch_array($res)) { 
                  echo "<tr>
                  <td class='text-center'>".$exibe['nome_aluno']."</td>
                  <td class='text-center'>".$exibe['email']."</td>
                  </tr>";
                }

                ?>

              </tr>
            </tr>
          </tbody>
        </div>
      </table>
    </div>

    <div class="center-block" id="lista2">
      <table class="table table-bordered">
        <thead class="thead-inverse">
          <tr>
            <th><h4 class="text-center">Nome:</h4></th>
            <th><h4 class="text-center">Email:</h4></th>
          </tr>
        </thead>
        <tbody>
          <tr>
           <tr>

             <?php
             $res = mysqli_query($con,"SELECT * FROM turma WHERE nivel='Intermediario'");

             while ($exibe = mysqli_fetch_array($res)) { 
              echo "<tr>
              <td class='text-center'>".$exibe['nome_aluno']."</td>
              <td class='text-center'>".$exibe['email']."</td>
              </tr>";
            }

            ?>
          </tr>
        </th>
      </tbody>
    </table>
  
  </div>

  <div class="center-block" id="lista3">
    <table class="table table-bordered">
      <thead class="thead-inverse">
        <tr>
          <th><h4 class="text-center">Nome:</h4></th>
          <th><h4 class="text-center">Email:</h4></th>

        </tr>
      </thead>
      <tbody>
       <tr>
        <tr>

          <?php
          $res = mysqli_query($con,"SELECT * FROM turma WHERE nivel='Avancado'");

          while ($exibe = mysqli_fetch_array($res)) { 
            echo "<tr>
            <td class='text-center'>".$exibe['nome_aluno']."</td>
            <td class='text-center'>".$exibe['email']."</td>
            </tr>";
          }

          ?>
        </tr>
      </tbody>
    </table>
  </td>
 
</div>



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
