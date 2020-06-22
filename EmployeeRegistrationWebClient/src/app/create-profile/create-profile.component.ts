import { HttpClientModule, HttpClient } from '@angular/common/http';  
import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../shared/employee.service';

@Component({
  selector: 'app-create-profile',
  templateUrl: './create-profile.component.html',
  styleUrls: ['./create-profile.component.css']
})
export class CreateProfileComponent implements OnInit {
  
  constructor(public service: EmployeeService) { }
  
  
  ngOnInit() {  }  

  onSubmit(){
    this.service.register().subscribe(
      (res:any)=>{
        if(res.succeded)
        {
          this.service.formModel.reset();
        }
      },
      err=>{
        console.log(err);
      }
    )
  }
}
