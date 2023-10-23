import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModalTestComponent } from './modal-test/modal-test.component';
import { HeroTestComponent } from './hero-test/hero-test.component';

import { ModalModule } from "ngx-bootstrap/modal";

@NgModule({
  declarations: [
    AppComponent,
    ModalTestComponent,
    HeroTestComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ModalModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
