import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { ComidasComponent } from './pages/comidas/comidas.component';
import { BebidasComponent } from './pages/bebidas/bebidas.component';

const routes: Routes = [ {
  path: "",
  pathMatch: "full",
  redirectTo: "cardapio",
},
{
  path: "cardapio",
  component: CardapioComponent,
},
{
  path: "comidas",
  component: ComidasComponent,
},
{
  path: "bebidas",
  component: BebidasComponent,
},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
