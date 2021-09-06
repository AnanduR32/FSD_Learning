import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetDataService } from 'src/app/services/get-data.service';

@Component({
  selector: 'app-products-display',
  templateUrl: './products-display.component.html',
  styleUrls: ['./products-display.component.css']
})
export class ProductsDisplayComponent implements OnInit {
  categoryId: any
  subCategories: any
  products: any
  constructor(private activatedRoute: ActivatedRoute, private dataService: GetDataService) {
    this.categoryId = this.activatedRoute.snapshot.paramMap.get('id')
  }

  changeSubCategory(id:any){
    if(id==0){
      this.getProducts(this.categoryId)
    }else{
      this.getProductsBySubId(id)
    }
  }

  ngOnInit(): void {
    this.getSubCategories(this.categoryId)
    this.getProducts(this.categoryId)
  }

  getSubCategories(id:number){
    this.dataService.getSubCategoriesById(id).subscribe((response)=>{
      this.subCategories = response['data']
    },
    (error)=>{
      alert("Failed to fetch subcategory list")
    })
  }
  getProducts(id:number){
    this.dataService.getProductsById(id).subscribe((response)=>{
      this.products = response['data']
    },
    (error)=>{
      alert('Failed to fetch product list')
    })
  }
  getProductsBySubId(id:number){
    this.dataService.getProductsBySubId(id).subscribe((response)=>{
      this.products = response['data']
    })
  }

}
