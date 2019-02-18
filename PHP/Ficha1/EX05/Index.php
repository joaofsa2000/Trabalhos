<?php
    
    echo "Números Primos entre 1 e 100: <br>";
    for($i=1;$i<101;$i++){
        $a=0;
        for($x=1;$x<$i+1;$x++){
            if($i%$x==0){
                $a++;
            }
        }
        if($a==2){
            echo $i."<br>";
        }
    }
?>