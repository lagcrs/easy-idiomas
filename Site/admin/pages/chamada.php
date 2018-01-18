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
  <link href="admin/css/chamada.min.css" rel="stylesheet">

  <script type="text/javascript" src="js/botoes.js">

  </script>
</head>
<body id="page">

  <div class="container-fluid">
    <div class="row content">
      <div class="col-sm-3 sidenav text-center">
        <img src="img/boss.jpg" class="aluno rounded-circle"> 
        <br>
        <h4>Área do Professor!</h4>
        <br>

        <div class="container-fluid"> 
          <button type="button" class="btn btn-info btn-md">Home </button><br>
          <a href="pages/chamada.php" class="btn">Chamada</a>
          <a href="tables.html" class="btn">Notas</a>
        </div>
      </div>

      <br>
      <br>
      <h4>Bem vindo, </h4>
      <hr>
      <br>
      <div class="box-toggle">
        <div class="col-sm-9" id="home">

          <h2 class="text-center">Dados Pessoais</h2>
          <hr class="primary">
          <div class="container">
            <br>
            <div class="container" id="ctn-tabela">
              <table class="table table-bordered text-center" id="tabela-dados">
                <thead>
                  <tr class="bg-primary">
                    <th class="text-center">Nome:</th>
                    <th class="text-center">Admissão:</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <td>Jim Hopper da Silva</td>
                    <td>19/11/2013</td>
                  </tr>
                  <tr class="bg-primary">
                    <th class="text-center">Turmas:</th>
                    <th class="text-center">Horário:</th>
                  </tr>
                  <tr>
                    <td>Inglês III</td>
                    <td>Segunda-Feira - 19h00</td>
                  </tr>

                  <tr>
                    <td>Inglês IV</td>
                    <td>Sábado - 10h00</td>
                  </tr>
                </table>

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
