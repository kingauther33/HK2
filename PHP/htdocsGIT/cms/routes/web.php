<?php

use Illuminate\Support\Facades\Redirect;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\AboutController;
use App\Http\Controllers\ProfileController;
use App\Http\Controllers\LayoutController;
use Illuminate\Support\Facades\DB;
use Illuminate\Database\Eloquent\Model;
use App\Models\Posts;


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

Route::get('layout', [LayoutController::class, 'showLayout']);

Route::get('home', [HomeController::class, 'showWelcome']);
//Route::get('/', 'App\Http\Controllers\HomeController@showWelcome');

Route::get('profile/{name?}', [ProfileController::class, 'showProfile']);

/*  Solution:
    https://laracasts.com/discuss/channels/laravel/laravel8-ui-bootstrap-uiauth-error-target-class-homecontroller-does-not-exist
*/

Route::get('about', [AboutController::class, 'showAbout']);

Route::get('about/directions', array('as' => 'directions', function () {
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
    return 'Price is: ' . $price . '<br>Art is: ' . $art;
});

Route::get('where', function () {
    return Redirect::route('directions');
});

Route::get('insert', function () {
    DB::INSERT('insert into posts(title, body, is_admin) values(?,?,?)', ['PHP with Laravel', 'I love You 123123', 0]);
    return 'DONE!!';
});

Route::get('/read', function () {
    $result = DB::select('select * from posts where id < ?', [10]);
//    return $result;
    $titles = DB::table('posts')->pluck('title');
    $posts = DB::table('posts')->get();

    foreach ($result as $post) {
        echo $post->body . '<br>';
    }

    foreach ($titles as $title) {
        echo $title;
    }

    foreach ($posts as $post) {
        echo $post->body;
    }
});

Route::get('/update', function () {
    return DB::table("posts")
        ->where('id', 3)
        ->update(['title' => 'I want to RUN !!!']);
});

Route::get('/delete', function () {
    return DB::table("posts")
        ->where('id', 4)
        ->delete();
});

// Task 10
Route::get('readAll', function () {
    $posts = Posts::all();
    foreach ($posts as $post) {
        echo $post->title . '<br>';
    }
});

Route::get('findId', function () {
    $posts = Posts::where('id', '>=', 1)
        ->where('title', 'PHP with Laravel')
        ->where('body', 'like', '%123123%')
        ->orderBy('id', 'desc')
        ->take(10)
        ->get();
    foreach ($posts as $post) {
        echo $post->title . '<br>';
    }

});

Route::get('insertORM', function () {
    $post = new Posts();
    $post->title = 'Tarzan';
    $post->body = 'I\'m the Tarzan';
    $post->is_admin = 1;
    $post->save();
});

Route::get('updateORM', function () {
    $post = Posts::where('id', 4)->first();
    $post->title = 'updated ORM';
    $post->body = 'updated all DONE';
    $post->save();
});

Route::get('deleteORM', function () {
    Posts::where('id', '>=', 5)
        ->delete();
});

Route::get('destroyORM', function () {
    Posts::destroy([7,5]);
});

