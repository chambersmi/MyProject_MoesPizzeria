import { Component, OnInit } from '@angular/core';
import { AppetizersService } from 'src/app/services/appetizers.service';

@Component({
  selector: 'app-appetizers',
  templateUrl: './appetizers.component.html',
  styleUrls: ['./appetizers.component.css'],
})
export class AppetizersComponent implements OnInit {
  appetizers:any;

  constructor(public appService:AppetizersService) {
    this.appService.getAppetizers().subscribe((data) => {
      this.appetizers=data;
    })
  }


  ngOnInit(): void {
  }

  addToCart(name:string) {
    alert(`You added ${name} to the cart`);
  }
}

