import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-criticos-de-filmes',
  templateUrl: './criticos-de-filmes.component.html',
  styleUrls: ['./criticos-de-filmes.component.css'],
})
export class CriticosDeFilmesComponent {
  avaliacaoForm: FormGroup;

  constructor() {
    this.avaliacaoForm = new FormGroup({
      'nome': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'email': new FormControl('', [Validators.required, Validators.email]),
      'nomeFilme': new FormControl('', [Validators.required, Validators.minLength(3)]),
      'avaliacao': new FormControl(null, [Validators.required, Validators.min(1), Validators.max(10)]),
    });
  }

  enviarFormulario() {
    const nomeFilme = this.avaliacaoForm.get('nomeFilme')?.value;
    alert(`Você avaliou o filme ${nomeFilme}`);
  }
}
