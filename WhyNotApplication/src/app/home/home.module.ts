import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePageComponent } from './home-page/home-page.component';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HeaderComponent } from './home-page/header/header.component';
import { ContentComponent } from './home-page/content/content.component';
import { ModuleHeaderComponent } from './home-page/header/module-header/module-header.component';

@NgModule({
  declarations: [
    HomePageComponent,
    HeaderComponent,
    ContentComponent,
    ModuleHeaderComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule,
    FlexLayoutModule
  ],
})
export class HomeModule { }
