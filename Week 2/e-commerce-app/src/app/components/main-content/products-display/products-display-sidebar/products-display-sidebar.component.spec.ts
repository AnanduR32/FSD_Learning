import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsDisplaySidebarComponent } from './products-display-sidebar.component';

describe('ProductsDisplaySidebarComponent', () => {
  let component: ProductsDisplaySidebarComponent;
  let fixture: ComponentFixture<ProductsDisplaySidebarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductsDisplaySidebarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductsDisplaySidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
