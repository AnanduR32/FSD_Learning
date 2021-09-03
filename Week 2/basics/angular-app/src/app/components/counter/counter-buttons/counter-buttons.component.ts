import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-counter-buttons',
  templateUrl: './counter-buttons.component.html',
  styleUrls: ['./counter-buttons.component.css']
})
export class CounterButtonsComponent implements OnInit {

  @Input() counterValue:number = 0

  @Output() updateCount = new EventEmitter()
  constructor() { }

  onClick(type:string){
    this.updateCount.emit(type)
  }

  ngOnInit(): void {
  }

}
