<?php
$flag=false;
$flag2=false;
$arr=[];
$arr2=[];
$arr3=[];
for($i=0;$i<10;$i++){
    $arr[$i]=random_int(0,100);
    $arr2[$i]=random_int(0,100);
}
$x=0;
for($i=0;$i<10;$i++){
    for($j=0;$j<10;$j++){
        if($arr[$i]==$arr2[$j]){
            $flag=true;
        }
        if($arr2[$i]==$arr[$j]){
            $flag2=true;
        }
    }
    if(!$flag){
        $arr3[$x]=$arr[$i];
        $x++;
    }
    if(!$flag2){
        $arr3[$x]=$arr2[$i];
        $x++;
    }
    $flag=false;
    $flag2=false;
}
for($i=0;$i<10;$i++){
    echo $arr[$i]." ";
}
echo " <br>";
for($i=0;$i<10;$i++){
    echo $arr2[$i]." ";
}
echo " <br>";
for($i=0;$i<sizeof($arr3);$i++){
    echo $arr3[$i]." <br>";
}
?>