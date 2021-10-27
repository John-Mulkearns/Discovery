import { Component, Input, OnInit } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { take } from 'rxjs/operators';
import { Member } from 'src/app/_models/member';
import { Photo } from 'src/app/_models/photo';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { environment } from 'src/environments/environment';
import { MembersService } from '../members.service';

@Component({
  selector: 'app-photo-editor',
  templateUrl: './photo-editor.component.html',
  styleUrls: ['./photo-editor.component.css']
})
export class PhotoEditorComponent implements OnInit {
@Input() member: Member;
uploader: FileUploader;
hasBaseDropZoneOver: false;
baseUrl=environment.apiUrl;
user: User;


  constructor(private accountService: AccountService,
    private membersService : MembersService) { 
this.accountService.currentUser$.pipe(take(1)).subscribe(user=>this.user=user)

  }

  ngOnInit(): void {this.intializeUploader();  }

  fileOverBase(e: any) {
    this.hasBaseDropZoneOver=e;
  }



setMainPhoto(photo: Photo){
this.membersService.setMainPhoto(photo.id).subscribe(()=> {
this.user.photoUrl=photo.url
this.accountService.setCurrentUser(this.user);
this.member.photoUrl=photo.url;
this.member.photos.forEach(p=> {
  if(p.isMain) p.isMain=false;
  if(p.id===photo.id) p.isMain=true;
})

})


}






  intializeUploader(){
this.uploader=new FileUploader({

url: this.baseUrl + 'users/add-photo'  ,
authToken: 'Bearer ' + this.user.token,
isHTML5: true,
allowedFileType: ['image'],
removeAfterUpload: true,
autoUpload: false,
maxFileSize: 5 * 1024 * 1024
});

this.uploader.onAfterAddingFile=(file)=>{
  file.withCredentials=false; // we are already sending bearer token with the file
}

this.uploader.onSuccessItem=(item, response, status, headers)=>{
  if(response){ const photo=JSON.parse(response);
    this.member.photos.push(photo);   //add photo into photo array

  
  }
}
  }

}
