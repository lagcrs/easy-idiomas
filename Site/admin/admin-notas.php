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
  <link href="css/admin-notas.min.css" rel="stylesheet">

  <script type="text/javascript" src="js/turma-notas.js">

  </script>
  <script> 
    $(document).ready(function(){
      $("#turmas1").click(function(){
       $("#panel2").hide();
       $("#panel3").hide();
       $("#panel1").slideToggle("slow");
     });
    });

    $(document).ready(function(){
      $("#turmas2").click(function(){
        $("#panel1").hide();
        $("#panel3").hide();
        $("#panel2").slideToggle("slow");
      });
    });

    $(document).ready(function(){
      $("#turmas3").click(function(){
       $("#panel1").hide();
       $("#panel2").hide();
       $("#panel3").slideToggle("slow");
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
          <a href="admin.php" class="btn btnh">Home</a>
          <a href="turmas.php" class="btn btnc">Turmas</a>
          <a href="admin-notas.php" class="btn btnn">Notas</a>
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



      <hr>
      <br>

      <div class="container col-sm-9">
        <h2 class="text-center">Lançamento de Notas</h2>
        <hr class="primary">


        <div class="container col-sm-3" id="turmas1">

          <div>Básico</div>


        </div>

        <div class="container col-sm-3" id="turmas2">

          <div id="flip2">Intermediário</div>
        </div>

        <div class="container col-sm-3" id="turmas3">
          <div id="flip3">Avançado</div>
        </div>


        <br>
        <br>
        <br>
        <div class="center-block" id="panel1"  method="POST" action="dados-turma.php" >
          <table class="table table-bordered">
            <thead class="thead-inverse">
              <tr>
                <th><h4 class="text-center">Nome:</h4></th>
                <th><h4 class="text-center">Turma:</h4></th>
                <th><h4 class="text-center">Nota:</h4></th>

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
                    <form method='POST' action='tabela-turma.php'>

                    <th class='text-center'>" .$exibe['nome_aluno']."</th>
                    <td class='text-center'>".$exibe['nivel']."</td>

                    <td><input type='text' class='form-control center-block' name='Nota1' maxlength='10'></td>
                    <td><input class='btn-salvar btn-md btn-info center-block'  method='POST' action='tabela-turma.php' type='submit' name='btnsalvar1' value='Salvar'></td>
                    </form>";

                  }
                  ?>

                </tr>
              </tr>

            </tbody>
          </div>

        </table>
      </div>

      <div class="center-block" id="panel2">
        <table class="table table-bordered">
          <thead class="thead-inverse">
            <tr>
              <th><h4 class="text-center">Nome:</h4></th>
              <th><h4 class="text-center">Turma:</h4></th>
              <th><h4 class="text-center">Nota:</h4></th>
            </tr>
          </thead>
          <tbody>
            <tr>
             <tr>

              <?php
              $res = mysqli_query($con,"SELECT * FROM turma WHERE nivel='Intermediario'");

              while ($exibe = mysqli_fetch_array($res)) { 
                echo "<tr>
                <form method='POST' action='tabela-turma2.php'>

                <th class='text-center'>" .$exibe['nome_aluno']."</th>

                <td class='text-center'>".$exibe['nivel']."</td>

                <td><input type='text' class='form-control center-block' name='Nota2' maxlength='10'></td>
                <td><input class='btn-salvar btn-md btn-info center-block'  method='POST' action='tabela-turma2.php' type='submit' name='btnsalvar2' value='Salvar'></td>

                </form>

                ";
              }

              ?>


            </tr>
          </tr>
        </tbody>
      </table>
    </div>

    <div class="center-block" id="panel3">
      <table class="table table-bordered">
        <thead class="thead-inverse">
          <tr>
            <th><h4 class="text-center">Nome:</h4></th>
            <th><h4 class="text-center">Turma:</h4></th>
            <th><h4 class="text-center">Nota:</h4></th>
          </tr>
        </thead>
        <tbody>
         <tr>
          <tr>


            <?php
            $res = mysqli_query($con,"SELECT * FROM turma WHERE nivel='Avancado'");

            while ($exibe = mysqli_fetch_array($res)) { 
              echo "<tr>
              <form method='POST' action='tabela-turma3.php'>

              <th class='text-center'>" .$exibe['nome_aluno']."</th>

              <td class='text-center'>".$exibe['nivel']."</td>

              <td><input type='text' class='form-control center-block' name='Nota3' maxlength='10'></td>
              <td><input class='btn-salvar btn-md btn-info center-block'  method='POST' action='tabela-turma3.php' type='submit' name='btnsalvar3' value='Salvar'></td>

              </form>

              ";
            }

            ?>

          </tr>
        </tr>
      </tbody>
    </table>
  </td>
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
