import { Component } from '@angular/core';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private router: Router){

  }

  email = '';

  onClick(){
    localStorage.setItem("email", this.email);
    this.router.navigate(['/private/home']);
  }
}
