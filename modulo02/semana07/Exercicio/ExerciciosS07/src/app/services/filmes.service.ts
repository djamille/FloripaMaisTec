import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { IFilme } from '../interface/IFilme';

@Injectable({
  providedIn: 'root'
})
export class FilmesService {

  constructor(private httpClient: HttpClient) { }

  buscarFilmes(){
    return this.httpClient.get<IFilme[]>(environment.apiUrl + '/filmes/get-all')
  }

  buscarFilmeMaisBemAvaliado(filmesArray: IFilme[]) {
    return filmesArray.reduce(function(filmePrev, filmeAtual) {
      return filmePrev.notaIMDb > filmeAtual.notaIMDb ? filmePrev : filmeAtual;
    });
  }

  buscarTopTres(filmesArray: IFilme[]) {
    let filmesArrayCopia: IFilme[] = filmesArray;
    let topTres: IFilme[] = [];

    for (let index = 0; index < 3; index++) {
      topTres.push(this.buscarFilmeMaisBemAvaliado(filmesArrayCopia));
      filmesArrayCopia.splice(filmesArrayCopia.indexOf(topTres[index]), 1);
    }

    return topTres;
  }

}
