import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductsDisplayMainComponent } from './products-display-main.component';

describe('ProductsDisplayMainComponent', () => {
  let component: ProductsDisplayMainComponent;
  let fixture: ComponentFixture<ProductsDisplayMainComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductsDisplayMainComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductsDisplayMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
