<?php
class Employee {
    private $man_no;
    private $name;
    protected $position;
    public function __construct() {
        $this->man_no = "Nguyen Van A";
        $this->name = 00;
        $this->position = 00;
    }

    public function set_man_no($man_no) {
        $this->man_no = $man_no;
    }

    public function get_man_no() {
        return $this->man_no;
    }

    public function set_name($name) {
        $this->name = $name;
    }

    public function get_name() {
        return $this->name;
    }

    public function set_position($position) {
        $this->position = $position;
    }

    public function get_position() {
        return $this->position;
    }
}