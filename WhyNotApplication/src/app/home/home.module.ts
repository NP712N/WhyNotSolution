import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePageComponent } from './home-page/home-page.component';
import { MatCardModule } from '@angular/material/card';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HeaderComponent } from './home-page/header/header.component';
import { ContentComponent } from './home-page/content/content.component';

@NgModule({
  declarations: [
    HomePageComponent,
    HeaderComponent,
    ContentComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    FlexLayoutModule
  ],
})
export class HomeModule { }
