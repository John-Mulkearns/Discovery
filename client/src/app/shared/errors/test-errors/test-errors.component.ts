import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css']
})
export class TestErrorsComponent implements OnInit {

 baseUri='https://localhost:5001/api/';
 validationErrors: string []=[];

  
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }


  get404error(){
    this.http.get(this.baseUri +'Errors/not-found').subscribe(response=>{console.log(response); },
    error=>{
      console.log(error);
                }
        )           }


   get400error(){
          this.http.get(this.baseUri +'Errors/bad-request').subscribe(response=>{console.log(response); },
          error=>{
            console.log(error);
                      }
              )           }


              get500error(){
                this.http.get(this.baseUri +'Errors/server-error').subscribe(response=>{console.log(response); },
                error=>{
                  console.log(error);
                            }
                    )           }


                    get401error(){
                      this.http.get(this.baseUri +'Errors/auth').subscribe(response=>{console.log(response); },
                      error=>{
                        console.log(error);
                                  }
                          )           }


                                  //sends an empty object
                          get400validationError(){
                            this.http.post(this.baseUri +'account/register' ,{}).subscribe(response=>{
                              console.log(response); },
                            error=>{
                              console.log(error);
                                  this.validationErrors=error;

                                        }
                                )           }
      

}
