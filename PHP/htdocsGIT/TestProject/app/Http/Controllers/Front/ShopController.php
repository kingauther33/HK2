<?php

namespace App\Http\Controllers\Front;

use App\Http\Controllers\Controller;
use App\Models\Product;
use App\Models\ProductComment;
use Illuminate\Http\Request;
use Symfony\Component\Routing\Matcher\RedirectableUrlMatcher;

class ShopController extends Controller
{
    public function show($id) {
        $product = Product::findOrFail($id);

        $avgRating = 0;
        $sumRating = array_sum(array_column($product->productComments->toArray(), 'rating'));
        $countRating = count($product->productComments);
        if ($countRating != 0) {
            $avgRating = $sumRating/$countRating;
        }

        $relatedProducts = Product::where('product_category_id', $product->product_category_id)
            ->where('tag', $product->tag)
            ->limit(4)
            ->get();

        return view('front.shop.show', compact('product', 'avgRating', 'relatedProducts'));
    }

    public function postComment(Request $request) {
        ProductComment::create($request->all());

        return redirect()->back();
    }

    public function index(Request $request) {
        $perPage = $request->show ?? 3;
        $sortBy = $request->sort_by ?? 'latest';

        switch ($sortBy) {
            case 'latest':
                $products = Product::orderBy('id');
                break;
            case 'oldest':
                $products = Product::orderByDesc('id');
                break;
            case 'name-ascending':
                $products = Product::orderBy('name');
                break;
            case 'name-descending':
                $products = Product::orderByDesc('name');
                break;
            case 'price-ascending':
                $products = Product::orderBy('price');
                break;
            case 'price-descending':
                $products = Product::orderByDesc('price');
                break;
            default:
                $products = Product::orderBy('id');
        }

        $products = $products->paginate($perPage);

        $products->appends(['sort_by' => $sortBy, 'show' => $perPage]);

        return view('front.shop.index', compact('products'));
    }
}
