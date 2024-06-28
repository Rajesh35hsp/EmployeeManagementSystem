import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../common/Employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  BaseUrl = "http://localhost:5198"
  constructor(private httpClient: HttpClient) { }

  getAllEmployees(): Observable<Employee[]> {

    return this.httpClient.get<Employee[]>(this.BaseUrl + "/api/Employee");
  }
}
