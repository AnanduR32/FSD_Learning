import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-products-display-main',
  templateUrl: './products-display-main.component.html',
  styleUrls: ['./products-display-main.component.css']
})
export class ProductsDisplayMainComponent implements OnInit {

  @Input() products: any
  constructor() { }

  ngOnInit(): void {
  }

}
