

<?php
$remetente = 'From: Contatos do Site';
$destino = 'contato@newflaps.com.br';

$assunto = utf8_decode($_POST['assunto']);
$nome = utf8_decode($_POST['nome']);
$email = utf8_decode($_POST['email']);
$telefone = utf8_decode($_POST['telefone']);
$empresa = utf8_decode($_POST['empresa']);
$msg = utf8_decode($_POST['msg']);

$alerta  = header('Location: index.html');;

$corpo  = "
Assunto: ".$assunto."
Nome:    ".$nome."
E-mail:   ".$email."
Telefone:   ".$telefone."
Empresa:  ".$empresa."
=================================================================
Mensagem:
".$msg."";

mail($destino, $assunto, $corpo, $remetente);

echo "$alerta";


?>
