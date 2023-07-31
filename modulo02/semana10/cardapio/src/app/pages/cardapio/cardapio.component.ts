import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { CardapioItem } from 'src/app/shared/models/cardapio-item.model';

@Component({
  selector: 'app-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.css']
})
export class CardapioComponent {
  infoApresentacao = {
    titulo: "NgFood",
    descricao: `
      Lorem ipsum dolor sit amet consectetur adipisicing elit. Facere,
      temporibus! Quae pariatur nisi adipisci tempora eius at. Consectetur, id
      tempora recusandae fugiat, dolores quaerat, necessitatibus ipsum natus est
      sunt ipsam?
    `,
    tituloBotao: "Cardápio",
  };

  itensCardapio: CardapioItem[] = [
    {
      titulo: "Comidas",
      urlImagem: "assets/img/food-0.jpg",
      path: "/comidas",
    },
    {
      titulo: "Bebidas",
      urlImagem: "assets/img/drink-0.jpg",
      path: "/bebidas",
    },
  ];

  constructor(private router: Router) {}

  navegarParaPagina(itemCardapio: CardapioItem) {
    console.log(itemCardapio);
    // regra de negócio ou verificar algo antes de redirecionar
    this.router.navigate([itemCardapio.path]);
  }
}
