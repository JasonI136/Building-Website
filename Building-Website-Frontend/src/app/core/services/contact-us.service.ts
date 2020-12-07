import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { contactDto } from 'src/app/model/contactDto';
import{HttpClient, HttpHeaders} from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ContactUsService {

  constructor(private http: HttpClient) { }

  sendMessage(_contactDto: contactDto): Observable<contactDto>{
    const headers = new HttpHeaders().set('Content-Type', 'application/json');

    return this.http.post<contactDto>('https://localhost:44353/api/Contact/sendMessage',
    {
      firstName: _contactDto.firstName,
      lastName: _contactDto.lastName,
      subject: _contactDto.subject,
      textArea: _contactDto.textArea,
    },{headers: headers});
  }
}
