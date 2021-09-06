import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'checkDescription'
})
export class CheckDescriptionPipe implements PipeTransform {

  transform(description: string): string {
    if(description.length==0){
      return "No description provided"
    }
    return description ;
  }

}
