

<?php
$remetente = 'From: Orçamentos';
$destino = 'contato@newflaps.com.br';

$services = utf8_decode($_POST['services']);
$nome = utf8_decode($_POST['nome']);
$email = utf8_decode($_POST['email']);
$tem = utf8_decode($_POST['tem']);
$naotem = utf8_decode($_POST['naotem']);
$prazo = utf8_decode($_POST['prazo']);

$alerta  = header('Location: index.html');;

$corpo  = "
Servico: ".$services."
Nome:    ".$nome."
E-mail:   ".$email."
Tem Site:  ".$tem."
Nao tem Site:  ".$naotem."
Prazo:  ".$prazo."";

mail($destino, $services, $corpo, $remetente);

echo "$alerta";


?>
