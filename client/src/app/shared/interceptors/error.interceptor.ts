import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { NavigationExtras, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { catchError } from 'rxjs/operators';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router: Router, private toastr: ToastrService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError(error => {
                        if(error) {
                        // if there is error response then that IS the object here called error
                        switch (error.status) {
    case 400:
      {
        if (error.error.errors) {
          const modalStateErrors = [];

          for (const key in error.error.errors) {

            if (error.error.errors[key]) {

              modalStateErrors.push(error.error.errors[key])
            }

          }
          throw modalStateErrors.flat();
        }
          else if(typeof(error.error)==='object')
          {          this.toastr.error(error.status, 'bad request')        }
          else{this.toastr.error(error.error, error.status)};        
        }
        break;

    case 401:
   //   this.toastr.error(error.statusText, error.status);
             this.toastr.error('Unauthorised');
      break;

    case 404:
      this.router.navigateByUrl('not-found');     // at this point there's no not-found component, add it l8tr
      break;

    case 500:
      const navigationEtras: NavigationExtras = { state: { error: error.error } }
      this.router.navigateByUrl('/server-error', navigationEtras);
      break;

    default:
      this.toastr.error('looks like enemy have been messing things up a little');
      console.log(error);
       break;
  }

}

return throwError(error)

      })
    )
  }
}
