import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html'
 
})
export class WelcomeComponent implements OnInit {
   message:string
   today:string
   randomValue:number
  constructor ()
{
  console.log("Constructor Created")
this.message="Welcome To Swabhav Tech" 
this.today = new Date().toString()
this.randomValue = Math.random()
}
ngOnInit()
{
console.log("Component and View Loaded Successfully")
setTimeout(() =>{
  this.message = "Welcome To Data Binding After 3 Seconds"
  this.today = new Date().toString()

},3000)
}
}
