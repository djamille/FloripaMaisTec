function validarLogin(){    
    let login = JSON.parse(sessionStorage.getItem("login"));
    let email = document.getElementById('email').value;
    let senha = document.getElementById('senha').value;
    let user = login.find(user => user.email == email && user.senha == senha);

    if (user != null) {
        sessionStorage.setItem("loggedUser", JSON.stringify(user));
        window.location.href = "./index.html";
    } else {
        alert("Email ou senha incorretos");
    }
}