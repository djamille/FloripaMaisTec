import { Component } from '@angular/core';

@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent {
  num1 = "";
  num2 = "";
  resultado = parseInt("0");

  somar() {
    this.resultado = parseInt(this.num1) + parseInt(this.num2)
    console.log(this.resultado)
  }

  diminuir() {
    this.resultado = parseInt(this.num1) - parseInt(this.num2)
    console.log(this.resultado)
  }

  multiplicar() {
    this.resultado = parseInt(this.num1) * parseInt(this.num2)
    console.log(this.resultado)
  }

  dividir() {
    this.resultado = parseInt(this.num1) / parseInt(this.num2)
    console.log(this.resultado)
  }

  limpar(){
    this.num1 = "0";
    this.num2 = "0";
    this.resultado = 0;
  }
}
