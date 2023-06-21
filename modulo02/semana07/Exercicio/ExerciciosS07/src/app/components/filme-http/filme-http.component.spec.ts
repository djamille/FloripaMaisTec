import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmeHttpComponent } from './filme-http.component';

describe('FilmeHttpComponent', () => {
  let component: FilmeHttpComponent;
  let fixture: ComponentFixture<FilmeHttpComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FilmeHttpComponent]
    });
    fixture = TestBed.createComponent(FilmeHttpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
