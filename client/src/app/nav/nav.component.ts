import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable } from 'rxjs';
import { User } from '../_models/user';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
    loggedIn=false;

  constructor(public accountService: AccountService) { }

  ngOnInit(): void {
  }

  login() {
  /* 
    console.log(this.model);
  */
    this.accountService.login(this.model).subscribe(response => {     //you know its the Dto you build that gets returned
      console.log(response);
      this.loggedIn=true;
    }, error => {
      console.log(error);
    })
   
  }

  logout() {   
    this.accountService.logout();
    this.loggedIn=false;  }



/* temp dev method used to inspect local storage with chrome tools */

getCurrentUser() {
this.accountService.currentUser$.subscribe(user =>
  {
    this.loggedIn=!!user;
  },
  error=> {
    console.log(error);
  }


  )

}


}