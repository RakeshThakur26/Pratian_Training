import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AvailableSystemsComponent } from './available-systems/available-systems.component';
import { SystemAllocationComponent } from './system-allocation/system-allocation.component';

const routes: Routes = [
  {path:'SysAlloc', component:SystemAllocationComponent},
  {path:'Available', component:AvailableSystemsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
