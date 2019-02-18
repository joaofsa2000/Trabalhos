<?php
$str="Ame o poema";
    if(strcasecmp(str_replace(' ', '', $str),strrev(str_replace(' ', '', $str)))==0){
        echo "É Palindromo";
    }
    else{
        echo "Não é Palindromo";
    }
?>