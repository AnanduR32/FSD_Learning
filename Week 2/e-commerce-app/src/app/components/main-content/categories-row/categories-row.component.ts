import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categories-row',
  templateUrl: './categories-row.component.html',
  styleUrls: ['./categories-row.component.css']
})
export class CategoriesRowComponent implements OnInit {

  @Input() categories: any[]

  constructor(private router: Router) {
    this.categories = []
  }

  onNavigate(id: number) {
    this.router.navigate(['/products', id]).catch((error)=>{console.log(`Failed to route to product with id: ${id}`)})
  }

  ngOnInit(): void {
  }

}
