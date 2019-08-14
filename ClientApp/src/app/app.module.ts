import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { EmployeeService } from './services/empservice.service'  
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  
import { HttpModule } from '@angular/http';  
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';

import { FetchEmployeeComponent } from './fetch-employee/fetch-employee.component'  
 import { AddEmployeeComponent } from './addemployee/addemployee.component'  
import { PagerService } from './fetch-employee/services/PagerService.service';

@NgModule({
  declarations: [
    AppComponent,
    
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
     FetchEmployeeComponent,
     AddEmployeeComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
       { path: 'fetch-employee', component: FetchEmployeeComponent },  
       { path: 'register-employee', component: AddEmployeeComponent },  
       { path: 'employee/edit/:id', component: AddEmployeeComponent },  
    ])
  ],
  providers: [EmployeeService,PagerService],
 
  bootstrap: [AppComponent]
})
export class AppModule { }
