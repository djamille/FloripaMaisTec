fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")         //fazendo requisição de forma assincrona
    .then(response => response.json())                              //o primeiro then() é utilizado para tratar uma promise que é resolvida. Já o .json retorna um promise que tb precisa ser tratada
    .then(data => {                                                 // O 2º .then() então é para tratar a promise do método json().
        let divDados = document.getElementById('dados');            //busca e retorna o elemento através de seu identificador, a propriedade id
        data.reverse().forEach(item => {                            //método reverse() inverte os itens de um array
            let div = document.createElement('div');                //percorre o array
            div.classList.add('lista_nomes');                       //adicionando classe
            div.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;         //conteúdo de texto
            divDados.appendChild(div);                               //insere um elemento filho ao elemento pai
        });
    })
    .catch(error => console.error('Erro:', error));                  //será executado se um erro ocorrer