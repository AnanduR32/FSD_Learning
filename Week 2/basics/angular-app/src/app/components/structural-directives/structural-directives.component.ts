import { Component, OnInit } from '@angular/core';
import Employee from 'src/app/models/employee/employee';
import { EmployeeDataService } from 'src/app/services/employee-data.service';

@Component({
  selector: 'app-structural-directives',
  templateUrl: './structural-directives.component.html',
  styleUrls: ['./structural-directives.component.css']
})
export class StructuralDirectivesComponent implements OnInit {
  isAdmin: boolean = true
  serviceLevel: number = 1
  employeeList: Employee[]

  toggleAdminRole() {
    this.isAdmin = !this.isAdmin;
  }

  updateEmployeeList(employeeListNew: any) {
    console.log(`Before update: \n`)
    console.log(this.employeeList)
    this.employeeList = employeeListNew
    console.log(`After update: \n`)
    console.log(this.employeeList)
  }


  constructor(private empService: EmployeeDataService) {
    this.employeeList = []
  }

  ngOnInit(): void {
    this.empService.getData().subscribe(
      (data)=>{
        this.employeeList = data
      },
      (error)=>{
        alert('API data fetch failed')
      }
    )
    console.log(this.employeeList)
  }

}
