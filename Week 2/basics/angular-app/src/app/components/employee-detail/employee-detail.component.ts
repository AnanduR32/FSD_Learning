import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: ['./employee-detail.component.css']
})
export class EmployeeDetailComponent implements OnInit {
  employeeID: any;
  constructor(private activatedRoute: ActivatedRoute) {
      this.employeeID = activatedRoute.snapshot.paramMap.get('id')
      console.log(this.employeeID)
   }

  ngOnInit(): void {
  }

}
