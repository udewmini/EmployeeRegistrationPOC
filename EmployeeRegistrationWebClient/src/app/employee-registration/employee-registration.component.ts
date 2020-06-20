import { HttpClientModule, HttpClient } from '@angular/common/http';  
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-registration',
  templateUrl: './employee-registration.component.html',
  styleUrls: ['./employee-registration.component.css']
})
export class EmployeeRegistrationComponent implements OnInit {

  constructor(private httpService: HttpClient) { }
  employee: string[];  
  ngOnInit() {  
    this.httpService.get('http://localhost:5500/api/employee').subscribe(  
      data => {  
       this.employee = data as string [];  
      }  
    );  
  }  
  }


