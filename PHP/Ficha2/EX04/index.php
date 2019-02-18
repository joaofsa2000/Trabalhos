<?php
$mat[]=[];
$mat2[]=[];
$mat3[]=[];
for($i=0;$i<4;$i++){
    for($j=0;$j<4;$j++){
    $mat[$i][$j]=random_int(10,49);
    $mat2[$i][$j]=random_int(10,49);
    $mat3[$i][$j]=$mat[$i][$j]+$mat2[$i][$j];
    echo "   ".$mat3[$i][$j];
}
echo " <br>";
}
?>