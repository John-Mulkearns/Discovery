import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'        //this means no need to add to providers array in app.module
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }
  
//#region 12-21 stuff  
/*  
🔴🟥 🔶 🟠🟧 🔷 
this login method receives credentials from the login form in the navbar, 
for now those credentials are called model and used as the body sent in the Post request

*/


//#endregion


login(model: any){

        return this.http.post(this.baseUrl +'account/login', model);
      }

  








}
