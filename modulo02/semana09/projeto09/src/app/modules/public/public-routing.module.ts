import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EsqueciSenhaComponent } from 'src/app/components/esqueci-senha/esqueci-senha.component';
import { LoginComponent } from 'src/app/components/login/login.component';
import { ContentLayoutComponent } from 'src/app/layouts/content-layout/content-layout.component';

const routes: Routes = [
  {
    path: '',
    component: ContentLayoutComponent,
    children:[
      {path:'login', component:LoginComponent},
      {path: 'esqueci-senha', component: EsqueciSenhaComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicRoutingModule { }
