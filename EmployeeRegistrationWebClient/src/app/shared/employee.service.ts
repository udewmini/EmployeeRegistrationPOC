import { Injectable } from '@angular/core';
import { FormBuilder} from '@angular/forms';
import {HttpClient} from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private fb:FormBuilder, private http:HttpClient) { }
  readonly BaseURI='http://localhost:5500/api/employee';
  formModel = this.fb.group({
    fname:[''], lname:[''], position:[''], email:[''], address:[''], contact:['']
  })

  register(){
    var body={
      fname:this.formModel.value.fname,
      lname:this.formModel.value.lname,
      position:this.formModel.value.position,
      address:this.formModel.value.address,
      email:this.formModel.value.email,
      contact:this.formModel.value.contact
    };
    return this.http.post( this.BaseURI, body);
  }

 delete()
  {
    //id = this.formModel.value.id;
   // return this.http.delete(this.BaseURI, id);
  }

  
}
