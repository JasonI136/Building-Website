import { HttpClient, HttpClientModule, HttpHeaderResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { userDto } from 'src/app/model/userDto';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  login(_email : string, _password : string): Observable<userDto>{
    const headers = new HttpHeaders().set('Content-Type', 'application/json').set('Token','123456');

    return this.http.post<userDto>('https://localhost:44353/api/user/login', 
    {
        email: _email,
        password: _password
    }, {headers: headers});
  }

  registration(_userDto: userDto):Observable<userDto>{
    const headers = new HttpHeaders().set('Content-Type','application/json');

    return this.http.post<userDto>('https://localhost:44353/api/user/registration',
    {
      firstName: _userDto.firstName,
      lastName: _userDto.lastName,
      email:_userDto.email,
      password:_userDto.password,
      phoneNumber: _userDto.phoneNumber,
      dob:_userDto.dob,
    },{headers:headers});
  }
}
