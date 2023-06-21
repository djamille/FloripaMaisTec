import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CriticosDeFilmesComponent } from './criticos-de-filmes.component';

describe('CriticosDeFilmesComponent', () => {
  let component: CriticosDeFilmesComponent;
  let fixture: ComponentFixture<CriticosDeFilmesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CriticosDeFilmesComponent]
    });
    fixture = TestBed.createComponent(CriticosDeFilmesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
