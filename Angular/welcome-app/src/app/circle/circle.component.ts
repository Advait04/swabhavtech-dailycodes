import { Component,Input, OnInit } from '@angular/core';

@Component({
  selector: 'sw-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent implements OnInit {
  @Input() sliderValue:number | undefined;

  attempt=0;
  winGAme = false;
  gameStatus='';
  blueBall= -1;



  constructor() { }
  balls: number[]=[];

  ngOnInit(): void {
    if(this.sliderValue)
    {
      this.fillArray(this.sliderValue);
      this.blueBall=this.randomNumber(1,this.sliderValue)
    }
  }

  fillArray(slideValue:number)
  {
    for(let index = 1;index <= slideValue;index++)
    {
      const element = this.balls.push(index);
    }
  }

  refresh()
  {
    window.location.reload();
  }

  ballClicked(index:number)
  {
this.attempt ++;
if(this.attempt <= 3 && this.winGAme == false)
{
  var element = document.getElementById("ball"+index);
  if(element && index < this.blueBall)
  {
    element.setAttribute("style","background-color:green;");
  }
  else if (element && index > this.blueBall)
  {
    element.setAttribute("style","background-color:red;");
  }
  else if (element)
  {
    element.setAttribute("style","background-color:blue;");
    this.gameStatus="Congratulations... You Won !!!  Blue BAll is" +this.blueBall;
    this.winGAme=true;
    return;
  }
  }
  if(this.attempt > 3 && this.winGAme === false)
  {
    this.gameStatus = "Better Luck Next Time, You Lost !!   Blue Ball Was :" +this.blueBall;
    return;
  }
  }

  randomNumber(min:number,max:number)
  {
    return Math.floor(Math.random() * (max-min) + min);
  }

}
  

