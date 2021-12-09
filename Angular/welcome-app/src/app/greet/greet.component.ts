import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-greet',
  templateUrl: './greet.component.html',
  styleUrls: ['./greet.component.css']
})
export class GreetComponent implements OnInit {

  greetingMessage:string

  constructor() {
    this.greetingMessage=""
   }

    handleGreet(userName:string)
    {
    let hrs = new Date().getHours()
    let time = hrs < 12 ? "Morning":
                          hrs<18 ?" Afternoon" :
                           "Evening"
                           
    this.greetingMessage=`Hello ${userName},Good ${time}`

    }
  

  ngOnInit(): void {
  }

}
