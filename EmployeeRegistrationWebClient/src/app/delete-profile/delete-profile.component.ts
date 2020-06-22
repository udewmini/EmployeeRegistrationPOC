import { HttpClientModule, HttpClient } from '@angular/common/http';  
import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../shared/employee.service';

@Component({
  selector: 'app-delete-profile',
  templateUrl: './delete-profile.component.html',
  styleUrls: ['./delete-profile.component.css']
})
export class DeleteProfileComponent implements OnInit {
  
  constructor(private httpService: HttpClient, public service: EmployeeService) { }
  employee: string[];  
 
  ngOnInit() {this.httpService.get('http://localhost:5500/api/employee').subscribe(  
    data => {  
     this.employee = data as string [];  
    }  
  );  
  }

  onSubmit(){
    this.service.delete(this.employee).subscribe(
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
