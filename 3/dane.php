<?php

require('simple_html_dom.php');

$html = file_get_html("http://www.suwalki.info/");

foreach($html->find('img') as $element) 
       echo $element->src . '<br>';

foreach($html->find('div[id=kino]') as $element) 
       echo $element;
	   
foreach($html->find('div[id=sonda]') as $element) 
       echo $element;
	   
	   //echo $html;


?>

