<?php

// Inclui o arquivo class.phpmailer.php localizado na pasta phpmailer
require ("phpmailer/class.phpmailer.php");

// Inicia a classe PHPMailer
$mail = new PHPMailer();

// Define os dados do servidor e tipo de conexão

$mail->IsSMTP(); // Define que a mensagem será SMTP
$mail->Host = "smtp.gmail.com"; // Endereço do servidor SMTP
$mail->SMTPAuth = true; //  autenticação SMTP
//$mail->Username = 'thayane.lais17@gmail.com'; // Usuário do servidor SMTP
//$mail->Password = '123letras'; // Senha do servidor SMTP

// Define o remetente

$mail->From = $_POST['email'];
$mail->FromName = $_POST['nome'];

// Define os destinatário(s)

$mail->AddAddress('thayane.lais17@gmail.com', 'Thayane');
//$mail->AddAddress('ciclano@site.net');
//$mail->AddCC('ciclano@site.net', 'Ciclano'); // Copia
//$mail->AddBCC('fulano@dominio.com.br', 'Fulano da Silva'); // Cópia Oculta

// Define os dados técnicos da Mensagem

$mail->IsHTML(true); // Define que o e-mail será enviado como HTML
//$mail->CharSet = 'iso-8859-1'; // Charset da mensagem (opcional)

// Define a mensagem (Texto e Assunto)

$mail->Subject  = "Mensagem Teste"; // Assunto da mensagem
$mail->AltBody = $_POST['comment'];


// Envia o e-mail
$enviado = $mail->Send();

// Limpa os destinatários e os anexos
$mail->ClearAllRecipients();

// Exibe uma mensagem de resultado
if ($enviado) {
  echo "E-mail enviado com sucesso!";
} else {
  echo "Não foi possível enviar o e-mail.";
  echo "<b>Informações do erro:</b> " . $mail->ErrorInfo;
}
?>

</div>
</body>
</html>
