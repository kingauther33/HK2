<?php


namespace App\Http\Controllers;

use Illuminate\Routing\Controller as BaseController;

class LayoutController extends BaseController
{
    public function showLayout() {
        return view('layout');
    }
}
