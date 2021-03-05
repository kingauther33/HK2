<?php

use Illuminate\Support\Facades\Route;
use App\Models\Task;
use http\Env\Request;


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

/*Route::get('/', function () {
    return view('welcome');
});*/

/***
 * Show Task Dashboard
 */
Route:get('/', function () {
    //
});

/***
 * Add New Task
 */
Route::post('/task', function () {
    //
});

/***
 * Delete Task
 */
Route::delete('/task/{task}', function () {
    //
});
