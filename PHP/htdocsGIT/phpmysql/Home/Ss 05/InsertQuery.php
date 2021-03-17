<?php
    require_once 'Login.php';
    $conn = new mysqli($hn, $un, $pw, $db);
    if ($conn->connect_error) die ($conn->connect_error);

    $query = "insert into school.classics values ('Im Vain', 'We Love Dogs', 'Fiction', 1899, 921390221)";
    $result = $conn->query($query);
    if (!$result) die ("Database access failed: " . $conn->error);

    echo "The Inserted ID was: " . $conn->insert_id;
