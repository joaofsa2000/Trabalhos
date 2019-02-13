<?php
function capicua(int $num) : bool{
$pri=1;$c=0;
$a=0;
while($c<strlen((string)$num)){    
    $a=$a.(($num/$pri)%10);
    $pri=$pri*10;
    $c++;
}
return $a==$num;
}
if(capicua(252)){
    echo "É capicua";
}
else{
echo "Não é capicua ";
}
?>
