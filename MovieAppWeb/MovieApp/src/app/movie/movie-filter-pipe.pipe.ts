import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'movieFilterPipe'
})
export class MovieFilterPipePipe implements PipeTransform {

  transform(list: any[], filterText: string): any {
    console.log(list,filterText)
    return list ? list.filter(item => item.Title.search(new RegExp(filterText, 'i')) > -1) : [];
  }

}
