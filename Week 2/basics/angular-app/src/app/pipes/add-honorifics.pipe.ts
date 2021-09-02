import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'addHonorifics'
})
export class AddHonorificsPipe implements PipeTransform {

  transform(name: string, gender: string): string {
    if(gender.toLowerCase()==="male"){
      return "Mr. "+name
    }
    else{
      return "Ms. "+name
    }
  }

}
