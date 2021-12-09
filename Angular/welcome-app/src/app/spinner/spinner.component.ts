import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-spinner',
  templateUrl: './spinner.component.html',
 
})
export class SpinnerComponent implements OnInit {
imageUrl = "assets/spinner.gif"
hideImage=true
btnText="show"

handleToggle(e:any){
  console.log(e.target)
  this.hideImage= !this.hideImage
  if(this.btnText=="show")
  {
    this.btnText="hide"
    return
  }
 
  this.btnText="show"
}
  constructor() { }

  ngOnInit(): void {
  }

}
