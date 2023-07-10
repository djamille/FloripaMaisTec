import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-busca',
  templateUrl: './busca.component.html',
  styleUrls: ['./busca.component.css']
})
export class BuscaComponent {
  valorDigitado ='';
  @Output() mudancaValor = new EventEmitter<string>();

  valorAlterado(){
    this.mudancaValor.emit(this.valorDigitado);
  }
}
