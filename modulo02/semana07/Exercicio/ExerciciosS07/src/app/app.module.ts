import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { CalculadoraComponent } from './components/calculadora/calculadora.component';
import { CriticosDeFilmesComponent } from './components/criticos-de-filmes/criticos-de-filmes.component';
import { ReactiveFormsModule } from '@angular/forms';
import {HttpClientModule}from '@angular/common/http';
import { FilmeHttpComponent } from './components/filme-http/filme-http.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CalculadoraComponent,
    CriticosDeFilmesComponent,
    FilmeHttpComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
