import { Component, Input, OnInit, EventEmitter, Output } from '@angular/core';
import { Router } from '@angular/router';
import Employee from 'src/app/models/employee/employee';

@Component({
  selector: 'app-employee-table',
  templateUrl: './employee-table.component.html',
  styleUrls: ['./employee-table.component.css']
})
export class EmployeeTableComponent implements OnInit {

  @Output()
  employeeListUpdate = new EventEmitter()

  @Input()
  employeeList: Employee[]

  @Input()
  isAdmin: boolean;

  constructor(private router: Router) {
    this.employeeList = []
    this.isAdmin = false
  }

  saveRadio(idx: any, level: number) {
    this.employeeList[idx].serviceLevel = level
    this.employeeListUpdate.emit(this.employeeList)
  }

  

  trackByID(employee: Employee) {
    return employee.id
  }

  p: number = 1;

  onNavigate(id:number){
    this.router.navigate(['employeeDetail',id]).catch((response)=>{console.log(`Routed to employee with id: ${id}`)})
  }

  ngOnInit(): void {
  }

}
