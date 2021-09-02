import { Component, Input, OnInit, EventEmitter } from '@angular/core';
import Employee from 'src/app/models/employee/employee';

@Component({
  selector: 'app-employee-table',
  templateUrl: './employee-table.component.html',
  styleUrls: ['./employee-table.component.css']
})
export class EmployeeTableComponent implements OnInit {

  employeeListUpdate = new EventEmitter()

  @Input()
  employeeList: Employee[]

  @Input()
  isAdmin: boolean;

  constructor() {
    this.employeeList = []
    this.isAdmin = false
  }

  saveRadio(idx: any, level: number) {
    console.log(idx, level)
    this.employeeList[idx].serviceLevel = level
    console.log(this.employeeList)
  }

  trackByID(employee: Employee) {
    return employee.id
  }

  ngOnInit(): void {
  }

}
