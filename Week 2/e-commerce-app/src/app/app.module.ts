import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { NgxPaginationModule } from 'ngx-pagination';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { HeaderComponent } from './components/header/header.component';
import { MainContentComponent } from './components/main-content/main-content.component';
import { CategoriesRowComponent } from './components/main-content/categories-row/categories-row.component';
import { AboutComponent } from './components/misc/about/about.component';
import { ContactComponent } from './components/misc/contact/contact.component';
import { Error404Component } from './components/misc/errors/error404/error404.component';
import { ProductsDisplayComponent } from './components/main-content/products-display/products-display.component';
import { ProductsDisplaySidebarComponent } from './components/main-content/products-display/products-display-sidebar/products-display-sidebar.component';
import { ProductsDisplayMainComponent } from './components/main-content/products-display/products-display-main/products-display-main.component';
import { CheckDescriptionPipe } from './pipes/check-description.pipe';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HeaderComponent,
    MainContentComponent,
    CategoriesRowComponent,
    AboutComponent,
    ContactComponent,
    Error404Component,
    ProductsDisplayComponent,
    ProductsDisplaySidebarComponent,
    ProductsDisplayMainComponent,
    CheckDescriptionPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgxPaginationModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
