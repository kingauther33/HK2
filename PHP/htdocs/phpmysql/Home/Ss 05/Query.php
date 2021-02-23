<?php
    require_once 'Login.php';
    $conn = new mysqli($hn, $un, $pw, $db);
    if ($conn->connect_error) die ($conn->connect_error);

    $query = "select * from expressco";
    $result = $conn->query($query);
    if (!$result) die ($conn->error);

    $rows = $result->num_rows;
    $style = 'style="border:hidden"';
    for ($j = 0; $j < $rows; ++$j) {
        $result->data_seek($j);
        $row = $result->fetch_array(MYSQLI_ASSOC);

        echo '<td>';
        echo '<figure>';
        echo '<img src="data:image/jpg;base64,'.base64_encode($row['image']). ' "height="100" width="100" />';
        echo '<figcaption>'. $row['name'] .'</figcaption>';
        echo '</figure>';
        echo '</td>';
    }
