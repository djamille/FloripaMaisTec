import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { NotFoundLayuotComponent } from './layouts/not-found-layuot/not-found-layuot.component';
import { emailPrivateGuard, emailPublicGuard } from './guards/email.guard';

const routes: Routes = [
  {path: '', redirectTo:'public/login', pathMatch:'full'},
  {
    path:'private',
    canActivate: [emailPrivateGuard],
    loadChildren: () => import('./modules/private/private.module').then(m => m.PrivateModule)
  },
  {
    path:'public',
    canActivate: [emailPublicGuard],
    loadChildren: () => import('./modules/public/public.module').then(m => m.PublicModule)
  },
  {
    path: '**',
    component: NotFoundLayuotComponent,
    children:[
      {path: '', component: NotFoundComponent}
    ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
