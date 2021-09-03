import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {
  counter: number = 0
  constructor() { }

  ngOnInit(): void {
  }
  counterUpdate(doWhat: string) {
    if (doWhat == "decrement") {
      this.counter--
    }
    else if (doWhat == "increment") {
      this.counter++
    }
    else if (doWhat == "reset") {
      this.counter = 0
    }
  }

}
