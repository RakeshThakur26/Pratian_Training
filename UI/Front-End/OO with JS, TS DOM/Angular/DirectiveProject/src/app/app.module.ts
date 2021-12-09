import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClassBindComponent } from './class-bind/class-bind.component';
import { EventbindComponent } from './eventbind/eventbind.component';
import { StylebindComponent } from './stylebind/stylebind.component';
import { DirectiveComponent } from './directive/directive.component';
import { FormsModule } from '@angular/forms';
import { PipesComponent } from './pipes/pipes.component';
import { Pipe2Component } from './pipe2/pipe2.component';
import { Pipe3Component } from './pipe3/pipe3.component';
import { Pipe4Component } from './pipe4/pipe4.component';
import { DisplayComponent } from './display/display.component';

@NgModule({
  declarations: [
    AppComponent,
    ClassBindComponent,
    EventbindComponent,
    StylebindComponent,
    DirectiveComponent,
    PipesComponent,
    Pipe2Component,
    Pipe3Component,
    Pipe4Component,
    DisplayComponent
  ],
  imports: [BrowserModule, AppRoutingModule,FormsModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
