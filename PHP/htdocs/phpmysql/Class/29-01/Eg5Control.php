<?php

require 'Eg5.php';
$student = new Student("00123AnDink", "An");
echo '<i>Thong tin sinh vien:</i> <br>';
echo "<b>ID:</b> " . $student -> getId() . "<br><b>Ten:</b> " . $student -> getName() . "<br>";