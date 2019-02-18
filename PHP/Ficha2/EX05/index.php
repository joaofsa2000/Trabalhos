<?php
function diagonal(array $mat) : array{
    $arr=[];
    for($i=0;$i<5;$i++){
        $arr[$i]=$mat[$i][$i];
    }
    return $arr;

}
$mat[]=[];
$mat2[]=[];
$mat3[]=[];
for($i=0;$i<5;$i++){
    for($j=0;$j<5;$j++){
    $mat[$i][$j]=random_int(10,49);
    $mat2[$i][$j]=random_int(10,49);
    $mat3[$i][$j]=$mat[$i][$j]+$mat2[$i][$j];
    echo "   ".$mat3[$i][$j];
}
echo " <br>";
}
echo " <br>";
$arr=diagonal($mat3);
for($i=0;$i<5;$i++){
    echo " ".$arr[$i];
}

?>