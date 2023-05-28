function somar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 + num2;

    alert("A soma dos dois números é: " + resultado);           //Exercicio 04 - Crie um botão em HTML e adicione um ouvinte de evento que exiba um alerta na tela quando o botão for clicado.
}

function diminuir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 - num2;
    alert("A diminuição dos dois números é: " + resultado);
}

function dividir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 / num2;
    alert("A divasão entre os dois números é: " + resultado);
}

function multiplicar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 * num2;
    alert("A divisão entre os dos dois números é: " + resultado);
}