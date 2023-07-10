import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from 'src/app/components/home/home.component';
import { LivrosComponent } from 'src/app/components/livros/livros.component';
import { FullLayoutComponent } from 'src/app/layouts/full-layout/full-layout.component';

const routes: Routes = [
  {
    path:'',
    component: FullLayoutComponent,
    children:[
      {path: 'home', component: HomeComponent},
      {path: 'livros', component: LivrosComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PrivateRoutingModule { }
