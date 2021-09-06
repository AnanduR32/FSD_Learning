import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  name = "Anandu R"
  designation = "Software Engineer"
  company = "SOTI"
  profileIcon = "../../../assets/images/profile.jpg"
  constructor() { }

  ngOnInit(): void {
  }

}
