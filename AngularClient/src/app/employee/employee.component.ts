import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { Employee } from '../common/Employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent implements OnInit {

  allEmpl: Employee[] = [];
  constructor(private employeeService: EmployeeService) {

  }
  ngOnInit(): void {

    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.getAllEmployees().subscribe(x => this.allEmpl = x);
  }
}
