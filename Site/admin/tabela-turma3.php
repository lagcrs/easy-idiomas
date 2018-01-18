  <?php

  session_start();

  $host = "localhost";
  $db = "easy_idiomas";
  $user = "root";
  $pass = "";

  $con = mysqli_connect($host, $user, $pass) or trigger_error(mysqli_error(), E_USER_ERROR);

  mysqli_select_db($con, $db);
  $botaosalva = $_POST['btnsalvar3'];

$resultado = mysqli_query($con, "SELECT * FROM turma WHERE nivel='Avancado'");

while ($exibir = mysqli_fetch_array($resultado)) {
$idnome = $exibir['nome_aluno'];

    if (isset($_POST['Nota3'])) {
      $notadig = $_POST['Nota3'];
      if($botaosalva){

       $query = "UPDATE turma SET nota='$notadig' WHERE nome_aluno='$idnome'";  
       $result = mysqli_query($con, $query); 
     }
   }
   }

   if ($result) {
    echo "<script>
    alert('Nota lançada com sucesso!');
    </script>";
  }else{
    echo "<script>
    alert('Erro ao enviar nota! Tente novamente.');
    </script>";  }


?>