import { Component } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-criticos-de-filmes',
  templateUrl: './criticos-de-filmes.component.html',
  styleUrls: ['./criticos-de-filmes.component.css'],
})
export class CriticosDeFilmesComponent {
  avaliacaoForm: FormGroup;

  constructor() {
    this.avaliacaoForm = new FormGroup({
      nome: new FormGroup(''),
      email: new FormGroup(''),
      nomeFilme: new FormGroup(''),
      avaliacao: new FormGroup(''),
    });
  }

  onSubmit() {
    console.log(this.avaliacaoForm.value);
  }
}
