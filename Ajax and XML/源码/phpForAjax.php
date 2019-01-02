<?php

echo '<response>';

$food =$_GET['food'];
$foodArray=array('apple','banana','chair','donkey');

if(in_array($food,$foodArray))	echo 'we do have'.$food;
elseif ($food=='')	echo 'enter a food';
else echo "we don\'t have".$food;


echo '</response>';

?>