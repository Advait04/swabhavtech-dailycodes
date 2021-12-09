import {Component} from "@angular/core";
import { GreetComponent } from "../greet/greet.component";
@Component (
    {
        selector:'sw-looping',
        templateUrl:'looping.component.html'

    }
)
export class LoopingComponent{

    balls:Array<Ball> = new Array<Ball>()
    makeList(size:number)
    {
        return new Array(size);


    }

    getColor(isEven:boolean)
    {
        return isEven?'green':
        'blue'
    }
    constructor()
    {
        this.balls.push(new Ball(1,"green","ball_01"))
        this.balls.push(new Ball(2,"green","ball_02"))
        console.log("Looping Component")
    }
    handleClickEvent(id:number){
        console.log(id)
        let btn = this.balls.find(x=>id==id)
        if(btn)
        btn.color='yellow'

    }
}

export class Ball
{
    constructor (public id:number,public color:string,public description:string)
    {

    }
}