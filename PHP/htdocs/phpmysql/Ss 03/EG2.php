<HTML lang="us">
<BODY>
<?php
    $x = 1;
    $y = 2;
    echo $x. '<=>' .$y,' Returns ', $x <=> $y;
    // -1
    echo '<br>';
    $x = 10;
    $y = 10;
    echo $x.'<=>' .$y,' Returns ', $x <=> $y;
    echo '<br>';
    // 0
    $x = 10;
    $y = 5;
    echo $x.'<=>' .$y,' Returns ', $x <=> $y;
    // 1
?>
</BODY>
</HTML>

