import {Component, OnInit} from "@angular/core";
import { Product } from "./product";
import { ProductService } from "./product.service";

@Component(
    {
        selector:'sw-product-list',
        template:`
        <div>
               <h1>Product List</h1>
        
              <div *ngFor="let p of products">
              <h2>{{p.id}} -- {{p.name}}</h2>
             </div>
        </div>
        
        `
    }
)
export class ProductListComponent implements OnInit
{
products : Array<Product>  = new Array<Product>()

constructor(private productService:ProductService)
{

}

ngOnInit() {
    this.products = this.productService.getProducts()
    
}
}