import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import DemoComponent from './demo/demo.component';
import { FormsModule } from '@angular/forms';
import { StructuralDirectivesComponent } from './structural-directives/structural-directives.component';
import { AddHonorificsPipe } from './pipes/add-honorifics.pipe';
import { EmployeeTableComponent } from './structural-directives/employee-table/employee-table.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    StructuralDirectivesComponent,
    AddHonorificsPipe,
    EmployeeTableComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
