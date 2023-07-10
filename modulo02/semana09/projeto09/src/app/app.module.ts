import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BuscaComponent } from './components/busca/busca.component';
import { SobreComponent } from './components/sobre/sobre.component';
import { FormsModule } from '@angular/forms';
import { NotFoundLayuotComponent } from './layouts/not-found-layuot/not-found-layuot.component';
import { NotFoundComponent } from './components/not-found/not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    BuscaComponent,
    SobreComponent,
    NotFoundLayuotComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
