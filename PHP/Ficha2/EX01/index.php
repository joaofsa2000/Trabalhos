<?php
for($i=0;$i<20;$i++){
    $arr[$i]=random_int(-1000,1000);
}
$max=0;
//$par=0;$impar=0;
for($i=0;$i<20;$i++){
    if($arr[$i]>$max){
        $max=$arr[$i];
    }
 /*   if($arr[$i]%2==0){
        $par++;
    }
    else{
        $impar++;
}*/
}
echo "Max= ".$max/*." <br>Quantidade impares: ".$impar." <br>Quantidade pares: ".$par*/;
?>
