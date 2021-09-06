import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GetDataService {

  private BASE_PATH = "http://apolis-grocery.herokuapp.com/api/"

  constructor(private http: HttpClient) { }

  getCategories(): Observable<any> {
    return this.http.get<any>(this.BASE_PATH + 'category')
  }

  getSubCategoriesById(id: number): Observable<any> {
    return this.http.get<any>(this.BASE_PATH + 'subcategory/' + id)
  }

  getProductsById(id: number): Observable<any> {
    return this.http.get<any>(this.BASE_PATH + 'products/cat/' + id)
  }

  getProductsBySubId(id: number): Observable<any> {
    return this.http.get<any>(this.BASE_PATH + 'products/sub/' + id)
  }

}
