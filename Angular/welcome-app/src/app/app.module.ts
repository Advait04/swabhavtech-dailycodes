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
    CircleComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
