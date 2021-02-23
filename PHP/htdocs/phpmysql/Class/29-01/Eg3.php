<?php

$mystr = "I Love You"; echo substr($mystr, 2,4);
echo strtolower( 'Benjamin');
$settings = explode(';', "host=localhost; db=sales; uid=root; pwd=demo");
print_r($settings);
echo "<br>" . $settings[0];