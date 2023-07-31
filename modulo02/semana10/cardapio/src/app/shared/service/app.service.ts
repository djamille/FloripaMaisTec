import { Injectable } from "@angular/core";
import { ComidaItem } from "../models/comida-item.model";
import { BebidaItem } from "../models/bebida-item.model";
import { COMIDAS_MOCK } from "../mocks/comida-mock";
import { BEBIDAS_MOCK } from "../mocks/bebida-mock";
import { Observable, delay, of } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class AppService { comidaLista: ComidaItem[] = COMIDAS_MOCK;
  bebidasLista: BebidaItem[] = BEBIDAS_MOCK;

  constructor(private http: HttpClient) {}

  getComidas(): Observable<ComidaItem[]> {
    return this.http.get<ComidaItem[]>("http://localhost:3000/comidas");
    // return of(this.comidaLista).pipe(delay(5000)); // chamada API
  }

  getBebidas(): Observable<BebidaItem[]> {
    return this.http.get<ComidaItem[]>("http://localhost:3000/bebidas");
    // return of(this.bebidasLista); // chamada API
  }

  postBebida(bebida: BebidaItem): Observable<void> {
    return this.http.post<void>("http://localhost:3000/bebidas", bebida);
  }
}
