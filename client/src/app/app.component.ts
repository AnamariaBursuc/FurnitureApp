import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Furniture App';
  constructor (private http: HttpClient, private accountService: AccountService) {}
  users: any;
  ngOnInit() {
    this.setCurrentUser();
  }
  setCurrentUser(){
    const user: User = JSON.parse(localStorage.getItem('user'));
    this.accountService.setCurrentUser(user);
  }
}
