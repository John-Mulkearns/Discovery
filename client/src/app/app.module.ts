import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule , ReactiveFormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import { MemberListComponent } from './components/members/member-list/member-list.component';
import { MemberDetailComponent } from './components/members/member-detail/member-detail.component';
import { ListsComponent } from './components/lists/lists/lists.component';
import { MessagesComponent } from './components/messages/messages/messages.component';
import { SharedModule } from './shared/shared.module';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './shared/interceptors/error.interceptor';
import { MemberCardComponent } from './components/members/member-card/member-card.component';
import { JwtInterceptor } from './shared/interceptors/jwt.interceptor';
import { MemberEditComponent } from './components/members/member-edit/member-edit.component';
import {TextInputComponent} from './shared/forms/text-input/text-input.component';
import { PhotoEditorComponent } from './components/members/photo-editor/photo-editor.component';
import { NgxSpinnerModule } from 'ngx-spinner';
// import { LoadingInterceptor } from './_interceptors/loading.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    MemberListComponent,
    MemberDetailComponent,
    ListsComponent,
    MessagesComponent,
    MemberCardComponent,
    MemberEditComponent,
    TextInputComponent,
    PhotoEditorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule,
    ReactiveFormsModule,
    NgxSpinnerModule
   
  ],
  exports: [BsDropdownModule, ToastrModule],

  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true  },
    {provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true}
    //,  {provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true}
  ],

  bootstrap: [AppComponent]
})
export class AppModule { }
