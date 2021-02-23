<HTML lang="us">
<BODY>
<?php
    $x = "Cat";
    $y = "Dog";
    echo $x. '<=>' .$y, '// Returns ', $x <=> $y;
    // -1 (Cat < Dog)
    echo '<br>';
    $x = "PHP";
    $y = "PHP";
    echo $x. '<=>' .$y, '// Returns ', $x <=> $y;
    // 0
    echo '<br>';
    $x = "Compute";
    $y = "Apple";
    echo $x. '<=>' .$y, '// Returns ', $x <=> $y;
    // 1 (Compute > Apple).
?>
</BODY>
</HTML>

