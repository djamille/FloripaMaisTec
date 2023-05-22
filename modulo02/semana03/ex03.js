//Escreva uma função em JavaScript para calcular o Índice de Massa Corporal (IMC) de uma pessoa.


function calcularIMC(peso, altura) {
    var resultado = peso / (altura * altura)
        if (resultado < 18.5){
            console.log("O seu IMC é: " +resultado.toFixed(2) + ", está abaixo do recomendado para a sua altura.")
        }
        else if(resultado > 18.5 && resultado < 24.9){
            console.log("O seu IMC é: " +resultado.toFixed(2) + ", é considerado normal para a sua altura.")
        }
        else if(resultado => 24.9 && resultado < 30){
            console.log("O seu IMC é: " +resultado.toFixed(2) + ", está acima do recomendado para a sua altura.")
        }
        else if(resultado => 30 && resultado <86.7){
            console.log("O seu IMC é: " +resultado.toFixed(2) + ", está acima do recomendado para a sua altura.")
        }

    return resultado.toFixed(2)
}


calcularIMC(80, 1.76)

