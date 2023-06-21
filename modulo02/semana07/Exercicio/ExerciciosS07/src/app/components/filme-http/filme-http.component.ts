import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { IFilme } from 'src/app/interface/IFilme';
import { FilmesService } from 'src/app/services/filmes.service';

@Component({
  selector: 'app-filme-http',
  templateUrl: './filme-http.component.html',
  styleUrls: ['./filme-http.component.css']
})
export class FilmeHttpComponent {

  carregando = false;
  filmesArray: IFilme[] = [];
  filmeAtual: IFilme | null = null;
  filmesTopTres: IFilme[] | null = null;
  indiceFilme = 0;

  constructor(private filmesService: FilmesService) {
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta
      this.carregando = false;
      this.filmesTopTres = this.filmesService.buscarTopTres(resposta);
      this.filmeAtual = this.filmesTopTres[0];
    });
  }

  buscarFilmes() {
    this.carregando = true;
    this.filmesService.buscarFilmes().subscribe(resposta => {
      this.filmesArray = resposta
      this.carregando = false;
    });
  }

  filmeBemAvaliado() {
    const resultado = this.filmesService.buscarFilmeMaisBemAvaliado(this.filmesArray);
    console.log(resultado);
  }

  proximo() {
    this.indiceFilme++;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }

  anterior() {
    this.indiceFilme--;
    if (this.filmesTopTres != null)
      this.filmeAtual = this.filmesTopTres[this.indiceFilme];
  }
}
