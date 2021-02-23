<HTML lang="us">
<BODY>
<?php
    include "EG7.php";
    use Ss03\{Boston, NewYork};
    use function Ss03\{foo1, foo2};
    $d = new Boston();
    $d -> say();
    $n = new NewYork();
    $n -> say();
    foo1();
    foo2();
?>
</BODY>
</HTML>

