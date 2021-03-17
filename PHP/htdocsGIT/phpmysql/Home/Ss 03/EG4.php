<HTML lang="us">
<BODY>
<?php
    $x = array();
    $y = array();
    echo 'array()' . '<=>'. 'array()'. ' Returns ', $x <=> $y;
    // 0
    echo '<br>';
    $m = array(1, 2, 3);
    $n = array(1, 2, 3);
    $p = array(1, 2, 1);
    $q = array(1, 2, 4);
    echo 'array(1, 2, 3)' . '<=>'. 'array(1, 2, 3)'. ' Returns ', $m <=> $n;
    echo '<br>';
    // 0
    echo 'array(1, 2, 3)' . '<=>'. 'array()'. ' Returns ', $m <=> $x;
    echo '<br>';
    // 1
    echo 'array(1, 2, 3)' . '<=>'. 'array(1, 2, 1)'. ' Returns ', $m <=> $q;
    echo '<br>';
    // 1
    echo 'array(1, 2, 3)' . '<=>'. 'array(1, 2, 4)'. ' Returns ', $m <=> $n;
    echo '<br>';
    // -1
?>
</BODY>
</HTML>

