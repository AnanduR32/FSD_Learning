import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Employee from '../models/employee/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeDataService {
  
  // employeeList: Employee[] = []
  
  constructor(private http: HttpClient ) { }

  getData():Observable<any>{
    return this.http.get('http://127.0.0.1:5000/getData')
  }
}
