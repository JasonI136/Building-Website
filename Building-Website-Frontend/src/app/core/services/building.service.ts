import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { buildingDto } from 'src/app/model/buildingDto';

@Injectable({
  providedIn: 'root'
})
export class BuildingService {
  
  constructor(private http: HttpClient) { }

  buildingList(): Observable<buildingDto[]>{
    const headers = new HttpHeaders().set('Content-Type', 'application/json').set('Token','123456');

    return this.http.get<buildingDto[]>('https://localhost:44353/api/building/list', {headers: headers});
  }

  buildingView(buildingId):Observable<buildingDto> {
    const headers = new HttpHeaders().set('Content-Type', 'application/json').set('Token','123456');

    return this.http.get<buildingDto>('https://localhost:44353/api/building/view/'+ buildingId, {headers: headers});
  }

}
