import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import {map} from 'rxjs/operators';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'        //this means no need to add to providers array in app.module
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();




  constructor(private http: HttpClient) { }
  
//#region 12-21 stuff  
/*  
🔴🟥 🔶 🟠🟧 🔷 
this login method receives credentials from the login form in the navbar, 
for now those credentials are called model and used as the body sent in the Post request

*/


//#endregion


login(model: any){

        // return this.http.post(this.baseUrl +'account/login', model);   
        // this basic service works, next is the version with .pipe chained on
        return this.http.post(this.baseUrl +'account/login', model).pipe(
          map(
                    (reponse: any)=>{
                    const user=reponse;
      if(user) 
            {
                localStorage.setItem('user', JSON.stringify(user));      
                // I give the setItem a key called user, and pass to it the stringyfied user
                this.currentUserSource.next(user);
                //the next method is the fluent api to pass in value I want, the user is now an observable
            }

  
}


          )

        )


      }

  
setCurrentUser(user: User){
  this.currentUserSource.next(user);
}


logout (){
localStorage.removeItem('user');
this.currentUserSource.next(null!);
}







}
