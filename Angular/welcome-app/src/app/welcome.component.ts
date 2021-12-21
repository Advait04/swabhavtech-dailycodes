import {style} from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import {  asapScheduler, Observable,interval} from 'rxjs';
import { map, observeOn } from 'rxjs/operators';



@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html',
  styles:["background-color:'yellow'"]
 
})
export class WelcomeComponent implements OnInit {

  goalDetails:Observable<Goal>
  constructor()
  {
      this.goalDetails=interval(3000)
      .pipe(map (n=>
        {
          const t = new Date
          return new Goal(n+1,new Date().toString())
        }));
  }

  getDataAsync1(): Observable<number>
  {
    const observable = new Observable<number>((observer)=>{

  

    })
    .pipe(observeOn(asapScheduler))
     return observable;
  }

  getDataAsync2():Observable<number>{
  
    const publisher = interval(3000) 
    return publisher

  }

  getDataAsync3():Observable<any>
  {
   return interval(3000)
    .pipe(map (n=>
      {
        const t = new Date
        return {"time":t,"counter":n}
      }));
  }
 
 ngOnInit(): void {
   this.goalDetails.subscribe(d=>
    {
      console.log("Data Arrived")
      console.log(d.count)
      console.log(d.time)
    })

  console.log("End Of OnInIt")
  
    }

 
     
 }

 export class Goal
 {
   constructor (public count:Number,public time:string)
   {

   }
 }
