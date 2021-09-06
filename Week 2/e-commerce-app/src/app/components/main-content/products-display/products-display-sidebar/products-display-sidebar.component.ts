import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


@Component({
  selector: 'app-products-display-sidebar',
  templateUrl: './products-display-sidebar.component.html',
  styleUrls: ['./products-display-sidebar.component.css']
})
export class ProductsDisplaySidebarComponent implements OnInit {

  @Input() subCategories: any

  @Output() subCategoryChangeEmitter = new EventEmitter()

  constructor() { }

  changeSubCategory(id:any){
    this.subCategoryChangeEmitter.emit(id)
  }

  ngOnInit(): void {
  }

}
