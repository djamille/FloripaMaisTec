import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { BebidaItem } from "src/app/shared/models/bebida-item.model";
import { AppService } from "src/app/shared/service/app.service";


@Component({
  selector: 'app-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.css']
})
export class BebidasComponent {
  bebidaLista$: Observable<BebidaItem[]> = this.bebidaService.getBebidas();

  constructor(private bebidaService: AppService) {}
}
