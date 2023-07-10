import { CanActivateFn } from '@angular/router';

export const emailPrivateGuard: CanActivateFn = (route, state) => {
  return localStorage.getItem('email')? true : false;
};

export const emailPublicGuard: CanActivateFn = (route, state) => {
  return localStorage.getItem('email')? false : true;
};

