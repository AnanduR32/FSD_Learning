import { Component, OnInit } from '@angular/core';
import Employee from '../models/employee/employee';

@Component({
  selector: 'app-structural-directives',
  templateUrl: './structural-directives.component.html',
  styleUrls: ['./structural-directives.component.css']
})
export class StructuralDirectivesComponent implements OnInit {
  isAdmin: boolean = true
  serviceLevel: number = 1
  employeeList: Employee[] = [
    {
      id: 1377,
      name: "Anandu R",
      gender: "male",
      email: "ananduraj32@gmail.com",
      phoneno: 7012835996,
      serviceLevel: 1
    },
    {
      id: 1347,
      name: "Koyomin Araragi",
      gender: "male",
      email: "koyomin.araragi@unknown.com",
      phoneno: 1234567890,
      serviceLevel: 2
    },
    {
      id: 1429,
      name: "Uzumaki Naruto",
      gender: "male",
      email: "uzumaki.naruto@unknown.com",
      phoneno: 2345678901,
      serviceLevel: 3
    },
    {
      id: 1656,
      name: "oshino Shinobu",
      gender: "female",
      email: "oshino.shinobu@unknown.com",
      phoneno: 3456789012,
      serviceLevel: 2
    }

  ]

  toggleAdminRole(){
    this.isAdmin = !this.isAdmin;
  }

  updateEmployeeList(employeeList : any){
    console.log(this.employeeList)
    this.employeeList = employeeList
    console.log(this.employeeList)
  }


  constructor() { }

  ngOnInit(): void {
  }

}
