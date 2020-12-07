import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { userDto } from 'src/app/model/userDto';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  registrationForm: FormGroup;
  userDto: userDto;

  constructor(private titleService:Title,
              private userService: UserService,
              private router: Router) {
   }

  ngOnInit(): void {
    this.registrationForm = new FormGroup({
      firstName: new FormControl(""),
      lastName: new FormControl(""),
      email: new FormControl(""),
      password: new FormControl("", Validators.required),
      dob: new FormControl("", Validators.required),
      phoneNumber: new FormControl("", Validators.required),
    })
  }

  registrationClick(){
    if (this.registrationForm.valid){
      this.userDto = {
        userId: 0,
        firstName: this.registrationForm.value.firstName,
        lastName: this.registrationForm.value.lastName,
        email: this.registrationForm.value.email,
        password: this.registrationForm.value.password,
        dob: this.registrationForm.value.dob,
        phoneNumber: this.registrationForm.value.phoneNumber,
        isSuccess: true,
      }
      this.userService.registration(this.userDto).subscribe(result => {
        console.log(result);
        if(result.isSuccess == true){
          this.router.navigate(['/'])
        }
      })
    }
  }
}
