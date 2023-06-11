//exercicio 05 - criar um mock para a listagem dos dados.

var mock = [
    {
        titulo: 'Algorítmos',
        imagem: './img./algoritmos.jpg',
        subtitulo: 'Entendendo Algorítmos: Um Guia Ilustrado Para Programadores e Outros Curiosos'
    },
    {
        titulo: 'Funções ocultas no CHATGPT',
        imagem: './img/chatGpt.jpg',
        subtitulo: 'Dicas e Comandos Avançados Para Turbinar Seus Conhecimentos '
    },
    {
        titulo: 'Design de Produto',
        imagem: './img/desingProd.jpg',
        subtitulo:'Uma visão Product-Led sobre design de produtos digitais'
    },
    {
        titulo: 'Inspirado',
        imagem: './img/inspirado.jpg',
        subtitulo: 'Como criar produtos de tecnologia que os clientes amam'
    },
    {
        titulo: 'Técnicas de Invasão',
        imagem: './img/invasao.jpg',
        subtitulo: 'Aprenda as técnicas usadas por hackers em invasões reais'
    },
    {
        titulo: 'JavaScript',
        imagem: './img/JSOracle.jpg',
        subtitulo:'O Guia Definitivo'
    },
    {
        titulo: 'Criando Microsserviços',
        imagem: './img/microservicos.jpg',
        subtitulo: 'Projetando sistemas com componentes menores e mais especializados'
    },
    {
        titulo: 'Programação Web com Node.js',
        imagem: './img/node.jpg',
        subtitulo: 'Completo, do Front-end ao Back-end'
    },
    {
        titulo: 'Padrões JavaScript',
        imagem: './img/padraoJS.jpg',
        subtitulo:'Padrões JavaScript'
    }
]

sessionStorage.setItem("mock", JSON.stringify(mock));
const album = document.getElementById("album");

function busca() {
    album.innerHTML = '';
    const recuperado = sessionStorage.getItem("mock");
    const parseado = JSON.parse(recuperado);
    const busca = document.getElementById("busca").value;

    parseado.forEach(element => {
        if (element.titulo.includes(busca) || element.subtitulo.includes(busca)) {
            const div = document.createElement("div");

            const h2 = document.createElement("h2");
            h2.innerHTML = element.titulo;
            div.appendChild(h2);
            

            const img = document.createElement("img");
            img.setAttribute('src', element.imagem)
            div.appendChild(img);
            

            const h3 = document.createElement("h3");
            h3.innerHTML = element.subtitulo;
            div.appendChild(h3);
          

            album.appendChild(div)
        }
    })
}