<?php

use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\AboutController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('home', [HomeController::class, 'showWelcome']);
//Route::get('/', 'App\Http\Controllers\HomeController@showWelcome');

/*  Solution:
    https://laracasts.com/discuss/channels/laravel/laravel8-ui-bootstrap-uiauth-error-target-class-homecontroller-does-not-exist
*/

Route::get('about', [AboutController::class, 'showAbout']);

Route::get('about/directions',array('as' => 'directions', function() {
//    $theURL = URL::route('directions');
    return 'Directions go here';
}));

Route::get('about/{theSubject}', [AboutController::class, 'showSubject']);

Route::any('submit-form', function () {
    return 'Process Form';
});

//Route::get('about/{theSubject}', function ($theSubject) {
//    return $theSubject . ' content goes here';
//});

//Btap Art va Price
Route::get('{price}/{art}', function ($price, $art) {
    return 'Price is: ' . $price .'<br>Art is: ' . $art;
});

Route::get('where',function () {
    return Redirect::route('directions');
});
