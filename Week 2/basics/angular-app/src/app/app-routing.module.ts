import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { Error404Component } from './components/errors/error404/error404.component';
import { EmployeeDetailComponent } from './components/employee-detail/employee-detail.component';
import { EmployeeTableComponent } from './components/structural-directives/employee-table/employee-table.component';

const routes: Routes = [
  { path: 'employeeDetail', component: EmployeeTableComponent },
  { path: 'employeeDetail/:id', component: EmployeeDetailComponent},
  { path: '', redirectTo: 'employeeDetail', pathMatch: 'full'},
  { path: '**', component: Error404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
