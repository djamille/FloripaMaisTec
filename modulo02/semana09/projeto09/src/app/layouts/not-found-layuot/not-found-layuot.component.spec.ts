import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotFoundLayuotComponent } from './not-found-layuot.component';

describe('NotFoundLayuotComponent', () => {
  let component: NotFoundLayuotComponent;
  let fixture: ComponentFixture<NotFoundLayuotComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NotFoundLayuotComponent]
    });
    fixture = TestBed.createComponent(NotFoundLayuotComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
