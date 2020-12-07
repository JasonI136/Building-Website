import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ContactUsService } from 'src/app/core/services/contact-us.service';
import { UserService } from 'src/app/core/services/user.service';
import { contactDto } from 'src/app/model/contactDto';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrls: ['./contact-us.component.css']
})
export class ContactUsComponent implements OnInit {
  contactUsForm: FormGroup;
  firstName: string;
  lastName: string;
  subject: string;
  textArea: string;
  contactDto: contactDto;
  
  
  constructor(private contactUsService: ContactUsService,
              private router: Router) 
  {
  
  }

  ngOnInit(): void {
    this.contactUsForm = new FormGroup({
      firstName: new FormControl("", Validators.required),
      lastName: new FormControl("", Validators.required),
      subject: new FormControl("", Validators.required),
      textArea: new FormControl("", Validators.required),
    })
  }

  ContactUsClick(){
    if(this.contactUsForm.valid){
      this.contactDto = {
        firstName: this.contactUsForm.value.firstName,
        lastName: this.contactUsForm.value.lastName,
        subject: this.contactUsForm.value.subject,
        textArea: this.contactUsForm.value.textArea,
      }
      this.contactUsService.sendMessage(this.contactDto).subscribe(result =>
        {
          console.log(result);
          alert("functionality working hello world")
        })
    }
    else
    {
      alert("Something has went wrong")
    }
  }
}
