import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClassBindComponent } from './class-bind/class-bind.component';
import { DirectiveComponent } from './directive/directive.component';
import { DisplayComponent } from './display/display.component';
import { EventbindComponent } from './eventbind/eventbind.component';
import { Pipe2Component } from './pipe2/pipe2.component';
import { PipesComponent } from './pipes/pipes.component';
import { StylebindComponent } from './stylebind/stylebind.component';

const routes: Routes = [
  {path:'classbind', component: ClassBindComponent},
  {path:'directive', component: DirectiveComponent},
  {path:'eventbind', component: EventbindComponent},
  {path:'stylebind', component: StylebindComponent},
  {path:'pipe1', component: PipesComponent},
  {path:'pipe2', component: Pipe2Component},
  {path:'display', component: DisplayComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
