import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { AppetizersComponent } from './menu-items/appetizers/appetizers.component';
import { HomeComponent } from './home/home.component';
import { PizzasComponent } from './menu-items/pizzas/pizzas.component';
import { CalzonesComponent } from './menu-items/calzones/calzones.component';
import { GrindersComponent } from './menu-items/grinders/grinders.component';
import { SaladsComponent } from './menu-items/salads/salads.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    AppetizersComponent,
    HomeComponent,
    PizzasComponent,
    CalzonesComponent,
    GrindersComponent,
    SaladsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
