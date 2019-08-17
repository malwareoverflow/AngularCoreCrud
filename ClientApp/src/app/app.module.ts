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



import { AppConfig } from './app.config';

import { AlertComponent } from '../app/_directives/alert.component';
import { AuthGuard } from './_guards/index';
import { AlertService, AuthenticationService, UserService } from './_services/index';
import { LoginComponent } from './login/index';
import { RegisterComponent } from './register/index';

@NgModule({
  declarations: [
    AppComponent,
    
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
     FetchEmployeeComponent,
     AddEmployeeComponent,
    
     LoginComponent,
     RegisterComponent,
     AlertComponent

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
       { path: 'login-user', component: LoginComponent }, 
       { path: 'register-user', component: RegisterComponent }, 
      
    ])
  ],
  providers: [EmployeeService,PagerService,AuthGuard,
    AlertService,
    AuthenticationService,
    UserService,AppConfig],
 
  bootstrap: [AppComponent]
})
export class AppModule { }
