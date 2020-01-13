import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'labelPipe'
})
export class LabelPipePipe implements PipeTransform {

  transform(list: any[], filterText: string): any {
    return list ? list.filter(item => item.labels.includes(new RegExp(filterText, 'i'))>-1)
    : [];
  }


}
