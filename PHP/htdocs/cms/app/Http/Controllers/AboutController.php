<?php


namespace App\Http\Controllers;

use Illuminate\Routing\Controller as BaseController;

class AboutController extends BaseController
{
    public function showAbout(): string
    {
        return 'About Details Information';
    }

    public function showSubject($theSubject): string
    {
        return "Details information about $theSubject";
    }
}
