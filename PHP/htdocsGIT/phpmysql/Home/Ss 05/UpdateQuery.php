<?php
    require_once 'Login.php';
    $conn = new mysqli($hn, $un, $pw, $db);
    if ($conn->connect_error) die ($conn->connect_error);

    $query = "update school.classics set title='I love cats' where author='Im Vain'";
    $result = $conn->query($query);
    if (!$result) die ("Database access failed: " . $conn->error);
