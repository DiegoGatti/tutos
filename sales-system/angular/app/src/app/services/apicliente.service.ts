import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiclienteService {

  url = "https://localhost:5001/cliente";

  constructor(private _http: HttpClient) { }

  getClientes(): Observable<Response> {
    return this._http.get<Response>(this.url);
  }
}
