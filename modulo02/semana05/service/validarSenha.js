let logins = []       //cria array

function validarSenha() {
  let email = document.getElementById('email').value;       //captura o q foi incluido pélo usuario la no formulario HTML
  let senha = document.getElementById('senha').value;
  let senhaC = document.getElementById('senhaC').value;

  if (senha.length < 10) {
    alert ("A senha deve conter no mínimo 10 caracteres.")
  }
  else if (senha != senhaC)
  {
    alert("As senhas não conferem.")
  }
  else
  {
    const confereHistorico = sessionStorage.getItem("logins");          //criado constante que recebe a leitura dos dados da sessionStorage
    if (confereHistorico != null){            //se a constante for diferente de nulo...
      const parseado = JSON.parse(confereHistorico)         
      logins = parseado
    }
    logins.push({email: email, senha: senha});
    sessionStorage.setItem("logins",JSON.stringify(logins));
    window.location.href = './index.html';
  }
}
