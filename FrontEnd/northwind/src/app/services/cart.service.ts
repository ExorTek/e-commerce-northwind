import { Injectable } from '@angular/core';
import { CartItem } from '../models/cartItem';
import { CartItems } from '../models/cartItems';
import { Product } from '../models/product';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  constructor() { }

  addToCart(product: Product){
    const item = CartItems.find(c => c.product.productId === product.productId);
    if (item){
      item.quantity += 1;
    }else{
      const cartItem = new CartItem();
      cartItem.product = product;
      cartItem.quantity = 1;
      CartItems.push(cartItem);
    }
  }

  removeFromCart(product: Product){
    let item: CartItem | undefined;
    item = CartItems.find(c => c.product.productId === product.productId);
    if (item instanceof CartItem) {
      CartItems.splice(CartItems.indexOf(item), 1);
    }
  }

  list(): CartItem[]{
    return CartItems;
  }
}
