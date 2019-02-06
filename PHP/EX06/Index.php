<?php
$c=0;
$i=0;
echo "Os Primeiros 100 Números Primos: <br>";
   while($c<101){
    
        $a=0;
        for($x=1;$x<$i+1;$x++){
            if($i%$x==0){
                $a++;
            }
        }
        if($a==2){
            echo $i."<br>";
            $c++;
        }
        $i++;
    
   }
?>