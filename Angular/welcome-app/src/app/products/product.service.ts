import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable()
export class ProductService {

  products : Array<Product> = new Array<Product>()

  constructor() {

    console.log("service created")
    this.products.push(new Product (1,"book"))
    this.products.push(new Product (2,"pen"))
    this.products.push(new Product (3,"pencil"))
    this.products.push(new Product (4,"watch"))
    this.products.push(new Product (5,"mobile"))
   }

   getProducts()
   {
     return this.products
   }

   getMaxSoldProduct()
   {
 let index = Math.round(Math.random()*4)
 return this.products[index]

   }
}
