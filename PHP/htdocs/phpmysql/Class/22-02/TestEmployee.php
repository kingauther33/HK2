<?php
require 'Employees.php';
$employee1 = new Employee();
echo 'Default <b>Name</b> is: ' . $employee1->get_name() . '<br>';
echo 'Default <b>Number</b> is: ' . $employee1->get_man_no() . '<br>';
echo 'Default <b>Position</b> is: ' . $employee1->get_position() . '<br><br>';
$employee1->set_name("Dat");
$employee1->set_man_no(11);
$employee1->set_position(13);
echo 'Name after set: ' . $employee1->get_name() . '<br>';
echo 'Number after set: ' . $employee1->get_man_no() . '<br>';
echo 'Position after set: ' . $employee1->get_position() . '<br>';



