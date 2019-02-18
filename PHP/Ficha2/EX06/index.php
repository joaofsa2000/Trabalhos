<?php
function meses(int $num) : string{
    $meses[1]="Janeiro";
    $meses[2]="Fevereiro";
    $meses[3]="Março";
    $meses[4]="Abril";
    $meses[5]="Maio";
    $meses[6]="Junho";
    $meses[7]="Julho";
    $meses[8]="Agosto";
    $meses[9]="Setembro";
    $meses[10]="Outubro";
    $meses[11]="Novembro";
    $meses[12]="Dezembro";
return $meses[$num];

}
echo meses(random_int(1,12));
?>