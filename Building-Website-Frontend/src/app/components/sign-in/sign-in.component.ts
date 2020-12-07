
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { state } from 'src/app/model/state';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
  email: string;
  password: string;
  loginForm: FormGroup;

  constructor(private titleService:Title,
              private userService: UserService,
              private router: Router) 
              {
                
              }

  ngOnInit() {
    this.loginForm = new FormGroup({
      email: new FormControl(this.email, Validators.email),
      password: new FormControl(this.password, Validators.required)
    })
  }

  loginClick(){
    if(this.loginForm.valid){
      this.userService.login(this.loginForm.value.email, this.loginForm.value.password).subscribe(result => {
        console.log(result);
        if(result.isSuccess == true){
          state.userId = result.userId;
          state.userFirstName = result.firstName;
          state.userLastName = result.lastName;
          this.router.navigate(['/']);
        }
        else{
          alert("Invalid username or Password");
        }
      })
    }
    else{
      alert("Please input email and password");
    }
  }

}
