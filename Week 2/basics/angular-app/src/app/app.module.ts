import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { NgxPaginationModule } from 'ngx-pagination';

import { AppComponent } from './app.component';
import DemoComponent from './components/demo/demo.component';
import { FormsModule } from '@angular/forms';
import { StructuralDirectivesComponent } from './components/structural-directives/structural-directives.component';
import { AddHonorificsPipe } from './pipes/add-honorifics.pipe';
import { EmployeeTableComponent } from './components/structural-directives/employee-table/employee-table.component';
import { CounterOutputComponent } from './components/counter/counter-output/counter-output.component';
import { CounterButtonsComponent } from './components/counter/counter-buttons/counter-buttons.component';
import { CounterComponent } from './components/counter/counter.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    StructuralDirectivesComponent,
    AddHonorificsPipe,
    EmployeeTableComponent,
    CounterOutputComponent,
    CounterButtonsComponent,
    CounterComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    NgxPaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
