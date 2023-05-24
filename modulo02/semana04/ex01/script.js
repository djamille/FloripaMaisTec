function maiorMenor() {
    let numero = document.getElementById('numero').value
    let resultado = numero

    if (resultado < 10){
        document.getElementById('resultado').innerHTML =  "O número é menor que 10."
    } 
    else if (resultado == 10){
        document.getElementById('resultado').innerHTML =  "O número é igual a 10."
    }
    else{
        document.getElementById('resultado').innerHTML = "O número é maior que 10."
    }
}