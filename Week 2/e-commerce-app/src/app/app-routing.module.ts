import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { MainContentComponent } from './components/main-content/main-content.component';
import { AboutComponent } from './components/misc/about/about.component';
import { ContactComponent } from './components/misc/contact/contact.component';
import { Error404Component } from './components/misc/errors/error404/error404.component';

const routes: Routes = [
  { path: 'home', component: MainContentComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full'},
  { path: '**', component: Error404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
