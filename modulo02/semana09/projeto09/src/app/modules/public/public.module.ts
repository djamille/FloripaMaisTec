import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicRoutingModule } from './public-routing.module';
import { LoginComponent } from 'src/app/components/login/login.component';
import { EsqueciSenhaComponent } from 'src/app/components/esqueci-senha/esqueci-senha.component';
import { ContentLayoutComponent } from 'src/app/layouts/content-layout/content-layout.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    LoginComponent,
    EsqueciSenhaComponent,
    ContentLayoutComponent
  ],
  imports: [
    CommonModule,
    PublicRoutingModule,
    FormsModule
  ]
})
export class PublicModule { }
