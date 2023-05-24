function somar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 + num2;

    document.getElementById('resultado').innerText = resultado
}

function diminuir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 - num2;

    document.getElementById('resultado').innerText = resultado
}

function dividir() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 / num2;

    document.getElementById('resultado').innerText = resultado
}

function multiplicar() {
    let num1 = parseInt(document.getElementById('num1').value)
    let num2 = parseInt(document.getElementById('num2').value)

    let resultado = num1 * num2;

    document.getElementById('resultado').innerText = resultado
}