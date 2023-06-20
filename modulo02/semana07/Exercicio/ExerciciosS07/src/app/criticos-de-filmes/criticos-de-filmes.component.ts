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
      "nome": new FormControl('',Validators.required),
      "email": new FormControl('',[Validators.required, Validators.email]),
      "nomeFilme": new FormControl('',Validators.required),
      "avaliacao": new FormControl('',Validators.required),
    });
  }

  onSubmit() {
    console.log(this.avaliacaoForm.get("nome")?.value)
    console.log(this.avaliacaoForm.get("email")?.value)
    console.log(this.avaliacaoForm.get("nomeFilme")?.value)
    console.log(this.avaliacaoForm.get("avaliacao")?.value)
  }
}
