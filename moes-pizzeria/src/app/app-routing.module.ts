import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { AppetizersComponent } from './menu-items/appetizers/appetizers.component';
import { HomeComponent } from './home/home.component';
import { PizzasComponent } from './menu-items/pizzas/pizzas.component';
import { CalzonesComponent } from './menu-items/calzones/calzones.component';
import { GrindersComponent } from './menu-items/grinders/grinders.component';
import { SaladsComponent } from './menu-items/salads/salads.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'Appetizers', component:AppetizersComponent},
  {path:'Pizzas', component: PizzasComponent},
  {path:'Calzones',component: CalzonesComponent},
  {path:'Grinders',component: GrindersComponent},
  {path:'Salads',component: SaladsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
