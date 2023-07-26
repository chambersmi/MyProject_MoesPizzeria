/* This service calls the API */
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AppetizersService {

  constructor(private http:HttpClient) { }

  readonly baseURL = "http://localhost:5029/api/AppetizerMenu";

  getAppetizers() {
    return this.http.get(this.baseURL);
  }
}
