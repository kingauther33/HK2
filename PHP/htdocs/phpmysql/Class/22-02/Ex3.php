<?php
    require 'Ex2.php';
    $query = "select * from classics";
    $result = $conn->query($query);
    if (!$result) die ($conn->error);
