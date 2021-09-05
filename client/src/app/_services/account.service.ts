    import { HttpClient } from '@angular/common/http';
    import { Injectable } from '@angular/core';
     import {map} from 'rxjs/operators';
    import { User } from '../_models/user';
   import { ReplaySubject } from 'rxjs';
import { Person } from '../_models/person';

    @Injectable({
      providedIn: 'root'        
    })
    export class AccountService {
      baseUrl = 'https://localhost:5001/api/';
      private currentUserSource = new ReplaySubject<User>(1);
      currentUser$ = this.currentUserSource.asObservable();




      constructor(private http: HttpClient) { }
      

    login(model: any){

  return this.http.post(this.baseUrl +'account/login', model).pipe(
              map(
                        (reponse: any)=>{
                        const user=reponse;
          if(user) 
                {
                    localStorage.setItem('user', JSON.stringify(user));      
                  
                    this.currentUserSource.next(user);

                }   }
              )    )
          }


      
  register(model: any) {
    return this.http.post(this.baseUrl + 'account/register', model).pipe(
      map((user: any) => {
        if (user) {
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
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
