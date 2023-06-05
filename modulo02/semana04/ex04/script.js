function somar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 + num2;

    // Local               Exercicio 05
    let historico = JSON.parse(localStorage.getItem('historico')) || [];
    historico.push(resultado);
    localStorage.setItem('historico', JSON.stringify(historico));

    document.getElementById('resultado').textContent = resultado;
    

    alert("A soma dos dois números é: " + resultado);           //Exercicio 04 - Crie um botão em HTML e adicione um ouvinte de evento que exiba um alerta na tela quando o botão for clicado.
}

function diminuir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 - num2;

    let historico = JSON.parse(localStorage.getItem('historico')) || [];
    historico.push(resultado);
    localStorage.setItem('historico', JSON.stringify(historico));

    document.getElementById('resultado').textContent = resultado;

    alert("A diminuição dos dois números é: " + resultado);
}

function dividir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 / num2;

    let historico = JSON.parse(localStorage.getItem('historico')) || [];
    historico.push(resultado);
    localStorage.setItem('historico', JSON.stringify(historico));

    document.getElementById('resultado').textContent = resultado;

    alert("A divasão entre os dois números é: " + resultado);
}

function multiplicar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 * num2;

    let historico = JSON.parse(localStorage.getItem('historico')) || [];
    historico.push(resultado);
    localStorage.setItem('historico', JSON.stringify(historico));

    document.getElementById('resultado').textContent = resultado;
    
    alert("A divisão entre os dos dois números é: " + resultado);
}