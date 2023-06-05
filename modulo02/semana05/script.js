let senha = document.getElementById('senha');
let senhaC = document.getElementById('senhaC');

function validarSenha() {
    if (senha.value === senhaC.value) {
        senhaC.setCustomValidity("");
        return true;
      } else {
        senhaC.setCustomValidity("Senhas diferentes!");
        senhaC.reportValidity();
        return false;
      }
}

// verificar também quando o campo for modificado, para que a mensagem suma quando as senhas forem iguais
senhaC.addEventListener('input', validarSenha);