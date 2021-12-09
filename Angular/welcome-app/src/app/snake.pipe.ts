import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'snake'
})
export class SnakePipe implements PipeTransform {

  transform(value: string ,casing:string=""): string {
   if(casing=="U"){
     value= value.toUpperCase()
   }
   else if (casing == "L")
   {
value = value.toLowerCase()
   }
   let values:string[] = value.split('')
   return values.join('_')
  }

}
