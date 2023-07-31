import { Component, OnInit } from "@angular/core";
import { ComidaItem } from "src/app/shared/models/comida-item.model";
import { AppService } from "src/app/shared/service/app.service";

@Component({
  selector: 'app-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.css']
})
export class ComidasComponent implements OnInit {
  comidaLista: ComidaItem[] = [];
  mensagem = "Não foi encontrado registros";

  constructor(private comidaService: AppService) {}

  ngOnInit(): void {
    this.mensagem = "Carregando...";
    this.comidaService.getComidas().subscribe((result) => {
      console.log("result", result);
      this.comidaLista = result;
    });
  }
}
