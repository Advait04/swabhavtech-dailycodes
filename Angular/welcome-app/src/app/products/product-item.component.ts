import {Component, OnInit} from "@angular/core";
import { Product } from "./product";
import { ProductService } from "./product.service";

@Component(
    {
        selector:'sw-product-item',
        template:`
        <div>
               <h1>Product Item</h1>
                  <h2>{{product.id}} -- {{product.name}}</h2>
        </div>
     `
    }
)
export class ProductItemComponent implements OnInit
{
product:Product  = new Product(0,"")

constructor(private productService:ProductService)
{

}

ngOnInit() {
    this.product = this.productService.getMaxSoldProduct()
    
}
}