<?php
    $mycounter = 1;
    $mystring = "Hello";

    function getArray (): Generator
    {
        $myarray = array("One", "Two", "Three");
        for ($i = 0; $i <= 2; $i++) {
            yield "array[". $i . "]: " .$myarray[$i] . "<br>";
        }
    }
    // Print all vars
    // mycounter = 1
    echo "mycounter = ". $mycounter. "<br>";
    // mystring = Hello
    echo "mystring = " . $mystring. "<br>";
    // myarray = ...
    foreach (getArray() as $array) {
        echo $array;
    }
//    echo "array list: <br>";
//    echo "array[0]: ". $myarray[0] . "<br>";
//    echo "array[1]: ". $myarray[1] . "<br>";
//    echo "array[2]: ". $myarray[2] . "<br>";
