import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  name = "Anandu R"
  designation = "Software Engineer"
  company = "SOTI"
  profileIcon = "../../../assets/images/profile.jpg"
  constructor() { }

  ngOnInit(): void {
  }

}
