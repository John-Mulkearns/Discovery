import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
@Input()  usersFromHomeComponent: any;
@Output() cancelRegister = new EventEmitter();
public model: any;

  constructor() { }

  ngOnInit(): void {
  }

public register(){
  console.log(this.model); 
}

public cancel(){
  this.cancelRegister.emit(false);    // to turn off the registerMode property in the parent
  console.log("cancelled");


}


}
