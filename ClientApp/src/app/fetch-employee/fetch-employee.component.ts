import { Component, Inject } from '@angular/core';  
import { Http, Headers } from '@angular/http';  
import { Router, ActivatedRoute } from '@angular/router';  
import { EmployeeService } from './services/empservice.service';
import { PagerService } from './services/PagerService.service';


@Component({  
    selector: 'app-fetch-employee',
    templateUrl: './fetch-employee.component.html'  ,
    providers: [EmployeeService,PagerService]
    
})  

export class FetchEmployeeComponent {  
    public empList: EmployeeData[];  

      // pager object
      pager: any = {};

      // paged items
      pagedItems: any[];
  
    constructor(public http: Http, private _router: Router, private _employeeService: EmployeeService,private pagerService: PagerService) {  
         this.getEmployees();  
    }  
  
    getEmployees() {  
         this._employeeService.getEmployees().subscribe(  
             data => 
             {
                 
                this.empList = data;
                this.setPage(1)
            
             });  
    }  
  
    delete(employeeID) {  
        var ans = confirm("Do you want to delete customer with Id: " + employeeID);  
        if (ans) {  
            this._employeeService.deleteEmployee(employeeID).subscribe((data) => {  
                this.getEmployees();  
            }, error => console.error(error))  
        }  
    }  

    setPage(page: number) {
        // get pager object from service
        this.pager = this.pagerService.getPager(this.empList.length, page);

        // get current page of items
        this.pagedItems = this.empList.slice(this.pager.startIndex, this.pager.endIndex + 1);
    }
}  
  
interface EmployeeData {  
    employeeId: number;  
    name: string;  
    gender: string;  
    city: string;  
    department: string;  
  
}