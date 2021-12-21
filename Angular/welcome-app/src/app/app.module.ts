import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import {WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { GreetComponent } from './greet/greet.component';
import { LoopingComponent } from './looping/looping.component';
import { StudentComponent } from './student/student.component';
import { SnakePipe } from './snake.pipe';
import { BlueBallComponent } from './blue-ball/blue-ball.component';
import { CircleComponent } from './circle/circle.component';
import { ProductItemComponent } from './products/product-item.component';
import { ProductListComponent } from './products/product-list.component';
import { ProductService } from './products/product.service';
import { FormsModule } from '@angular/forms';
import { TwowayBindingComponent } from './twoway-binding/twoway-binding.component';

@NgModule({
  declarations: [
    WelcomeComponent,
    HeaderComponent,
    FooterComponent,
    SpinnerComponent,
    GreetComponent,
    LoopingComponent,
    StudentComponent,
    SnakePipe,
    BlueBallComponent,
    CircleComponent,
    ProductItemComponent,
    ProductListComponent,
    TwowayBindingComponent
  ],
  imports: [
    BrowserModule,FormsModule
    
  ],
  providers: [ProductService],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
