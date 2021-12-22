import { Component, OnInit } from '@angular/core';
import { Message } from 'src/app/_models/message';
import { Pagination } from 'src/app/_models/pagination';
import { MessageService } from 'src/app/_services/message.service';


@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {
  messages: Message[] = [];     
  pagination: Pagination;
  container = 'Outbox';              
  pageNumber = 1;  
  pageSize = 6;  
  loading = false;

  constructor(private messageService: MessageService) { }

  ngOnInit(): void {      this.loadMessages();  }

  loadMessages() {
    this.loading = true;
    this.messageService.getMessages(this.pageNumber, this.pageSize, this.container).subscribe(response => {
    this.messages = response.result;
    this.pagination = response.pagination;
    this.loading = false;
    })
  }

  deleteMessage(id: number) {    this.messageService.deleteMessage(id).subscribe(() => {
                                                this.messages.splice(this.messages.findIndex(m => m.id === id), 1);
    })  }

  pageChanged(event: any) {
    this.pageNumber = event.page;
    this.loadMessages();
  }

}