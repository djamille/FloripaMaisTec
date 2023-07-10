import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PrivateRoutingModule } from './private-routing.module';
import { HomeComponent } from 'src/app/components/home/home.component';
import { LivrosComponent } from 'src/app/components/livros/livros.component';
import { FullLayoutComponent } from 'src/app/layouts/full-layout/full-layout.component';
import { HeaderComponent } from 'src/app/components/header/header.component';
import { AppModule } from 'src/app/app.module';


@NgModule({
  declarations: [
    HeaderComponent,
    HomeComponent,
    LivrosComponent,
    FullLayoutComponent
  ],
  imports: [
    CommonModule,
    PrivateRoutingModule
  ]
})
export class PrivateModule { }
